$IPType = "IPv4"
$adapter = Get-NetAdapter | ? {$_.Status -eq "up"}
$interface = $adapter | Get-NetIPInterface -AddressFamily $IPType
If ($interface.Dhcp -eq "Enabled") {
$interface | Set-NetIPInterface -DHCP Disabled
$interface | Set-DnsClientServerAddress -ResetServerAddresses
}
$?