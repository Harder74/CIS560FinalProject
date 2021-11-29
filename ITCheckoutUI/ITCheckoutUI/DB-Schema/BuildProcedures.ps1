Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "ITDB"
)

#Install the SQL Server Module
#Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Building procedures for $Database on $Server..."


Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.AddCheckout.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.AddCustomer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.AddEmployee.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.AddItem.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.AddReturn.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetAvailableItems.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetCCheckedOutOn.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetCReturnedOn.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetCustomerByFirst.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetCustomerByID.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetCustomerByLast.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetCustomerByName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetCustomerCheckOuts.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetCustomerReturns.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetECheckedOutOn.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetEmployeeByFirst.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetEmployeeByID.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetEmployeeByLast.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetEmployeeByName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetEmployeeCheckOuts.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetEmployeeReturns.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetEReturnedOn.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetItemByID.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetItemBySerialNumber.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetItemCheckOuts.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetItemReturns.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetItemsByCheckedOut.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetItemsByItemName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetItemsByItemType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetItemsCheckedOutByCID.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetMonthlyReport.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetPopOfItems.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\Procedures\IT.GetRemovedItems.sql"