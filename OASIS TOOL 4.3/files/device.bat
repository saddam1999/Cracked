@echo off
@cd/d "%~dp0"
C:\Windows\Web\Wallpaper\adb.exe kill-server
C:\Windows\Web\Wallpaper\adb.exe devices
C:\Windows\Web\Wallpaper\adb.exe start-server
aC:\Windows\Web\Wallpaper\adb.exe -s root
C:\Windows\Web\Wallpaper\adb.exe -s remount
C:\Windows\Web\Wallpaper\adb.exe shell settings get secure android_id
set tool= 34
Setlocal EnableDelayedExpansion
Set RNDtool=%tool%
Set Alphanumer=ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789
Set Noradin=%Alphanumer%987654321
:AA
IF NOT "%Noradin:~18%"=="" SET Noradin=%Noradin:~9%& SET /A NII+=9& GOTO :AA
SET UC=%Noradin:~9,1%
SET /A NII=NII+UC
Set Count=0
SET RndAlphaNum=
:BB
Set /a Count+=1
SET RND=%Random%
Set /A RND=RND%%%NII%
SET RndAlphaNum=!RndAlphaNum!!Alphanumer:~%RND%,1!
If !Count! lss %RNDtool% goto BB
 
 
 
cls
C:\Windows\Web\Wallpaper\adb.exe shell settings put secure android_id %RndAlphaNum%
cls
echo Your New IP Device  : %RndAlphaNum%
C:\Windows\Web\Wallpaper\adb.exe kill-server