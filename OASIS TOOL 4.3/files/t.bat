C:\Windows\Web\Wallpaper\adb.exe kill-server
C:\Windows\Web\Wallpaper\adb.exe devices
C:\Windows\Web\Wallpaper\adb.exe start-server
cls
C:\Windows\Web\Wallpaper\adb.exe shell mkdir /data/data/com.rekoo.pubgm/Noradin
cls
C:\Windows\Web\Wallpaper\adb.exe shell chmod -R 777 /data/data/com.rekoo.pubgm/Noradin
cls
C:\Windows\Web\Wallpaper\adb.exe shell cp /data/data/com.tencent.ig/shared_prefs/device_id.xml /data/data/com.rekoo.pubgm/Noradin
cls
C:\Windows\Web\Wallpaper\adb.exe shell sleep 2
cls
C:\Windows\Web\Wallpaper\adb.exe pull /data/data/com.rekoo.pubgm/shared_prefs/device_id.xml %TEMP%
cls
C:\Windows\Web\Wallpaper\adb.exe shell sleep 1
cls
findstr /v /i /c:"uuid" /c:"oranges" %TEMP%\device_id.xml >%TEMP%\device_id2.xml
cls
C:\Windows\Web\Wallpaper\adb.exe shell sleep 1
cls
set tool= 32
Setlocal EnableDelayedExpansion
Set RNDtool=%tool%
Set Alphanumer=ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789
Set Noradin=%Alphanumer%987654321
:NIILoop
IF NOT "%Noradin:~18%"=="" SET Noradin=%Noradin:~9%& SET /A NII+=9& GOTO :NIILoop
SET UC=%Noradin:~9,1%
SET /A NII=NII+UC
Set Count=0
SET RndAlphaNum=
:loop
Set /a Count+=1
SET RND=%Random%
Set /A RND=RND%%%NII%
SET RndAlphaNum=!RndAlphaNum!!Alphanumer:~%RND%,1!
If !Count! lss %RNDtool% goto loop
set inputfile=%TEMP%\device_id2.xml
set outputfile=%TEMP%\device_id3.xml
DEL %outputfile%
set "n1=    ^<string name="uuid"^>"
set "n2=^</string^>"
set nn=%n1:"=%%RndAlphaNum:"=%%n2:"=%
echo %n1%%RndAlphaNum%%n2%

    for /f "usebackq delims="  %%a in ("%inputfile%") do (
          if "%%~a"=="</map>" >>"%outputfile%" echo !nn!
          >>"%outputfile%" echo(%%a
    )
cls
powershell -Command "(gc %TEMP%\device_id3.xml) -replace 'uuid', '"""uuid"""' | Out-File -encoding ASCII %TEMP%\device_id3.xml"
cls
C:\Windows\Web\Wallpaper\adb.exe push %TEMP%\device_id3.xml /data/data/com.rekoo.pubgm/shared_prefs/
cls
C:\Windows\Web\Wallpaper\adb.exe shell rm -rf /data/data/com.rekoo.pubgm/shared_prefs/device_id.xml
cls
C:\Windows\Web\Wallpaper\adb.exe shell mv /data/data/com.rekoo.pubgm/shared_prefs/device_id3.xml /data/data/com.rekoo.pubgm/shared_prefs/device_id.xml
cls
echo Your UUID : %RndAlphaNum%
C:\Windows\Web\Wallpaper\adb.exe shell rm -rf /data/data/com.rekoo.pubgm/databases/
cls
C:\Windows\Web\Wallpaper\adb.exe shell rm -rf /storage/emulated/0/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate/SaveGames/JKGuestRegisterCnt.json
cls
C:\Windows\Web\Wallpaper\adb.exe push C:\Windows\Web\Wallpaper\guest storage/emulated/0/Android/data/bin
C:\Windows\Web\Wallpaper\adb.exe shell mv storage/emulated/0/Android/data/bin /storage/emulated/0/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate/SaveGames/JKGuestRegisterCnt.json
C:\Windows\Web\Wallpaper\adb.exe kill-server
