Imports System.Threading

Public Class Thread_handling
#Region "Public"


    Sub New(call_back As ThreadStart, Optional name As String = "Emanon")
        Thread_Name = name
        thread_Setup(call_back)
    End Sub

    Public Sub start_Thread()
        thread_Main.Start()
    End Sub

    Public Sub stop_Thread()
        thread_Main.Abort()
    End Sub

#End Region
#Region "Private"

    Private Delegate Sub thread_Event(sender As System.Object, e As System.EventArgs)
    Private Thread_Name As String
    Private thread_Main As Thread


    Private Sub thread_Setup(funct As ThreadStart)
        thread_Main = New Thread(funct)
        thread_Main.Name = Thread_Name
    End Sub

    Private Delegate Sub Update_App_List_Delegate(lstbox As ListBox, ByVal app As String)
    Private Sub Update_app_lstBox(lstbox As ListBox, ByVal app As String)
        If lstbox.InvokeRequired Then
            Dim d As New Update_App_List_Delegate(AddressOf Update_app_lstBox)
            lstbox.Invoke(d, New Object() {lstbox, app})
        Else
            lstbox.Items.Add(app)
        End If
    End Sub

    Private Delegate Sub clearapplstCallback(lstbox As ListBox)
    Private Sub clear_app_lstBox(lstbox As ListBox)
        If lstbox.InvokeRequired Then
            Dim d As New clearapplstCallback(AddressOf clear_app_lstBox)
            lstbox.Invoke(d, New Object() {lstbox})
        Else
            lstbox.Items.Clear()
        End If
    End Sub


#End Region

End Class
