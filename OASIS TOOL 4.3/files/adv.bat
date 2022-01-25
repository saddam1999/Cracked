@ECHO OFF
@Echo Off
@ECHO ON
@ECHO OFF
@ECHO ON
@shift
 @echo off
title ALL IN ONE CLEANER BY SHREDDER
:Menu
color 2
cls
title Deep Cleaning Started Please Wait!!
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update" /v AUOptions /t REG_DWORD /d 0 /f

TaskKill /F /IM chrome.exe
TaskKill /F /IM opera.exe
TaskKill /F /IM firefox.exe
TaskKill /F /IM service.exe

echo. Clear Trojan On Local Disk (C)
cd C:\ 
attrib -s -h -r -i autorun.inf
del autorun.inf

echo. Clear Trojan On Local Disk (D)
cd D:\ 
attrib -s -h -r -i autorun.inf
del autorun.inf

echo. Clear Trojan On Local Disk (E)
cd E:\ 
attrib -s -h -r -i autorun.inf
del autorun.inf

echo. Clear Trojan On Local Disk (F)
cd f:\ 
attrib -s -h -r -i autorun.inf
del autorun.inf

net start uxsms

del /f /s /q "%systemdrive%\*.tmp"
del /f /s /q "%systemdrive%\*._mp"
del /f /s /q "%systemdrive%\*.log"
del /f /s /q "%systemdrive%\*.gid"
del /f /s /q "%systemdrive%\*.chk"
del /f /s /q "%systemdrive%\*.old"
del /f /s /q "%systemdrive%\*.SWP"

del /f /s /q "C:\*.tmp
del /f /s /q "C:\*._mp"
del /f /s /q "C:\*.log"
del /f /s /q "C:\*.gid"
del /f /s /q "C:\*.chk"
del /f /s /q "C:\*.old"
del /f /s /q "C:\*.SWP"

del /f /s /q "E:\*.tmp
del /f /s /q "E:\*._mp"
del /f /s /q "E:\*.log"
del /f /s /q "E:\*.gid"
del /f /s /q "E:\*.chk"
del /f /s /q "E:\*.old"
del /f /s /q "E:\*.SWP"

del /f /s /q "D:\*.tmp
del /f /s /q "D:\*._mp"
del /f /s /q "D:\*.log"
del /f /s /q "D:\*.gid"
del /f /s /q "D:\*.chk"
del /f /s /q "D:\*.old"
del /f /s /q "D:\*.SWP"

del /f /s /q "F:\*.tmp
del /f /s /q "F:\*._mp"
del /f /s /q "F:\*.log"
del /f /s /q "F:\*.gid"
del /f /s /q "F:\*.chk"
del /f /s /q "F:\*.old"
del /f /s /q "F:\*.SWP"

del /f /s /q "%windir%\*.bak"
del /f /s /q "%SystemRoot%\MEMORY.DMP"
del /f /s /q "%SystemRoot%\Minidump.dmp"
del /f /s /q "%SystemRoot%\Minidump\*.*"
del /f /s /q "%SystemRoot%\Minidump\"
rd /s /q "%SystemRoot%\Minidump\"
md "%SystemRoot%\Minidump\"

reg delete "HKEY_USERS\S-1-5-21-1684716338-1731825245-2802686541-500\Software\Microsoft\Windows\CurrentVersion\Explorer\RunMRU" /f

del /f /s /q "%userprofile%\AppData\Roaming\Microsoft\Windows\Recent\*.*"
rd /s /q "%userprofile%\AppData\Roaming\Microsoft\Windows\Recent\*.*"
md "%userprofile%\AppData\Roaming\Microsoft\Windows\Recent\"

del /f /s /q "%userprofile%\AppData\Local\Microsoft\Windows\History\*.*"
rd /s /q "%userprofile%\AppData\Local\Microsoft\Windows\History\"
md "%userprofile%\AppData\Local\Microsoft\Windows\History\"

del /f /s /q "%userprofile%\AppData\Roaming\Microsoft\Windows\Cookies\*.*"
rd /s /q "%userprofile%\AppData\Roaming\Microsoft\Windows\Cookies\*.*"
md "%userprofile%\AppData\Roaming\Microsoft\Windows\Cookies\*.*"

del /f /s /q "%windir%\temp\*.*"
del /f /s /q "%windir%\temp\"

