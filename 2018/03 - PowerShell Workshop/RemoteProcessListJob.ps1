<#>Hacer un job que traiga los ultimos 5 eventlogs de cada una de las otras pcs<#>

$pcs = @("10.13.130.65",
         "10.13.130.52",
         "10.13.130.202",
         "10.13.130.197",
         "10.13.130.172",
         "10.13.130.110",
         "10.13.130.170")

$con_parametros =
{
    param($server)

    get-eventlog -ComputerName $server -LogName Application -Newest 5
}

foreach($pc in $pcs)
{    
    start-job -ScriptBlock $con_parametros -ArgumentList $pc
}