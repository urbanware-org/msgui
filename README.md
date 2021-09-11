# *MsgUI* <img src="https://raw.githubusercontent.com/urbanware-org/msgui/main/Source/MsgUI/Resources/Logo/MsgUI_256x256.png" alt="MsgUI logo" height="128px" width="128px" align="right"/>

**Table of contents**
*   [Definition](#definition)
*   [Details](#details)
*   [Environment](#environment)
*   [Requirements](#requirements)
*   [Contact](#contact)
*   [Useless facts](#useless-facts)

----

<img src="https://raw.githubusercontent.com/urbanware-org/msgui/main/Source/MsgUI/Resources/Images/MsgUI.png" alt="MsgUI" align="right"/>

## Definition

Simple graphical front end for sending messages via `msg.exe` on *Windows* systems.

[Top](#msgui-)

## Details

Initially, *MsgUI* was developed for administrators of a terminal server to notify either all or a specific user of a certain event.

Even though, administrators should be able to use the command-line or the *PowerShell*, this program simplifies the notification process.

As you can see on the right, the project is quite elementary and, as such, not a complete alternative for the command-line use of `msg.exe`.

[Top](#msgui-)

## Environment

Even though *MsgUI* uses `msg.exe` on every *Windows* system, there are differences how the message is being displayed.

### Newer *Windows* versions

<img src="https://raw.githubusercontent.com/urbanware-org/msgui/main/Stuff/GitHub/MsgUI_Win2016.png" alt="MsgUI on Windows Server 2016" width="200px" align="right"/>For example, on *Windows Server 2016*, after the message has been sent, the screen of the recipients  gets darkened, sort of locked and the message is displayed in the center of the screen.

The user must confirm the message to continue working (if no delay is set to automatically hide it again).

This should also apply to *Windows 10* as well as *Windows Server 2012 R2*.

### Older *Windows* versions

<img src="https://raw.githubusercontent.com/urbanware-org/msgui/main/Stuff/GitHub/MsgUI_Win2008.png" alt="MsgUI on Windows Server 2008 R2" width="200px" align="right"/>For example, on *Windows Server 2008 R2*, a simple message box appears that can be moved.

Nevertheless, it is always on top (in the foreground) and cannot be minimized.

This is the default behavior on *Windows 7*, *Windows Server 2008* and below.

[Top](#msgui-)

## Requirements

### Binary

There are only two requirements in order to use the program:

*   *Microsoft Windows* version that contains `msg.exe` (should be included by default in *Windows 7* and above, but may not be included in Home Editions)
*   *Microsoft .NET Framework* 4.5 (or higher)

### Source code

The solution file requires at least *Microsoft Visual Studio 2012*. The initially uploaded binary has been compiled using *Visual Studio 2015 Community Edition*.

Feel free to fork and modify!

[Top](#msgui-)

## Contact

Any suggestions, questions, bugs to report or feedback to give?

You can contact me by sending an email to [dev@urbanware.org](mailto:dev@urbanware.org) or by opening a *GitHub* issue (which I would prefer if you have a *GitHub* account).

[Top](#msgui-)

## Useless facts

*   The first version uploaded on *GitHub* was *MsgUI* 1.1.6.0 built on Novemver 9<sup>th</sup>, 2017.

[Top](#msgui-)
