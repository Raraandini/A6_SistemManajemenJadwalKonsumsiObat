$logPath = "C:\Users\acer\.gemini\antigravity-ide\brain\a0f1a09b-64f5-4a5d-adda-ccdaa60b0f14\.system_generated\logs\transcript.jsonl"
$files = @(
    @{ Name="FormObat.cs"; Pattern="Total Lines: 452" },
    @{ Name="FormUser.cs"; Pattern="Total Lines: 125" }
)

$lines = Get-Content $logPath -Encoding UTF8 | Where-Object { $_ -match '"type":"VIEW_FILE"' }
[array]::Reverse($lines)

foreach ($f in $files) {
    foreach ($line in $lines) {
        $step = $line | ConvertFrom-Json
        if ($step.content -match ("File Path: .*?" + $f.Name.Replace('.', '\.')) -and $step.content -match $f.Pattern) {
            $code = $step.content -split "leading space.\n" | Select-Object -Last 1
            $code = $code -split "\nThe above content shows" | Select-Object -First 1
            $code = $code -replace "(?m)^\d+:\s(.*)$", "`$1"
            
            Set-Content -Path "d:\Semester 4\PABD\ProjekUCP1\ProjekUCP1\SistemManajemenObat\SistemManajemenObat\$($f.Name)" -Value $code -Encoding UTF8
            Write-Host "Restored $($f.Name)"
            break
        }
    }
}
Write-Host "DONE"
