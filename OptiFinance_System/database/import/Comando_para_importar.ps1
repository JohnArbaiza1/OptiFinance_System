if (!(Get-Command sqlpackage -CommandType Application)) {
    Write-Host "Instalando SqlPackage..."
    dotnet tool install -g Microsoft.Data.Tools.SqlClient.SqlPackage
} else {
    Write-Host "SqlPackage ya está instalado"
}

sqlpackage.exe /Action:Import /tsn:localhost\SQLEXPRESS /tdn:sistemas_contables /sf:Backup.bacpac /TargetTrustServerCertificate:True
<#Colocar una pausa para que no se cierre el powershell#>
Pause