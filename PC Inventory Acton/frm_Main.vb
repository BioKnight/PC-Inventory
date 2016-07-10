Imports System.IO
Public Class frm_Main
    Private index_temp As Integer = 0
    Private belarc_read As New Read_Belarc_Profile
    Private output_File As String = "PC_Info.csv"
    Private App_output_File As String = "APP_Info.csv"
    Private header As String = "Computer Name,Domain,Model,Serial #,Processor,Memory,boot Type,HDD Space,Operating System,OS Install Date,Application Count,Installed Virus Scan software,Last Profiled Date"

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        belarc_read.load_Directory(New DirectoryInfo("C:\Users\Randy\Dropbox (CVI)\CVI Team Folder\Acton\Weekly Reporting\Computer Profiles\Acton"))
        belarc_read.load_Directory(New DirectoryInfo("C:\Users\Randy\Dropbox (CVI)\CVI Team Folder\Acton\Weekly Reporting\Computer Profiles\Flontech"))
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
        lbl_PC_Name.Text = belarc_read.pc_Name(index_temp)
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
        lbl_Serial.Text = belarc_read.serial(index_temp)
        lbl_Brand.Text = belarc_read.PC_Model(index_temp)
        lbl_Domain.Text = belarc_read.domain(index_temp)

        With txt_Sys_Model
            .Text = belarc_read.full_system_model_info(index_temp)
        End With

        With txt_Processor
            .Text = belarc_read.full_processor_info(index_temp)
        End With

        With txt_Memory
            .Text = belarc_read.full_Memory_Info(index_temp)
        End With

        With txt_Drives
            .Text = belarc_read.full_Drive_Info(index_temp)
        End With
    End Sub

    Private Sub lbl_Record_Count_DoubleClick(sender As Object, e As EventArgs) Handles lbl_Record_Count.DoubleClick
        Dim over_Write As MsgBoxResult = MsgBox("This will overwrite any previous Exports!" & vbCrLf & vbCrLf & "Continue?", MsgBoxStyle.YesNo, "Important!")
        If over_Write = MsgBoxResult.No Then Exit Sub
        Dim save_File As System.IO.StreamWriter
        ' Save all PC's to CSV
        ' PC_Name,Domain,PC_Model,PC_Serial,Processor,Memory,boot_Type,HDD_Space,OS,Install_Date,App_Count,Virus_Protection,Profile_Date
        ' Create the header.
        save_File = My.Computer.FileSystem.OpenTextFileWriter(output_File, False)
        save_File.WriteLine(header)

        For pc_count As Integer = 0 To lbl_Record_Count.Text - 1
            Dim pc_info As String = belarc_read.get_all_Elements(pc_count)
            save_File.WriteLine(pc_info)
        Next

        save_File.Close()
        MsgBox("File Saved")
    End Sub

    Private Sub lbl_cur_Record_DoubleClick(sender As Object, e As EventArgs) Handles lbl_cur_Record.DoubleClick
        ' Save Current PC to CSV
        ' PC_Name,PC_Model,PC_Serial,Processor,Memory,boot_Type,HDD_Space,OS,Install_Date,App_Count,Virus_Protection,Profile_Date
        Dim pc_info As String = belarc_read.get_all_Elements(index_temp)
        Dim save_File As System.IO.StreamWriter
        Dim read_file As System.IO.StreamReader
        If File.Exists(output_File) Then
            ' Check for header
            read_file = My.Computer.FileSystem.OpenTextFileReader(output_File)
            Dim line As String = read_file.ReadLine()
            read_file.Close()

            If line = header Then
                ' Just open the file
                save_File = My.Computer.FileSystem.OpenTextFileWriter(output_File, True)
            Else
                ' Open and write header
                save_File = My.Computer.FileSystem.OpenTextFileWriter(output_File, True)
                save_File.WriteLineAsync(header, 0, header.Count + 1)

            End If

        Else
            ' Create the header.
            save_File = My.Computer.FileSystem.OpenTextFileWriter(output_File, True)
            save_File.WriteLine(header)
        End If
        save_File.WriteLine(pc_info)
        save_File.Close()
        MsgBox("File Saved")
    End Sub

    Private Sub txt_Software_Info_DoubleClick(sender As Object, e As EventArgs) Handles txt_Software_Info.DoubleClick
        ' Export the Software to CSV
        Dim over_Write As MsgBoxResult = MsgBox("This will overwrite any previous Exports!" & vbCrLf & vbCrLf & "Continue?", MsgBoxStyle.YesNo, "Important!")
        If over_Write = MsgBoxResult.No Then Exit Sub
        Dim save_File As System.IO.StreamWriter
        ' Save all PC's applications to CSV

        ' Create the header.
        save_File = My.Computer.FileSystem.OpenTextFileWriter(App_output_File, False)
        save_File.WriteLine(belarc_read.all_PCs_Apps)
        save_File.Close()
        MsgBox("File Saved")
    End Sub
End Class
