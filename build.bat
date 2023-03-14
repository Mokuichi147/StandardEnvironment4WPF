@echo off

rem csc.exeのバージョン
set CSC=C:\Windows\Microsoft.NET\Framework64\v4.0.30319\

rem WPF環境で追加しなければならないパス
set WPF=%CSC%WPF\
set WPFlibs=/r:%WPF%PresentationCore.dll /r:%WPF%PresentationFramework.dll /r:%WPF%WindowsBase.dll /r:%CSC%System.Xaml.dll

rem アプリケーション設定
set FILES=src\app.cs
set ICON=resources\default.ico
set RESOURCES=/res:ui\app.xaml
set OUTPUT=se4wpf.exe
set COMPILELOG=compile.log

rem コンパイル
pushd %~dp0
%CSC%csc.exe /nologo /utf8output /target:winexe /win32icon:%ICON% %WPFlibs% %RESOURCES% /out:%OUTPUT% %FILES% > %COMPILELOG%
popd