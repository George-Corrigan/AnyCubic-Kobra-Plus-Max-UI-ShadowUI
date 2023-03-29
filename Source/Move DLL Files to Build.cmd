@echo off

set Version=1.0.0

rem This should only update major/minor versions (x.x.0). Revisions should only be changes for languages (per language).
rem =======================================================================================================================

copy /y ".\DGUS\DWIN_SET\*.bin" ".\..\Builds\Chinese v%Version%\DWIN_SET\"
copy /y ".\DGUS\DWIN_SET\*.bin" ".\..\Builds\Dutch v%Version%\DWIN_SET\"
copy /y ".\DGUS\DWIN_SET\*.bin" ".\..\Builds\English v%Version%\DWIN_SET\"
copy /y ".\DGUS\DWIN_SET\*.bin" ".\..\Builds\French v%Version%\DWIN_SET\"
copy /y ".\DGUS\DWIN_SET\*.bin" ".\..\Builds\German v%Version%\DWIN_SET\"
copy /y ".\DGUS\DWIN_SET\*.bin" ".\..\Builds\Italian v%Version%\DWIN_SET\"
copy /y ".\DGUS\DWIN_SET\*.bin" ".\..\Builds\Spanish v%Version%\DWIN_SET\"
copy /y ".\DGUS\DWIN_SET\*.bin" ".\..\Builds\Thai v%Version%\DWIN_SET\"

pause
