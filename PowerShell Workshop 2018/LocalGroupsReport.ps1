$Groups = Get-LocalGroup

Write-Host "==================="
Write-Host "Local Groups Report"
Write-Host "==================="

foreach($g in $Groups)
{
    $groupMembers = Get-LocalGroupMember -Group $g
    Write-Host "$($groupMembers.Count) members in group $($g.Name)"
    foreach($m in $groupMembers)
    {
        Write-Host "$m.Name"
    }
    Write-Host ""
}