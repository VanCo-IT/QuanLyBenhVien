@echo off
echo ======================================
echo 🧹 Cleaning obj/, bin/, and .vs folders...
echo ======================================

REM Delete folders (safe for local dev use)
for /d /r %%i in (bin,obj,.vs) do (
    if exist "%%i" (
        echo Deleting %%i
        rd /s /q "%%i"
    )
)

REM Remove from Git index if tracked
echo.
echo ======================================
echo 🧹 Removing from Git index...
echo ======================================

git rm --cached -r BLL_QLBV/obj
git rm --cached -r DAL_QLBV/obj
git rm --cached -r DTO_QLBV/obj
git rm --cached -r QL_BenhVien/obj
git rm --cached -r UTIL/obj

git rm --cached -r .vs
git rm --cached -r bin

REM Commit the cleanup
git commit -m "Cleanup: remove obj/, bin/, .vs/ from Git tracking"

echo.
echo ✅ Done. You can now push your changes.
pau
