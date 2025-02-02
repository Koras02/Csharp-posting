dotnet run

if ($LastExitCode -eq 0) {
	Write-Host "Execution succeeded"
} else 
{
	Write-Host "Execution Faild"
}
Write-Host "Return value = " $LastExitCode