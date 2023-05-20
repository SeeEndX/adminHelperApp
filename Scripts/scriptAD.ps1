param (
        [string]$Organization,
        [string]$City,
        [string]$OUs
)


$CityRu = (Get-Culture).TextInfo.ToTitleCase($City)
$DomainDN = (Get-ADDomain).DistinguishedName
$Name = $Organization+"_"+$City


$newOU = New-ADOrganizationalUnit -Name $Name –Description "Container For Users of $CityRu" -PassThru
foreach ($OU in $OUs -split ' ') {
	New-ADOrganizationalUnit -Name $OU -Path $newOU
}
$?