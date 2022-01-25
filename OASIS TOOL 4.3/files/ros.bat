adb kill-server
adb devices
adb start-server
cls
adb shell mkdir /data/data/com.tencent.ig/Noradin
adb shell mkdir /data/data/com.kr.pubgmobile/Noradin
adb shell mkdir /data/data/com.rekoo.pubgm/Noradin
adb shell mkdir /data/data/com.vng.pubgmobile/Noradin
cls
adb shell chmod -R 777 /data/data/com.tencent.ig/Noradin
adb shell chmod -R 777 /data/data/com.kr.pubgmobile/Noradin
adb shell chmod -R 777 /data/data/com.rekoo.pubgm/Noradin
adb shell chmod -R 777 /data/data/com.vng.pubgmobile/Noradin
cls
adb shell cp /data/data/com.tencent.ig/shared_prefs/device_id.xml /data/data/com.tencent.ig/Noradin
adb shell cp /data/data/com.tencent.ig/shared_prefs/device_id.xml /data/data/com.kr.pubgmobile/Noradin
adb shell cp /data/data/com.tencent.ig/shared_prefs/device_id.xml /data/data/com.rekoo.pubgm/Noradin
adb shell cp /data/data/com.tencent.ig/shared_prefs/device_id.xml /data/data/com.vng.pubgmobile/Noradin
cls
adb shell sleep 2
cls
adb pull /data/data/com.tencent.ig/shared_prefs/device_id.xml %TEMP%
adb pull /data/data/com.kr.pubgmobile/shared_prefs/device_id.xml %TEMP%
adb pull /data/data/com.rekoo.pubgm/shared_prefs/device_id.xml %TEMP%
adb pull /data/data/com.vng.pubgmobile/shared_prefs/device_id.xml %TEMP%
cls
adb shell sleep 1
cls
findstr /v /i /c:"uuid" /c:"oranges" %TEMP%\device_id.xml >%TEMP%\device_id2.xml
cls
adb shell sleep 1
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
adb push %TEMP%\device_id3.xml /data/data/com.tencent.ig/shared_prefs/
adb push %TEMP%\device_id3.xml /data/data/com.vng.pubgmobile/shared_prefs/
adb push %TEMP%\device_id3.xml /data/data/com.rekoo.pubgm/shared_prefs/
adb push %TEMP%\device_id3.xml /data/data/com.kr.pubgmobile/shared_prefs/
cls
adb shell rm -rf /data/data/com.tencent.ig/shared_prefs/device_id.xml
adb shell rm -rf /data/data/com.vng.pubgmobile/shared_prefs/device_id.xml
adb shell rm -rf /data/data/com.rekoo.pubgm/shared_prefs/device_id.xml
adb shell rm -rf /data/data/com.kr.pubgmobile/shared_prefs/device_id.xml
cls
adb shell mv /data/data/com.tencent.ig/shared_prefs/device_id3.xml /data/data/com.tencent.ig/shared_prefs/device_id.xml
adb shell mv /data/data/com.vng.pubgmobile/shared_prefs/device_id3.xml /data/data/com.vng.pubgmobile/shared_prefs/device_id.xml
adb shell mv /data/data/com.rekoo.pubgm/shared_prefs/device_id3.xml /data/data/com.rekoo.pubgm/shared_prefs/device_id.xml
adb shell mv /data/data/com.kr.pubgmobile/shared_prefs/device_id3.xml /data/data/com.kr.pubgmobile/shared_prefs/device_id.xml
cls
echo Your UUID : %RndAlphaNum%

