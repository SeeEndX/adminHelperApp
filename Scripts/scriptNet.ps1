param(
	[string]$IP,
	[string]$GW,
	[string]$Mask
)

$interface = Get-NetAdapter -Name Ethernet
$existingGateway = ($interface | Get-NetIPConfiguration).Ipv4DefaultGateway
if ($existingGateway) {
    $interface | Remove-NetRoute -DestinationPrefix "0.0.0.0/0" -Confirm:$false
}

$existingIPAddress = ($interface | Get-NetIPAddress).IPAddress
if ($existingIPAddress) {
    Remove-NetIPAddress -InterfaceIndex $interface.InterfaceIndex -IPAddress $existingIPAddress -Confirm:$false
}

New-NetIPAddress -InterfaceIndex $interface.InterfaceIndex -IPAddress $IP -PrefixLength $Mask
New-NetRoute -InterfaceIndex $interface.InterfaceIndex -DestinationPrefix "0.0.0.0/0" -NextHop $GW
$?

