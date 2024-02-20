# Windows Virtual Desktop Helper

仅用于个人使用，原理请参阅原项目，本项目修改由ChatGpt实现。
功能：窗口切换，仅支持双窗口相互切换

Simple and lightweight app to help with Virtual Desktops for Windows 10 and Windows 11.

![Screenshot](Images/WindowsVirtualDeskopHelper%20Screenshot.png)

[Download v1.16 Setup (.msi)](https://github.com/dankrusi/WindowsVirtualDesktopHelper/releases/download/v1.16/WindowsVirtualDesktopHelper.Setup.v1.16.msi) | 
[Download v1.16 Executable (.zip)](https://github.com/dankrusi/WindowsVirtualDesktopHelper/releases/download/v1.16/WindowsVirtualDesktopHelper.Executable.v1.16.zip)

Windows comes builtin with virtual desktops, however some important features are missing, such
as displaying which desktop you are on when switching. Windows Virtual Desktop Helper helps
fix some of these missing features.

Keywords: Virtual Desktop indicator, Virtual Desktop name, Virtual Desktop number

Note: Currently Windows Virtual Desktop Helper is not code-signed, and may be reported as untrusted by Windows
Defender or other anti-virus applications. Typically, after enough users download, install, and report
the software as okay/safe, this warning will go away.

## Features

* Show desktop number in notification area
* Show desktop name when switching desktops
* Show prev/next desktop by clicking icons in notification area
* Show desktop initial in notification area
* Jump to desktop using hot keys
* Autostart with Windows
* Simple and lightweight
* Configurable
* Free

![Settings](Images/WindowsVirtualDeskopHelper%20Settings.png)

## Installation

### Requirements

Windows Virtual Desktop Helper needs the Microsoft .NET Framework 4.7 or higher in order to run. Most likely you already have this installed, otherwise you can get it from [dotnet.microsoft.com](https://dotnet.microsoft.com/en-us/download/dotnet-framework)

### Setup

You can install Windows Virtual Desktop Helper to your system using the setup program.

[Download WindowsVirtualDesktopHelper Setup v1.16.msi](https://github.com/dankrusi/WindowsVirtualDesktopHelper/releases/download/v1.16/WindowsVirtualDesktopHelper.Setup.v1.16.msi)

Note: Currently Windows Virtual Desktop Helper is not code-signed, and may be reported as malware by Windows
Defender or other anti-virus applications. Typically, after enough users download, install, and report
the software as okay/safe, this malware warning will go away. If you prefer to avoid some of these issues, use the Zip version of the executable instead.

### Executable

You can just run the executable file WindowsVirtualDesktopHelper.exe to use Windows Virtual Desktop Helper.

[Download WindowsVirtualDesktopHelper Executable v1.16.zip](https://github.com/dankrusi/WindowsVirtualDesktopHelper/releases/download/v1.16/WindowsVirtualDesktopHelper.Executable.v1.16.zip)

### Scoop

A command-line installer for Windows

[https://scoop.sh/](https://scoop.sh/)

```scoop bucket add extras```

```scoop install windows-virtualdesktop-helper```

## Thanks

Many thanks for the original API work done by [MScholtes](https://github.com/MScholtes) and contributions by [Flaflo](https://github.com/Flaflo).

Thanks to the following contributors:
 - [y2nd66](https://github.com/y2nd66)
 - [SleepyBag](https://github.com/SleepyBag)


## Donate

Do you like Windows Virtual Desktop Helper? 

[Donate via PayPal](https://www.paypal.com/donate/?hosted_button_id=BG5FYMAHFG9V6)


## Compatibility

Currently this app is compatible with Windows 10 and Windows 11. Microsoft is constantly changing their API for the Virtual Desktops, so it appears not all builds of Windows are fully working yet.

The following builds have been confirmed as working:

* Windows 10
  - 21H2 19044 
* Windows 11
  - 21H2 22000
  - 22H2 22621
  - 22H2 25158-25267
  - 25314 (experimental)
  
The following builds have been cofnirmed as NOT working:

* na
  
The following versions are not supported:

* Windows 7
* Windows 8
* Windows Server
  
If you know of a working version or non-working version, please report it.


## Roadmap

While the goal of this app is to remain simple and lightweight, there are some features that will still be added:

* Settings: more configuration options
* Console-Mode: allow a console-mode which can be used by scripts


## Changelog

See [CHANGELOG.md](https://github.com/dankrusi/WindowsVirtualDesktopHelper/blob/main/CHANGELOG.md)


## Frequently Asked Questions

### Help! This App doesn't work on my version of Windows 11

Microsoft is constantly changing the Windows APIs for managing virtual desktops - thus usually with each new version we have to write a new API wrapper to interface with Windows. This takes time, and sometimes is not easy to integrate with. Don't expect immediate support for un-released versions of Windows (like Insider).

### Where is the icon showing the screen number?

Windows automatically organizes the notification area icons, and places new ones in the icons menu under the ^ chevron. You can drag the screen number into the main icon area from there to have it always showing.

### Why are the prev/next screen icons in the wrong order?

Windows automatically organizes and orders the notification area icons. You can drag prev/next screen icons to organize them accordingly.

### Why is this app is being reported by Windows Defender as untrusted?

Currently Windows Virtual Desktop Helper is not code-signed, and thus may be reported as untrusted. With USD 70 donations per year, the app will be signed.

### Why is this app is being reported by Windows Defender as malware?

Currently Windows Virtual Desktop Helper is not code-signed, and due to its installation option for installing to autostart, may be flagged as malware. Typically, after enough users download, install, and report
the software as okay/safe, this malware warning will go away. With USD 70 donations per year, the app will be signed.

### Why is the app based on the older .NET 4.7?

The idea is to make the app as easy and lightweight to run as possible. Most systems have some version of .NET installed, thus we use a low version to cover as many users as possible. 

## How it works

This program works by using some unofficial/undocumented Windows APIs which Windows uses internally to manage the desktop.
The unofficial nature of these APIs is very unfortunate, because it means that each time Windows 11 makes an update, we have
to reverse engineer the APIs and their undocumented COM CLSIDs - which is tedius and wastes a lot of time.

This is why the maintainers are reluctant to add too many other features, because its enough of a task to keep
up with all the Windows updates for the basic features.

### The Hunt for CLSIDs

TODO

### Your help is wanted!

TODO
