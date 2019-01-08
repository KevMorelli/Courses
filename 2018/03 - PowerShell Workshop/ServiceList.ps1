<#>Traer un listado de los primeros 5 servicios en Running y cuyo StartType sea Manual
 y mostrando solo Name, Status y StartType:<#>
Get-Service | Where-Object{$_.Status -eq "Running" -and $_.StartType -eq "Manual"} | Select-Object -First 5 | Format-List -Property Name, Status, StartType