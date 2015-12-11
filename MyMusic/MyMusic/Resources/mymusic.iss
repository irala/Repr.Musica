; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{B3B23FCB-5B22-4338-B6F3-168898895E99}
AppName=MyMusic
AppVersion=1.2
;AppVerName=MyMusic 1.2
AppPublisher=Ninapp.
DefaultDirName={pf}\MyMusic
DefaultGroupName=MyMusic
OutputBaseFilename=mymusic-setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "catalan"; MessagesFile: "compiler:Languages\Catalan.isl"
Name: "portuguese"; MessagesFile: "compiler:Languages\Portuguese.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "C:\Users\Nuria\Documents\Visual Studio 2015\Projects\MyMusic\MyMusic\bin\Release\MyMusic.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Nuria\Documents\Visual Studio 2015\Projects\MyMusic\MyMusic\bin\Release\AxInterop.WMPLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Nuria\Documents\Visual Studio 2015\Projects\MyMusic\MyMusic\bin\Release\Interop.WMPLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Nuria\Documents\Visual Studio 2015\Projects\MyMusic\MyMusic\Resources\alante.png"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Nuria\Documents\Visual Studio 2015\Projects\MyMusic\MyMusic\Resources\atras.png"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Nuria\Documents\Visual Studio 2015\Projects\MyMusic\MyMusic\Resources\fondo.jpg"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Nuria\Documents\Visual Studio 2015\Projects\MyMusic\MyMusic\Resources\fondo1.jpg"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Nuria\Documents\Visual Studio 2015\Projects\MyMusic\MyMusic\Resources\photo_2014-10-22_00-47-15.ico"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Nuria\Documents\Visual Studio 2015\Projects\MyMusic\MyMusic\Resources\play-button.png"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\MyMusic"; Filename: "{app}\MyMusic.exe"
Name: "{commondesktop}\MyMusic"; Filename: "{app}\MyMusic.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\MyMusic"; Filename: "{app}\MyMusic.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\MyMusic.exe"; Description: "{cm:LaunchProgram,MyMusic}"; Flags: nowait postinstall skipifsilent
