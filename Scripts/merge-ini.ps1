$replacements = @{}

Write-Host "Adding items" -ForegroundColor Cyan
Get-Content .\items.ini | ForEach-Object {
    if ($_ -match '^(.*?)=(.*)$') {
        $key = $matches[1].Trim()
        $value = $matches[2]
        $replacements[$key] = $value
    }
}
Write-Host "Adding missions" -ForegroundColor Cyan
Get-Content .\missions.ini | ForEach-Object {
    if ($_ -match '^(.*?)=(.*)$') {
        $key = $matches[1].Trim()
        $value = $matches[2]
        $replacements[$key] = $value
    }
}
Write-Host "Adding minings" -ForegroundColor Cyan
Get-Content .\mining.ini | ForEach-Object {
    if ($_ -match '^(.*?)=(.*)$') {
        $key = $matches[1].Trim()
        $value = $matches[2]
        $replacements[$key] = $value
    }
}
Write-Host "Adding the rest" -ForegroundColor Cyan
Get-Content .\other.ini | ForEach-Object {
    if ($_ -match '^(.*?)=(.*)$') {
        $key = $matches[1].Trim()
        $value = $matches[2]
        $replacements[$key] = $value
    }
}
Write-Host "Appling changes to global.ini" -ForegroundColor Magenta
Get-Content ..\Original\Data\Localization\english\global.ini | ForEach-Object {
    if ($_ -match '^(.*?)(=)(.*)$') {
        $key = $matches[1].Trim()
        $prefix = $_.Substring(0, $_.IndexOf('=') + 1)
        if ($replacements.ContainsKey($key)) {
            $prefix + $replacements[$key]
        } else {
            $_
        }
    } else {
        $_
    }
} | Set-Content ..\Mod\Data\Localization\english\global.ini -Encoding UTF8
Write-Host "Done" -ForegroundColor Green
