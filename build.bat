@echo off

set CSC=C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
set WPF=%CSC%WPF\

set WPFlibs=/r:%WPF%PresentationCore.dll /r:%WPF%PresentationFramework.dll /r:%WPF%WindowsBase.dll /r:%CSC%System.Xaml.dll

%CSC%csc.exe /nologo /utf8output /target:winexe %WPFlibs% /res:resources/main.xaml /out:se4wpf.exe main.cs > result.log