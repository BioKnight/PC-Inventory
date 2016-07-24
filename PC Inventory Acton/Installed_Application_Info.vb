Public Class Installed_Applications_Info


    Sub New()
        apps_thread = New Thread_handling(AddressOf LoadSoftwareList, "Thread Apps")
        apps_thread.start_Thread()
    End Sub

    Private apps As List(Of Management.ManagementObject)
    Private apps_thread As Thread_handling

    ' Property              Description
    ' Caption               Short description of the object.
    ' Description           Object description.
    ' IdentifyingNumber     Product identification, such As a serial number On software.
    ' InstallLocation       Location of the installed product.
    ' InstallState          Installed state Of the product. Values include:
    '                       -6 -Bad configuration
    '                       -2 - Invalid argument
    '                       -1 - Unknown package
    '                        1 - Advertised
    '                        2 - Absent
    '                        6 - Installed
    ' Name                  Commonly used product name.
    ' PackageCache          Location of the locally cached package for this product.
    ' SKUNumber             Product SKU(stock - keeping unit) information.
    ' Vendor                Name of the product's supplier.
    ' Version               Product version information.


    ' *** This needs to be run in a seperate thread to prevet Lag.
    Private Sub LoadSoftwareList()
        Dim moReturn As Management.ManagementObjectCollection
        Dim moSearch As Management.ManagementObjectSearcher
        Dim mo As Management.ManagementObject
        Dim applst As New List(Of String)

        moSearch = New Management.ManagementObjectSearcher("Select * from Win32_Product")

        moReturn = moSearch.Get
        For Each mo In moReturn
            On Error Resume Next ' Some stupid error making one of the items around 199 show as Null, Poor Fix
            apps.Add(mo)
        Next
    End Sub


End Class
