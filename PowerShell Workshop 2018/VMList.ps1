<#>
Traer todas las VMs que esten encendidas, tengan más de 2gb de ram y las vm tools esten en regla:
get-vm | Where-Object{$_.PowerState -eq "PoweredOn" -and  $_.MemoryGB -gt 2.000 -and $_.ExtensionData.Guest.ToolsStatus -eq "toolsOK"}
<#>

$Vms = @()

foreach($d in get-vm)
{
	if($d.PowerState -eq "PoweredOn" -and
		$d.MemoryGb -gt 2.000 -and
		$d.ExtensionData.Guest.ToolsStatus -eq "toolsOK")
	{
        $Vms += $d
	}
}

$vms