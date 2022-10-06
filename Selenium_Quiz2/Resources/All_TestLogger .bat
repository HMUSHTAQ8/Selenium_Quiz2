@ECHO OFF

set testcategory=Register
set dllpath=D:\Selenium_Projects\Selenium_Quiz2\Selenium_Quiz2\bin\Debug\Selenium_Quiz2.dll
set trxerpath= D:\Selenium_Projects\Selenium_Quiz2\Selenium_Quiz2\Resources\
set testsummaryreportPath=D:\Selenium_Projects\Selenium_Quiz2\Selenium_Quiz2\Reports\

FOR /f %%a IN ('WMIC OS GET LocalDateTime ^| FIND "."') DO SET DTS=%%a
SET filename=%testcategory%_%DTS:~0,4%%DTS:~4,2%%DTS:~6,2%%DTS:~8,2%%DTS:~10,2%%DTS:~12,2%
echo %filename%

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"
cd %testsummaryreportPath%
md %filename%

VSTest.Console.exe  %dllpath% /TestCaseFilter:"TestCategory=%testcategory%" /Logger:"trx;LogFileName=%testsummaryreportPath%\%filename%\%filename%.trx"

cd %trxerpath%
TrxToHTML.exe %testsummaryreportPath%%filename%\

PAUSE
