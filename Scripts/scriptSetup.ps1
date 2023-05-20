#Install-WindowsFeature -Name DNS, DHCP, AD-Domain-Services -IncludeManagementTools

Set-NetFirewallProfile -All -Enabled False

Uninstall-WindowsFeature -Name Windows-Defender

#Add-Computer -DomainName enplus.edu

Set-TimeZone -Name "North Asia East Standard Time"
$?