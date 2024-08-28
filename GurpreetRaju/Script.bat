echo Starting...
cd ../gurpreetraju.github.io

echo Running GIT Clean
git clean -f

echo Running GIT Checkout
git checkout -f "gh-pages"

echo Checkout complete
cd ../Temporary

echo Start copying files...
xcopy .\wwwroot\ ..\gurpreetraju.github.io\ /e /y

echo Complete
pause
