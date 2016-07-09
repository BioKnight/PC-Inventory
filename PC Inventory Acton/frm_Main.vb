Imports System.IO
Public Class frm_Main
    Private index_temp As Integer = 0
    Private belarc_read As New Read_Belarc_Profile
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        belarc_read.load_Directory(New DirectoryInfo("C:\Users\Randy\Desktop\Computer Profiles"))
        lbl_Record_Count.Text = belarc_read.open_Files
        fill_form()
    End Sub

    Private Sub btn_Last_Click(sender As Object, e As EventArgs) Handles btn_Last.Click
        index_temp = belarc_read.open_Files - 1
        fill_form()
    End Sub

    Private Sub btn_First_Click(sender As Object, e As EventArgs) Handles btn_First.Click
        index_temp = 0
        fill_form()
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        If index_temp >= belarc_read.open_Files - 1 Then Exit Sub
        index_temp += 1
        fill_form()
    End Sub

    Private Sub btn_Previous_Click(sender As Object, e As EventArgs) Handles btn_Previous.Click
        If index_temp <= 0 Then Exit Sub
        index_temp -= 1
        fill_form()
    End Sub

    Sub fill_form()
        lbl_cur_Record.Text = index_temp + 1
        lbl_PC_Name.Text = belarc_read.Name(index_temp)
        lbl_Updated.Text = belarc_read.Profile_Date(index_temp)
        lbl_File_Location.Text = belarc_read.file(index_temp).FullName
        lbl_User.Text = belarc_read.Current_Login(index_temp)
        lbl_OS.Text = belarc_read.os(index_temp)
        lbl_Install_Date.Text = belarc_read.os_Install_Date(index_temp)
        lbl_Boot_Mode.Text = belarc_read.boot_mode(index_temp)
        lbl_Processor.Text = belarc_read.proc(index_temp)
        lbl_Memory.Text = belarc_read.mem(index_temp)
        lbl_Storage.Text = belarc_read.hdds(index_temp)
        lbl_Virus_Protection.Text = belarc_read.virus_Protection(index_temp)
        lbl_Software_Count.Text = belarc_read.app_Count(index_temp)
        lst_Software.Items.Clear()
        lst_Software.Items.AddRange(belarc_read.Applications(index_temp).ToArray)
    End Sub


End Class
