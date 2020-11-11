@echo off
REM
REM .netshrink backup restoration script
REM
REM http://www.pelock.com
REM
set backup="TAKSHAK13.exe.bak"
set original="TAKSHAK13.exe"
if not exist %backup% goto :FAIL
attrib -R +A -S -H %original%
attrib -R +A -S -H %backup%
move /? | find "/Y" > nul
if errorlevel 1 goto :OLD
set switch=/Y
goto :NEW
:OLD
del %original%
if exist %original% goto :FAIL
:NEW
move %switch% %backup% %original% > nul
if not exist %backup% goto :DONE
:FAIL
exit
:DONE
del %0 > nul | exit
