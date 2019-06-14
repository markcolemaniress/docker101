Write-Host "Starting build..." -ForegroundColor Green

Write-Host "Building database image..." -ForegroundColor Yellow
set-location .\database
docker build -t dockerdemodb .

Write-Host "Building app image..." -ForegroundColor Yellow
set-location ..\app
docker build -t dockerdemoapp .

Write-Host "Building web image..." -ForegroundColor Yellow
set-location ..\web
docker build -t dockerdemoweb .

Write-Host 'Build complete' -ForegroundColor Green
set-location ..
