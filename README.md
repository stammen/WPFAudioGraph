# WPFAudioGraph
Sample on how to use Windows 10 AudioGraph from a Win32 WPF App

## Requirements
* Visual Studio 2017 with Windows Universal App Development package installed
* Windows SDK 16299 (installed with Visual Studio 2017)

## How to Build

* Open the WPFAudioGraph.sln with Visual Studio 2017

* Build and run the WPFAudioGraph app

* Press the Start Button. Note: that audio from the mic will play on your speakers so best to set low audio level or use headphones to avoid feedback.

## How to Build

In order to enable access to Windows 10 APIs from the WPF App, we needed to add references to the following files:


* Add a reference to windows.winmd using the following path (Make sure to change the filter to “All Files” when you browse for this file):

```c++
    C:\Program Files (x86)\Windows Kits\10\UnionMetadata\10.0.16299.0\Windows.winmd
```

* Add a reference to System.Runtime.WindowsRuntime.dll using the following path:

```c++
    C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETCore\v4.5\System.Runtime.WindowsRuntime.dll 
```

This sample was based on this [blog article](https://blogs.windows.com/buildingapps/2017/01/25/calling-windows-10-apis-desktop-application/#lT33KxHF9ZQQCqsi.97]) and was updated to 
work with Windows SDK 16299. Only the references to Windows.winmd and System.Runtime.WindowsRuntime.dll were required to be added to the project.


