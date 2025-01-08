using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MsgUI
{
    internal static class Wtsapi32
    {
        internal static List<string> GetLoggedInUsers()
        {
            var result = new List<string>();

            if (WTSEnumerateSessions((IntPtr)WTS_CURRENT_SERVER_HANDLE, 0, 1, out IntPtr pSessions, out int nSessions))
            {
                var nDataSize = Marshal.SizeOf(typeof(WTS_SESSION_INFO));
                var pCurrentSession = pSessions;

                for (int i = 0; i < nSessions; i++)
                {
                    WTS_SESSION_INFO si = (WTS_SESSION_INFO)Marshal.PtrToStructure(pCurrentSession, typeof(WTS_SESSION_INFO));

                    if (si.State == WTS_CONNECTSTATE_CLASS.WTSActive || si.State == WTS_CONNECTSTATE_CLASS.WTSConnected)
                    {
                        var queryResult = WTSQuerySessionInformation((IntPtr)WTS_CURRENT_SERVER_HANDLE, si.SessionId, WTS_INFO_CLASS.WTSUserName, out IntPtr pUserName, out uint nBytesReturned);

                        if (queryResult)
                        {
                            string sUserName = Marshal.PtrToStringUni(pUserName);

                            if (!string.IsNullOrEmpty(sUserName))
                            {
                                result.Add(sUserName);
                            }
                        }
                    }

                    pCurrentSession += nDataSize;
                }

                WTSFreeMemory(pSessions);
            }

            return result;
        }

        private const int WTS_CURRENT_SERVER_HANDLE = 0;
        private const int WTS_CURRENT_SESSION = -1;

        [DllImport("WTSApi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool WTSSendMessage(IntPtr hServer, int SessionId, string pTitle, int TitleLength, string pMessage, int MessageLength, int Style, int Timeout, out int pResponse, Boolean bWait);

        [DllImport("WTSApi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool WTSEnumerateSessions(IntPtr hServer, int Reserved, int Version, out IntPtr ppSessionInfo, out int pCount);

        [DllImport("WTSApi32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern void WTSFreeMemory(IntPtr pMemory);

        [DllImport("WTSApi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool WTSQuerySessionInformation(IntPtr hServer, int SessionId, WTS_INFO_CLASS WTSInfoClass, out IntPtr ppBuffer, out uint BytesReturned);

        private enum WTS_INFO_CLASS
        {
            WTSInitialProgram,
            WTSApplicationName,
            WTSWorkingDirectory,
            WTSOEMId,
            WTSSessionId,
            WTSUserName,
            WTSWinStationName,
            WTSDomainName,
            WTSConnectState,
            WTSClientBuildNumber,
            WTSClientName,
            WTSClientDirectory,
            WTSClientProductId,
            WTSClientHardwareId,
            WTSClientAddress,
            WTSClientDisplay,
            WTSClientProtocolType,
            WTSIdleTime,
            WTSLogonTime,
            WTSIncomingBytes,
            WTSOutgoingBytes,
            WTSIncomingFrames,
            WTSOutgoingFrames,
            WTSClientInfo,
            WTSSessionInfo,
            WTSSessionInfoEx,
            WTSConfigInfo,
            WTSValidationInfo,
            WTSSessionAddressV4,
            WTSIsRemoteSession
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct WTS_SESSION_INFO
        {
            public int SessionId;
            public string pWinStationName;
            public WTS_CONNECTSTATE_CLASS State;
        }

        private enum WTS_CONNECTSTATE_CLASS
        {
            /// <summary>
            /// A user is logged on to the WinStation. This state occurs when a user is signed in and actively connected to the device.
            /// </summary>
            WTSActive,

            /// <summary>
            /// The WinStation is connected to the client.
            /// </summary>
            WTSConnected,

            /// <summary>
            /// The WinStation is in the process of connecting to the client.
            /// </summary>
            WTSConnectQuery,

            /// <summary>
            /// The WinStation is shadowing another WinStation.
            /// </summary>
            WTSShadow,

            /// <summary>
            /// The WinStation is active but the client is disconnected. This state occurs when a user is signed in but not actively connected to the device, such as when the user has chosen to exit to the lock screen.
            /// </summary>
            WTSDisconnected,

            /// <summary>
            /// The WinStation is waiting for a client to connect.
            /// </summary>
            WTSIdle,

            /// <summary>
            /// The WinStation is waiting for a client to connect.
            /// </summary>
            WTSListen,

            /// <summary>
            /// The WinStation is waiting for a client to connect.
            /// </summary>
            WTSReset,

            /// <summary>
            /// The WinStation is waiting for a client to connect.
            /// </summary>
            WTSDown,

            /// <summary>
            /// The WinStation is waiting for a client to connect.
            /// </summary>
            WTSInit,
        }
    }
}
