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

This sample is based on this [blog article](https://blogs.windows.com/buildingapps/2017/01/25/calling-windows-10-apis-desktop-application/#lT33KxHF9ZQQCqsi.97]). 
The following changes were made to allow the project to build with Windows SDK 16299.

* Change the reference to windows.winmd path to:

```c++
    C:\Program Files (x86)\Windows Kits\10\UnionMetadata\10.0.16299.0\Windows.winmd
```


