Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "ITDB"
)
Install the SQL Server Module
Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Building procedures for $Database on $Server..."


Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\Procedures\IT.AddCheckout.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\Procedures\IT.AddCustomer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\Procedures\IT.AddEmployee.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\Procedures\IT.AddItem.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\Procedures\IT.AddReturn.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\Procedures\IT.GetAvailableItems.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\Procedures\IT.GetCCheckOutOn.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetCReturnedOn.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetCustomerByFirst.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetCustomerByID.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetCustomerByLast.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetCustomerByName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetCustomerCheckOuts.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetCustomerReturns.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetECheckedOutOn.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetEmployeeByFirst.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetEmployeeByID.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetEmployeeByLast.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetEmployeeByName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetEmployeeCheckOuts.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetEmployeeReturns.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetEReturnedOn.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetItemByID.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetItemBySerialNumber.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetItemCheckOuts.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetItemReturns.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetItemsByCheckedOut.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetItemsByItemName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetItesmByItemType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetItemsCheckedOutByCID.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetMonthlyReport.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetPopOfItems.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ITCheckoutUI\procedures\IT.GetRemovedItems.sql"