del /f /s /q "%windir%\prefetch\*.*"
del /f /s /q "%windir%\prefetch\"
rd /s /q "%windir%\prefetch\"
md "%windir%\prefetch\"

del /f /s /q "%USERPROFILE%\AppData\Local\Temp\*.*"
del /f /s /q "%USERPROFILE%\AppData\Local\Temp\"

del /f /q "%userprofile%\cookies\*.*"
del /f /q "%userprofile%\cookies\"
rd /s /q "%userprofile%\cookies\"

del /f /s /q "%userprofile%\Local Settings\Temporary Internet Files\*.*"

del /f /s /q "%USERPROFILE%\AppData\Local\Microsoft\Windows\Temporary Internet Files\*.*"
del /f /s /q "%USERPROFILE%\AppData\Local\Microsoft\Windows\Temporary Internet Files\"
rd /s /q "%USERPROFILE%\AppData\Local\Microsoft\Windows\Temporary Internet Files\"

del /f /s /q "%USERPROFILE%\AppData\Local\Microsoft\Windows\Caches\"
del /f /s /q "%USERPROFILE%\AppData\Local\Microsoft\Windows\Caches\*.*"

del /f /s /q "%systemdrive%\ProgramData\Microsoft\Windows\Caches\*.*"
rd /s /q "%systemdrive%\ProgramData\Microsoft\Windows\Caches\"

del /f /s /q "%USERPROFILE%\AppData\Local\Microsoft\Windows\WER\*.*"
rd /s /q "%USERPROFILE%\AppData\Local\Microsoft\Windows\WER\"

del /f /s /q "%USERPROFILE%\AppData\Local\Microsoft\Windows\WER\ReportArchive\*.*"
rd /s /q "%USERPROFILE%\AppData\Local\Microsoft\Windows\WER\ReportArchive\"

del /f /s /q "%USERPROFILE%\AppData\Local\Microsoft\Windows\WER\ReportQueue\*.*"
rd /s /q "%USERPROFILE%\AppData\Local\Microsoft\Windows\WER\ReportQueue\"

del /f /s /q "%USERPROFILE%\AppData\Local\Microsoft\Windows\WER\ERC\*.*"
rd /s /q "%USERPROFILE%\AppData\Local\Microsoft\Windows\WER\ERC\"

del /f /s /q "%systemdrive%\ProgramData\Microsoft\Windows\WER\ReportQueue\*.*"
rd /s /q "%systemdrive%\ProgramData\Microsoft\Windows\WER\ReportQueue\"

del /f /s /q "%systemdrive%\ProgramData\Microsoft\Windows\WER\ReportArchive\*.*"
rd /s /q "%systemdrive%\ProgramData\Microsoft\Windows\WER\ReportArchive\"

del /f /s /q "%userprofile%\AppData\Local\Microsoft\Windows\Explorer\*.db"
del /f /s /q "%userprofile%\AppData\Local\Microsoft\Windows\Explorer\*.etl"
del /f /s /q "%userprofile%\AppData\Local\Microsoft\Windows\Explorer\ThumbCacheToDelete\*.tmp"
rd /s /q "%userprofile%\AppData\Local\Microsoft\Windows\Explorer\ThumbCacheToDelete\"

del /f /s /q "\$Recycle.Bin\"
del /f /s /q "\$Recycle.Bin\*"
del /f /s "/q \$Recycle.Bin\*.*"
rd /s /q "\$Recycle.Bin\"
rd /s /q "\$Recycle.Bin\*"
rd /s /q "\$Recycle.Bin\*.*"


%SystemRoot%\System32\Cmd.exe /c Cleanmgr /sageset:16 & Cleanmgr /sagerun:16

c:\windows\SYSTEM32\cleanmgr.exe /dDrive


chkdsk C:

echo. Now Termine Scan Local Disk [C] !Now Scan [D]
chkdsk D:

echo. Now Termine Scan Local Disk [D] !Now Scan [E]
chkdsk E:

echo. Now Termine Scan Local Disk [E] !Now Scan [F]
chkdsk F:

echo. Now Termine Scan Local Disk [C/D/E/F]

RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 255
RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 1
RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 2
RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8
RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 16
RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 16

echo Processed Successfully!
echo.
echo.
echo %rw10%
echo                                                   Processed Successfully!