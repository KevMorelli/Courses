<#>Una tabla de procesos y si consumen mucha cpu (cpu > 10):<#>
Get-Process | select name, @{N="Consume mucha cpu?"; E={if($_.cpu -gt 10){"Si"}else{"No"}}}