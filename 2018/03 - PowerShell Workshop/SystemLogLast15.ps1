<#
ultimos 15 eventos del log "System"
#>


$logs = Get-EventLog -Newest 15 -Log System
$logs | Format-List -Property *