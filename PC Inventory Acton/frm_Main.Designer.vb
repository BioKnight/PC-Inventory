<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpg_Overview = New System.Windows.Forms.TabPage()
        Me.lbl_File_Location = New System.Windows.Forms.Label()
        Me.lbl_Desc_File_Loaction = New System.Windows.Forms.Label()
        Me.lbl_Software_Count = New System.Windows.Forms.Label()
        Me.lbl_Desc_Software_Count = New System.Windows.Forms.Label()
        Me.lbl_Virus_Protection = New System.Windows.Forms.Label()
        Me.lbl_Desc_Virus_Protection = New System.Windows.Forms.Label()
        Me.lbl_Storage = New System.Windows.Forms.Label()
        Me.lbl_Desc_Storage = New System.Windows.Forms.Label()
        Me.lbl_Memory = New System.Windows.Forms.Label()
        Me.lbl_Desc_Memory = New System.Windows.Forms.Label()
        Me.lbl_Processor = New System.Windows.Forms.Label()
        Me.lbl_Desc_Processor = New System.Windows.Forms.Label()
        Me.lbl_Boot_Mode = New System.Windows.Forms.Label()
        Me.lbl_Desc_Boot_Mode = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Desc_Brand = New System.Windows.Forms.Label()
        Me.lbl_Install_Date = New System.Windows.Forms.Label()
        Me.lbl_Desc_Install_Date = New System.Windows.Forms.Label()
        Me.lbl_OS = New System.Windows.Forms.Label()
        Me.lbl_Desc_OS = New System.Windows.Forms.Label()
        Me.lbl_Domain = New System.Windows.Forms.Label()
        Me.lbl_Desc_Domain = New System.Windows.Forms.Label()
        Me.lbl_User = New System.Windows.Forms.Label()
        Me.lbl_Desc_User = New System.Windows.Forms.Label()
        Me.lbl_Updated = New System.Windows.Forms.Label()
        Me.lbl_Desc_Updated = New System.Windows.Forms.Label()
        Me.lbl_PC_Name = New System.Windows.Forms.Label()
        Me.lbl_Desc_PC_Name = New System.Windows.Forms.Label()
        Me.tbpg_Hardware = New System.Windows.Forms.TabPage()
        Me.grp_Memory = New System.Windows.Forms.GroupBox()
        Me.txt_Memory = New System.Windows.Forms.TextBox()
        Me.grp_Drives = New System.Windows.Forms.GroupBox()
        Me.txt_Drives = New System.Windows.Forms.TextBox()
        Me.grp_Processor = New System.Windows.Forms.GroupBox()
        Me.txt_Processor = New System.Windows.Forms.TextBox()
        Me.grp_Sys_Model = New System.Windows.Forms.GroupBox()
        Me.txt_Sys_Model = New System.Windows.Forms.TextBox()
        Me.tbpg_Software = New System.Windows.Forms.TabPage()
        Me.lst_Software = New System.Windows.Forms.ListBox()
        Me.txt_Software_Info = New System.Windows.Forms.TextBox()
        Me.tbpg_Users = New System.Windows.Forms.TabPage()
        Me.txt_Key = New System.Windows.Forms.TextBox()
        Me.grp_Domain = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lst_Domain_Users = New System.Windows.Forms.ListBox()
        Me.grp_Local = New System.Windows.Forms.GroupBox()
        Me.txt_Local_User_Info = New System.Windows.Forms.TextBox()
        Me.lst_Local_Users = New System.Windows.Forms.ListBox()
        Me.btn_First = New System.Windows.Forms.Button()
        Me.btn_Previous = New System.Windows.Forms.Button()
        Me.btn_Last = New System.Windows.Forms.Button()
        Me.btn_Next = New System.Windows.Forms.Button()
        Me.lbl_cur_Record = New System.Windows.Forms.Label()
        Me.lbl_Of = New System.Windows.Forms.Label()
        Me.lbl_Record_Count = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tbpg_Overview.SuspendLayout()
        Me.tbpg_Hardware.SuspendLayout()
        Me.grp_Memory.SuspendLayout()
        Me.grp_Drives.SuspendLayout()
        Me.grp_Processor.SuspendLayout()
        Me.grp_Sys_Model.SuspendLayout()
        Me.tbpg_Software.SuspendLayout()
        Me.tbpg_Users.SuspendLayout()
        Me.grp_Domain.SuspendLayout()
        Me.grp_Local.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpg_Overview)
        Me.TabControl1.Controls.Add(Me.tbpg_Hardware)
        Me.TabControl1.Controls.Add(Me.tbpg_Software)
        Me.TabControl1.Controls.Add(Me.tbpg_Users)
        Me.TabControl1.Location = New System.Drawing.Point(13, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(765, 510)
        Me.TabControl1.TabIndex = 0
        '
        'tbpg_Overview
        '
        Me.tbpg_Overview.Controls.Add(Me.lbl_File_Location)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_File_Loaction)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Software_Count)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_Software_Count)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Virus_Protection)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_Virus_Protection)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Storage)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_Storage)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Memory)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_Memory)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Processor)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_Processor)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Boot_Mode)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_Boot_Mode)
        Me.tbpg_Overview.Controls.Add(Me.Label2)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_Brand)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Install_Date)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_Install_Date)
        Me.tbpg_Overview.Controls.Add(Me.lbl_OS)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_OS)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Domain)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_Domain)
        Me.tbpg_Overview.Controls.Add(Me.lbl_User)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_User)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Updated)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_Updated)
        Me.tbpg_Overview.Controls.Add(Me.lbl_PC_Name)
        Me.tbpg_Overview.Controls.Add(Me.lbl_Desc_PC_Name)
        Me.tbpg_Overview.Location = New System.Drawing.Point(4, 25)
        Me.tbpg_Overview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpg_Overview.Name = "tbpg_Overview"
        Me.tbpg_Overview.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpg_Overview.Size = New System.Drawing.Size(757, 481)
        Me.tbpg_Overview.TabIndex = 0
        Me.tbpg_Overview.Text = "PC Overview"
        Me.tbpg_Overview.UseVisualStyleBackColor = True
        '
        'lbl_File_Location
        '
        Me.lbl_File_Location.AutoSize = True
        Me.lbl_File_Location.Location = New System.Drawing.Point(132, 442)
        Me.lbl_File_Location.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_File_Location.Name = "lbl_File_Location"
        Me.lbl_File_Location.Size = New System.Drawing.Size(16, 17)
        Me.lbl_File_Location.TabIndex = 33
        Me.lbl_File_Location.Text = "0"
        '
        'lbl_Desc_File_Loaction
        '
        Me.lbl_Desc_File_Loaction.AutoSize = True
        Me.lbl_Desc_File_Loaction.Location = New System.Drawing.Point(8, 442)
        Me.lbl_Desc_File_Loaction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_File_Loaction.Name = "lbl_Desc_File_Loaction"
        Me.lbl_Desc_File_Loaction.Size = New System.Drawing.Size(96, 17)
        Me.lbl_Desc_File_Loaction.TabIndex = 32
        Me.lbl_Desc_File_Loaction.Text = "File Location: "
        '
        'lbl_Software_Count
        '
        Me.lbl_Software_Count.AutoSize = True
        Me.lbl_Software_Count.Location = New System.Drawing.Point(132, 272)
        Me.lbl_Software_Count.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Software_Count.Name = "lbl_Software_Count"
        Me.lbl_Software_Count.Size = New System.Drawing.Size(16, 17)
        Me.lbl_Software_Count.TabIndex = 31
        Me.lbl_Software_Count.Text = "0"
        '
        'lbl_Desc_Software_Count
        '
        Me.lbl_Desc_Software_Count.AutoSize = True
        Me.lbl_Desc_Software_Count.Location = New System.Drawing.Point(8, 272)
        Me.lbl_Desc_Software_Count.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_Software_Count.Name = "lbl_Desc_Software_Count"
        Me.lbl_Desc_Software_Count.Size = New System.Drawing.Size(100, 17)
        Me.lbl_Desc_Software_Count.TabIndex = 30
        Me.lbl_Desc_Software_Count.Text = "Installed Apps:"
        '
        'lbl_Virus_Protection
        '
        Me.lbl_Virus_Protection.AutoSize = True
        Me.lbl_Virus_Protection.Location = New System.Drawing.Point(132, 241)
        Me.lbl_Virus_Protection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Virus_Protection.Name = "lbl_Virus_Protection"
        Me.lbl_Virus_Protection.Size = New System.Drawing.Size(16, 17)
        Me.lbl_Virus_Protection.TabIndex = 29
        Me.lbl_Virus_Protection.Text = "0"
        '
        'lbl_Desc_Virus_Protection
        '
        Me.lbl_Desc_Virus_Protection.AutoSize = True
        Me.lbl_Desc_Virus_Protection.Location = New System.Drawing.Point(8, 241)
        Me.lbl_Desc_Virus_Protection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_Virus_Protection.Name = "lbl_Desc_Virus_Protection"
        Me.lbl_Desc_Virus_Protection.Size = New System.Drawing.Size(116, 17)
        Me.lbl_Desc_Virus_Protection.TabIndex = 28
        Me.lbl_Desc_Virus_Protection.Text = "Virus Protection: "
        '
        'lbl_Storage
        '
        Me.lbl_Storage.AutoSize = True
        Me.lbl_Storage.Location = New System.Drawing.Point(132, 213)
        Me.lbl_Storage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Storage.Name = "lbl_Storage"
        Me.lbl_Storage.Size = New System.Drawing.Size(16, 17)
        Me.lbl_Storage.TabIndex = 27
        Me.lbl_Storage.Text = "0"
        '
        'lbl_Desc_Storage
        '
        Me.lbl_Desc_Storage.AutoSize = True
        Me.lbl_Desc_Storage.Location = New System.Drawing.Point(8, 213)
        Me.lbl_Desc_Storage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_Storage.Name = "lbl_Desc_Storage"
        Me.lbl_Desc_Storage.Size = New System.Drawing.Size(62, 17)
        Me.lbl_Desc_Storage.TabIndex = 26
        Me.lbl_Desc_Storage.Text = "Storage:"
        '
        'lbl_Memory
        '
        Me.lbl_Memory.AutoSize = True
        Me.lbl_Memory.Location = New System.Drawing.Point(132, 185)
        Me.lbl_Memory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Memory.Name = "lbl_Memory"
        Me.lbl_Memory.Size = New System.Drawing.Size(16, 17)
        Me.lbl_Memory.TabIndex = 25
        Me.lbl_Memory.Text = "0"
        '
        'lbl_Desc_Memory
        '
        Me.lbl_Desc_Memory.AutoSize = True
        Me.lbl_Desc_Memory.Location = New System.Drawing.Point(8, 185)
        Me.lbl_Desc_Memory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_Memory.Name = "lbl_Desc_Memory"
        Me.lbl_Desc_Memory.Size = New System.Drawing.Size(66, 17)
        Me.lbl_Desc_Memory.TabIndex = 24
        Me.lbl_Desc_Memory.Text = "Memory: "
        '
        'lbl_Processor
        '
        Me.lbl_Processor.AutoSize = True
        Me.lbl_Processor.Location = New System.Drawing.Point(132, 156)
        Me.lbl_Processor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Processor.Name = "lbl_Processor"
        Me.lbl_Processor.Size = New System.Drawing.Size(16, 17)
        Me.lbl_Processor.TabIndex = 23
        Me.lbl_Processor.Text = "0"
        '
        'lbl_Desc_Processor
        '
        Me.lbl_Desc_Processor.AutoSize = True
        Me.lbl_Desc_Processor.Location = New System.Drawing.Point(8, 156)
        Me.lbl_Desc_Processor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_Processor.Name = "lbl_Desc_Processor"
        Me.lbl_Desc_Processor.Size = New System.Drawing.Size(80, 17)
        Me.lbl_Desc_Processor.TabIndex = 22
        Me.lbl_Desc_Processor.Text = "Processor: "
        '
        'lbl_Boot_Mode
        '
        Me.lbl_Boot_Mode.AutoSize = True
        Me.lbl_Boot_Mode.Location = New System.Drawing.Point(132, 128)
        Me.lbl_Boot_Mode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Boot_Mode.Name = "lbl_Boot_Mode"
        Me.lbl_Boot_Mode.Size = New System.Drawing.Size(16, 17)
        Me.lbl_Boot_Mode.TabIndex = 21
        Me.lbl_Boot_Mode.Text = "0"
        '
        'lbl_Desc_Boot_Mode
        '
        Me.lbl_Desc_Boot_Mode.AutoSize = True
        Me.lbl_Desc_Boot_Mode.Location = New System.Drawing.Point(8, 128)
        Me.lbl_Desc_Boot_Mode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_Boot_Mode.Name = "lbl_Desc_Boot_Mode"
        Me.lbl_Desc_Boot_Mode.Size = New System.Drawing.Size(80, 17)
        Me.lbl_Desc_Boot_Mode.TabIndex = 20
        Me.lbl_Desc_Boot_Mode.Text = "Boot Mode:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(412, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "0"
        '
        'lbl_Desc_Brand
        '
        Me.lbl_Desc_Brand.AutoSize = True
        Me.lbl_Desc_Brand.Location = New System.Drawing.Point(353, 15)
        Me.lbl_Desc_Brand.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_Brand.Name = "lbl_Desc_Brand"
        Me.lbl_Desc_Brand.Size = New System.Drawing.Size(50, 17)
        Me.lbl_Desc_Brand.TabIndex = 18
        Me.lbl_Desc_Brand.Text = "Brand:"
        '
        'lbl_Install_Date
        '
        Me.lbl_Install_Date.Location = New System.Drawing.Point(132, 100)
        Me.lbl_Install_Date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Install_Date.Name = "lbl_Install_Date"
        Me.lbl_Install_Date.Size = New System.Drawing.Size(501, 28)
        Me.lbl_Install_Date.TabIndex = 17
        Me.lbl_Install_Date.Text = "0"
        '
        'lbl_Desc_Install_Date
        '
        Me.lbl_Desc_Install_Date.AutoSize = True
        Me.lbl_Desc_Install_Date.Location = New System.Drawing.Point(8, 100)
        Me.lbl_Desc_Install_Date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_Install_Date.Name = "lbl_Desc_Install_Date"
        Me.lbl_Desc_Install_Date.Size = New System.Drawing.Size(82, 17)
        Me.lbl_Desc_Install_Date.TabIndex = 16
        Me.lbl_Desc_Install_Date.Text = "Install Date:"
        '
        'lbl_OS
        '
        Me.lbl_OS.Location = New System.Drawing.Point(132, 71)
        Me.lbl_OS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_OS.Name = "lbl_OS"
        Me.lbl_OS.Size = New System.Drawing.Size(501, 28)
        Me.lbl_OS.TabIndex = 15
        Me.lbl_OS.Text = "0"
        '
        'lbl_Desc_OS
        '
        Me.lbl_Desc_OS.AutoSize = True
        Me.lbl_Desc_OS.Location = New System.Drawing.Point(8, 71)
        Me.lbl_Desc_OS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_OS.Name = "lbl_Desc_OS"
        Me.lbl_Desc_OS.Size = New System.Drawing.Size(36, 17)
        Me.lbl_Desc_OS.TabIndex = 14
        Me.lbl_Desc_OS.Text = "OS: "
        '
        'lbl_Domain
        '
        Me.lbl_Domain.AutoSize = True
        Me.lbl_Domain.Location = New System.Drawing.Point(412, 43)
        Me.lbl_Domain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Domain.Name = "lbl_Domain"
        Me.lbl_Domain.Size = New System.Drawing.Size(16, 17)
        Me.lbl_Domain.TabIndex = 13
        Me.lbl_Domain.Text = "0"
        '
        'lbl_Desc_Domain
        '
        Me.lbl_Desc_Domain.AutoSize = True
        Me.lbl_Desc_Domain.Location = New System.Drawing.Point(353, 43)
        Me.lbl_Desc_Domain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_Domain.Name = "lbl_Desc_Domain"
        Me.lbl_Desc_Domain.Size = New System.Drawing.Size(60, 17)
        Me.lbl_Desc_Domain.TabIndex = 12
        Me.lbl_Desc_Domain.Text = "Domain:"
        '
        'lbl_User
        '
        Me.lbl_User.Location = New System.Drawing.Point(93, 43)
        Me.lbl_User.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_User.Name = "lbl_User"
        Me.lbl_User.Size = New System.Drawing.Size(187, 28)
        Me.lbl_User.TabIndex = 11
        Me.lbl_User.Text = "0"
        '
        'lbl_Desc_User
        '
        Me.lbl_Desc_User.AutoSize = True
        Me.lbl_Desc_User.Location = New System.Drawing.Point(8, 43)
        Me.lbl_Desc_User.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_User.Name = "lbl_Desc_User"
        Me.lbl_Desc_User.Size = New System.Drawing.Size(46, 17)
        Me.lbl_Desc_User.TabIndex = 10
        Me.lbl_Desc_User.Text = "User: "
        '
        'lbl_Updated
        '
        Me.lbl_Updated.Location = New System.Drawing.Point(88, 458)
        Me.lbl_Updated.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Updated.Name = "lbl_Updated"
        Me.lbl_Updated.Size = New System.Drawing.Size(484, 28)
        Me.lbl_Updated.TabIndex = 9
        Me.lbl_Updated.Text = "0"
        '
        'lbl_Desc_Updated
        '
        Me.lbl_Desc_Updated.Location = New System.Drawing.Point(8, 458)
        Me.lbl_Desc_Updated.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_Updated.Name = "lbl_Desc_Updated"
        Me.lbl_Desc_Updated.Size = New System.Drawing.Size(484, 28)
        Me.lbl_Desc_Updated.TabIndex = 8
        Me.lbl_Desc_Updated.Text = "Updated: "
        '
        'lbl_PC_Name
        '
        Me.lbl_PC_Name.Location = New System.Drawing.Point(93, 15)
        Me.lbl_PC_Name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_PC_Name.Name = "lbl_PC_Name"
        Me.lbl_PC_Name.Size = New System.Drawing.Size(187, 28)
        Me.lbl_PC_Name.TabIndex = 7
        Me.lbl_PC_Name.Text = "0"
        '
        'lbl_Desc_PC_Name
        '
        Me.lbl_Desc_PC_Name.AutoSize = True
        Me.lbl_Desc_PC_Name.Location = New System.Drawing.Point(8, 15)
        Me.lbl_Desc_PC_Name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Desc_PC_Name.Name = "lbl_Desc_PC_Name"
        Me.lbl_Desc_PC_Name.Size = New System.Drawing.Size(75, 17)
        Me.lbl_Desc_PC_Name.TabIndex = 7
        Me.lbl_Desc_PC_Name.Text = "PC Name: "
        '
        'tbpg_Hardware
        '
        Me.tbpg_Hardware.Controls.Add(Me.grp_Memory)
        Me.tbpg_Hardware.Controls.Add(Me.grp_Drives)
        Me.tbpg_Hardware.Controls.Add(Me.grp_Processor)
        Me.tbpg_Hardware.Controls.Add(Me.grp_Sys_Model)
        Me.tbpg_Hardware.Location = New System.Drawing.Point(4, 25)
        Me.tbpg_Hardware.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpg_Hardware.Name = "tbpg_Hardware"
        Me.tbpg_Hardware.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpg_Hardware.Size = New System.Drawing.Size(757, 481)
        Me.tbpg_Hardware.TabIndex = 1
        Me.tbpg_Hardware.Text = "Hardware"
        Me.tbpg_Hardware.UseVisualStyleBackColor = True
        '
        'grp_Memory
        '
        Me.grp_Memory.Controls.Add(Me.txt_Memory)
        Me.grp_Memory.Location = New System.Drawing.Point(8, 169)
        Me.grp_Memory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_Memory.Name = "grp_Memory"
        Me.grp_Memory.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_Memory.Size = New System.Drawing.Size(736, 108)
        Me.grp_Memory.TabIndex = 28
        Me.grp_Memory.TabStop = False
        Me.grp_Memory.Text = "Memory"
        '
        'txt_Memory
        '
        Me.txt_Memory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Memory.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_Memory.Location = New System.Drawing.Point(28, 23)
        Me.txt_Memory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Memory.Multiline = True
        Me.txt_Memory.Name = "txt_Memory"
        Me.txt_Memory.ReadOnly = True
        Me.txt_Memory.Size = New System.Drawing.Size(697, 78)
        Me.txt_Memory.TabIndex = 26
        Me.txt_Memory.Text = "Slot 'ChannelA-DIMM0' has 4096 MB (serial number 12E94DA5)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Slot 'ChannelB-DIMM0'" &
    " is Empty"
        '
        'grp_Drives
        '
        Me.grp_Drives.Controls.Add(Me.txt_Drives)
        Me.grp_Drives.Location = New System.Drawing.Point(8, 284)
        Me.grp_Drives.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_Drives.Name = "grp_Drives"
        Me.grp_Drives.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_Drives.Size = New System.Drawing.Size(736, 170)
        Me.grp_Drives.TabIndex = 27
        Me.grp_Drives.TabStop = False
        Me.grp_Drives.Text = "Drives"
        '
        'txt_Drives
        '
        Me.txt_Drives.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Drives.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_Drives.Location = New System.Drawing.Point(28, 23)
        Me.txt_Drives.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Drives.Multiline = True
        Me.txt_Drives.Name = "txt_Drives"
        Me.txt_Drives.ReadOnly = True
        Me.txt_Drives.Size = New System.Drawing.Size(697, 139)
        Me.txt_Drives.TabIndex = 26
        Me.txt_Drives.Text = "PLDS DVD-RW DS8A9SH [Optical drive]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ST500DM002-1BD142 [Hard drive] (500.11 GB) -" &
    "- drive 0, s/n S2AGM0NJ, rev KC65, SMART Status: Healthy"
        '
        'grp_Processor
        '
        Me.grp_Processor.Controls.Add(Me.txt_Processor)
        Me.grp_Processor.Location = New System.Drawing.Point(387, 7)
        Me.grp_Processor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_Processor.Name = "grp_Processor"
        Me.grp_Processor.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_Processor.Size = New System.Drawing.Size(357, 154)
        Me.grp_Processor.TabIndex = 1
        Me.grp_Processor.TabStop = False
        Me.grp_Processor.Text = "Processor"
        '
        'txt_Processor
        '
        Me.txt_Processor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Processor.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_Processor.Location = New System.Drawing.Point(28, 23)
        Me.txt_Processor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Processor.Multiline = True
        Me.txt_Processor.Name = "txt_Processor"
        Me.txt_Processor.ReadOnly = True
        Me.txt_Processor.Size = New System.Drawing.Size(319, 117)
        Me.txt_Processor.TabIndex = 25
        Me.txt_Processor.Text = resources.GetString("txt_Processor.Text")
        Me.txt_Processor.WordWrap = False
        '
        'grp_Sys_Model
        '
        Me.grp_Sys_Model.Controls.Add(Me.txt_Sys_Model)
        Me.grp_Sys_Model.Location = New System.Drawing.Point(8, 7)
        Me.grp_Sys_Model.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_Sys_Model.Name = "grp_Sys_Model"
        Me.grp_Sys_Model.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_Sys_Model.Size = New System.Drawing.Size(357, 154)
        Me.grp_Sys_Model.TabIndex = 26
        Me.grp_Sys_Model.TabStop = False
        Me.grp_Sys_Model.Text = "System Model"
        '
        'txt_Sys_Model
        '
        Me.txt_Sys_Model.BackColor = System.Drawing.Color.White
        Me.txt_Sys_Model.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Sys_Model.Location = New System.Drawing.Point(28, 23)
        Me.txt_Sys_Model.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Sys_Model.Multiline = True
        Me.txt_Sys_Model.Name = "txt_Sys_Model"
        Me.txt_Sys_Model.ReadOnly = True
        Me.txt_Sys_Model.Size = New System.Drawing.Size(319, 117)
        Me.txt_Sys_Model.TabIndex = 0
        Me.txt_Sys_Model.Text = "LENOVO 3311B9U ThinkCentre M92z" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "System Serial Number: MJ18T0B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chassis Serial Nu" &
    "mber: MJ18T0B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enclosure Type: Desktop"
        '
        'tbpg_Software
        '
        Me.tbpg_Software.Controls.Add(Me.lst_Software)
        Me.tbpg_Software.Controls.Add(Me.txt_Software_Info)
        Me.tbpg_Software.Location = New System.Drawing.Point(4, 25)
        Me.tbpg_Software.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpg_Software.Name = "tbpg_Software"
        Me.tbpg_Software.Size = New System.Drawing.Size(757, 481)
        Me.tbpg_Software.TabIndex = 2
        Me.tbpg_Software.Text = "Software"
        Me.tbpg_Software.UseVisualStyleBackColor = True
        '
        'lst_Software
        '
        Me.lst_Software.FormattingEnabled = True
        Me.lst_Software.ItemHeight = 16
        Me.lst_Software.Items.AddRange(New Object() {"      Corel TW - Direct DiscRecorder version 3.6.0.0", "      Dolby Laboratories - Demo version 7.2.7000.11", "      Dolby Laboratories - Profile Launcher version 7.2.7000.11", "      Dolby Laboratories - Profile Selector version 7.2.7000.11", "    ı Apple - Software Update version 2.2", "    ı Belarc - Advisor version 8.5c", "    ı Corel - Burn.Now version 4.5.0.0", "    ı Corel - DVD MovieFactory version 7.0.0.0", "   ıı Adobe Systems - Acrobat Distiller for Windows version 9.0.0.2008061100", "   ıı Adobe Systems - Acrobat Update Service version 1.824.16.6751", "   ıı Adobe Systems - Acrobat version 9.0.0.2008061200", "   ıı Adobe Systems - AcroTray - Adobe Acrobat Distiller helper application. vers" &
                "ion 9.0.0.2008061100", "  ııı Adobe Systems - AIR version 4.0", "  ııı Adobe Systems - Flash Player Update Service version 22,0,0,192", "  ııı Adobe Systems - Reader version 10.1.16.13", "  ııı Adobe Systems - Shockwave Flash version 22,0,0,192 (32/64-bit)", " ıııı Amazon - The Amazon 1Button App version 2.3.4 (64-bit)", " ıııı Apple - Bonjour version 3,1,0,1 (64-bit)", " ıııı Apple - iTunes version 12.3.3.17 (64-bit)", " ıııı Apple - MobileDeviceService version 3.3.0.0 (64-bit)", "Google - Chrome version 51.0.2704.103", "Google - Update version 1.3.28.13", "Intel - Active Management Technology Local Manageability Service version 8.0.0.13" &
                "51", "Intel - AppUp(SM) version 3.6.1.38693", "Intel - BlueTooth High Speed version 15.2.0.0 (64-bit)", "Intel - Bluetooth LE Services Control Program version 2.6.0.260 (64-bit)", "Intel - Capability Licensing Service Interface version 1,23,216,0 (64-bit)", "Intel - Centrino Wireless Bluetooth High Speed version 15, 2, 0, 0 (64-bit)", "Intel - Common User Interface version 8.15.10.2932 (64-bit)", "Intel - Control Center version 1.2.1.1007", "Intel - Dynamic Application Loader Host Interface version 8.0.0.1351", "Intel - IAStorDataSvc version 11.0.0.1032", "Intel - IAStorIcon version 11.0.0.1032", "Intel - IAStorUI version 11.0.0.1032", "Intel - IntelCpHeciSvc Executable version 1,0,1,14", "Intel - Management and Security Application User Notification Service version 8.0" &
                ".0.1351", "Intel - Management and Security Status version 8.0.0.1351", "Intel - PIconStartup version 8.0.0.1351", "Intel - PROSet/Wireless version 15, 2, 0, 0 (64-bit)", "Intel - QuickLinker version 3.6.1.33057.10", "Intel - run_uninstaller version 3.6.1.33057.10", "Intel - Services Manager version 1.14.1.36458", "Intel - USB 3.0 Monitor version 1.0.0.120", "Lenovo - AIO version 1.0.0.12", "Lenovo - AppShopLauncher Application version 1, 0, 0, 0", "Lenovo - Desktop BIOS version 1.0.0.6", "Lenovo - Message Center Plus version 3.1.0001.00", "Lenovo - Power Manager version 1.0.0.1", "Lenovo - UserGuide version 1.0.0006.00", "Lenovo Group - Power Manager version 1, 0, 0, 2", "Lenovo Group - Power Manager version 1.0.0.0", "Lenovo Group - ThinkVantage AutoLock version 1.51.0.0", "Lenovo Group - ThinkVantage Communications Utility version 3.0.30.0", "Logitech - SetPoint version 5.90.41 (64-bit)", "Logitech - SetPoint version 6.67.83 (64-bit)", "Logitech - Unifying Software version 2.10.37 (64-bit)", "Macrovision Europe - FLEXnet Publisher (32 bit) version 11.5.0.0", "Microsoft - .NET Framework version 2.0.50727.5483 (32/64-bit)", "Microsoft - .NET Framework version 3.0.6920.5011 (64-bit)", "Microsoft - .NET Framework version 4.0.41210.0 (32/64-bit)", "Microsoft - .NET Framework version 4.6.1055.0 (32/64-bit)", "Microsoft - Clip Organizer version 14.0.7107.5000", "Microsoft - CoReXT version 7.250.4311.0 (64-bit)", "Microsoft - Internet Explorer version 11.00.9600.18347 (32/64-bit)", "Microsoft - Movie Maker version 16.4.3505.0912", "Microsoft - Office 2010 version 14.0.7170.5000 (32/64-bit)", "Microsoft - Office InfoPath version 14.0.7162.5000 (32/64-bit)", "Microsoft - Office Source Engine version 14.0.4730.1010", "Microsoft - Office version 14.0.0370.400 (64-bit)", "Microsoft - OneNote version 14.0.7162.5000", "Microsoft - Outlook version 14.0.7169.5000", "Microsoft - Photo Gallery version 16.4.3505.0912", "Microsoft - SelfCert version 14.0.7011.1000", "Microsoft - Silverlight Plug-In version 5.1.50428.0 (32/64-bit)", "Microsoft - Silverlight version 5.1.50428.0 (32/64-bit)", "Microsoft - Touch Pack for Windows 7 version 1,0,40903,00", "Microsoft - Touch Pack for Windows 7 version 1.0.40517.00", "Microsoft - Windows Installer - Unicode version 5.0.7600.16385 (32/64-bit)", "Microsoft - Windows Live Mail version 16.4.3505.0912", "Microsoft - Windows Live Messenger version 16.4.3505.0912", "Microsoft - Windows Live version 16.4.6013.0910", "Microsoft - Windows Live Writer version 16.4.3505.912", "Microsoft - Windows Media Player version 12.0.7600.16385 (32/64-bit)", "Microsoft - Windows Script Host version 5.8.7600.16385 (32/64-bit)", "Microsoft - Windows Search version 7.00.7600.16385 (32/64-bit)", "Motorola Solutions - Intel PROSet\Wireless Bluetooth version 3.0.1302.0308", "No Company Name - Create Recovery Media ", "No Company Name - Lenovo System Update Service version 5.7.0.29", "No Company Name - Lenovo System Update version 5, 7, 0, 29", "No Company Name - NA1Messenger version 19.0.24.0", "No Company Name - Power Manager version 1, 0, 0, 1", "No Company Name - Wireless PAN DHCP and DNS Server version 15, 2, 0, 0 (64-bit)", "Oracle - Java Platform SE 8 U91 version 8.0.910.14", "Oracle - Java Platform SE 8 version 8.0.910.14", "Oracle - Java Platform SE Auto Updater version 2.8.91.14", "Realtek Semiconductor - HD Audio Background Process version 1.0.0.83 (64-bit)", "Realtek Semiconductor - HD Audio Manager version 1, 0, 0, 766 (64-bit)", "Trend Micro - AEGIS version 2.974 (64-bit)", "Trend Micro - Network Security Components version 5.82 (64-bit)", "Trend Micro - OfficeScan Common Client version 19.1 (64-bit)", "Trend Micro - WFBSS version 5.9", "Ulead Systems - ULCDRSvr version 1, 0, 0, 5", "United Parcel Service - WSTDMessaging MFC Application version 19.0.11.0", "United Parcel Service - wstdSupportUtility version 19.0.12.1", "UPS - WorldShip - wstdPldReminder Application version 19, 0, 24, 0", "UPS - WorldShip Shipping System version 19, 0, 24, 0", "UPS - WorldShip Updater version 19.0.24.0"})
        Me.lst_Software.Location = New System.Drawing.Point(4, 4)
        Me.lst_Software.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lst_Software.Name = "lst_Software"
        Me.lst_Software.Size = New System.Drawing.Size(745, 340)
        Me.lst_Software.Sorted = True
        Me.lst_Software.TabIndex = 6
        '
        'txt_Software_Info
        '
        Me.txt_Software_Info.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Software_Info.Location = New System.Drawing.Point(4, 353)
        Me.txt_Software_Info.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Software_Info.Multiline = True
        Me.txt_Software_Info.Name = "txt_Software_Info"
        Me.txt_Software_Info.Size = New System.Drawing.Size(747, 121)
        Me.txt_Software_Info.TabIndex = 5
        Me.txt_Software_Info.Text = resources.GetString("txt_Software_Info.Text")
        '
        'tbpg_Users
        '
        Me.tbpg_Users.Controls.Add(Me.txt_Key)
        Me.tbpg_Users.Controls.Add(Me.grp_Domain)
        Me.tbpg_Users.Controls.Add(Me.grp_Local)
        Me.tbpg_Users.Location = New System.Drawing.Point(4, 25)
        Me.tbpg_Users.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpg_Users.Name = "tbpg_Users"
        Me.tbpg_Users.Size = New System.Drawing.Size(757, 481)
        Me.tbpg_Users.TabIndex = 3
        Me.tbpg_Users.Text = "Users"
        Me.tbpg_Users.UseVisualStyleBackColor = True
        '
        'txt_Key
        '
        Me.txt_Key.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Key.Location = New System.Drawing.Point(12, 442)
        Me.txt_Key.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Key.Multiline = True
        Me.txt_Key.Name = "txt_Key"
        Me.txt_Key.Size = New System.Drawing.Size(728, 25)
        Me.txt_Key.TabIndex = 4
        Me.txt_Key.Text = "Click username to see details"
        '
        'grp_Domain
        '
        Me.grp_Domain.Controls.Add(Me.TextBox4)
        Me.grp_Domain.Controls.Add(Me.lst_Domain_Users)
        Me.grp_Domain.Location = New System.Drawing.Point(380, 4)
        Me.grp_Domain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_Domain.Name = "grp_Domain"
        Me.grp_Domain.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_Domain.Size = New System.Drawing.Size(368, 431)
        Me.grp_Domain.TabIndex = 1
        Me.grp_Domain.TabStop = False
        Me.grp_Domain.Text = "Domain"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(7, 321)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(351, 102)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Text = "User" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Last Login:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10/36/2025" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "23:59:59"
        '
        'lst_Domain_Users
        '
        Me.lst_Domain_Users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_Domain_Users.FormattingEnabled = True
        Me.lst_Domain_Users.ItemHeight = 16
        Me.lst_Domain_Users.Items.AddRange(New Object() {"acoyne", "cfowler", "cleverfish", "crhoades", "cviadmin", "jmctague", "jyoung", "lneville", "msebolka", "myohey"})
        Me.lst_Domain_Users.Location = New System.Drawing.Point(7, 18)
        Me.lst_Domain_Users.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lst_Domain_Users.MultiColumn = True
        Me.lst_Domain_Users.Name = "lst_Domain_Users"
        Me.lst_Domain_Users.Size = New System.Drawing.Size(351, 290)
        Me.lst_Domain_Users.Sorted = True
        Me.lst_Domain_Users.TabIndex = 1
        '
        'grp_Local
        '
        Me.grp_Local.Controls.Add(Me.txt_Local_User_Info)
        Me.grp_Local.Controls.Add(Me.lst_Local_Users)
        Me.grp_Local.Location = New System.Drawing.Point(4, 4)
        Me.grp_Local.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_Local.Name = "grp_Local"
        Me.grp_Local.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_Local.Size = New System.Drawing.Size(368, 431)
        Me.grp_Local.TabIndex = 0
        Me.grp_Local.TabStop = False
        Me.grp_Local.Text = "Local"
        '
        'txt_Local_User_Info
        '
        Me.txt_Local_User_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Local_User_Info.Location = New System.Drawing.Point(7, 321)
        Me.txt_Local_User_Info.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Local_User_Info.Multiline = True
        Me.txt_Local_User_Info.Name = "txt_Local_User_Info"
        Me.txt_Local_User_Info.ReadOnly = True
        Me.txt_Local_User_Info.Size = New System.Drawing.Size(351, 102)
        Me.txt_Local_User_Info.TabIndex = 3
        Me.txt_Local_User_Info.Text = "Admin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Last Login:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10/36/2025" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "23:59:59"
        '
        'lst_Local_Users
        '
        Me.lst_Local_Users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_Local_Users.FormattingEnabled = True
        Me.lst_Local_Users.ItemHeight = 16
        Me.lst_Local_Users.Items.AddRange(New Object() {"Administrator", "cleverfish"})
        Me.lst_Local_Users.Location = New System.Drawing.Point(7, 18)
        Me.lst_Local_Users.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lst_Local_Users.MultiColumn = True
        Me.lst_Local_Users.Name = "lst_Local_Users"
        Me.lst_Local_Users.Size = New System.Drawing.Size(351, 290)
        Me.lst_Local_Users.Sorted = True
        Me.lst_Local_Users.TabIndex = 0
        '
        'btn_First
        '
        Me.btn_First.Location = New System.Drawing.Point(16, 532)
        Me.btn_First.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_First.Name = "btn_First"
        Me.btn_First.Size = New System.Drawing.Size(100, 28)
        Me.btn_First.TabIndex = 0
        Me.btn_First.Text = "First"
        Me.btn_First.UseVisualStyleBackColor = True
        '
        'btn_Previous
        '
        Me.btn_Previous.Location = New System.Drawing.Point(124, 532)
        Me.btn_Previous.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Previous.Name = "btn_Previous"
        Me.btn_Previous.Size = New System.Drawing.Size(100, 28)
        Me.btn_Previous.TabIndex = 1
        Me.btn_Previous.Text = "Previous"
        Me.btn_Previous.UseVisualStyleBackColor = True
        '
        'btn_Last
        '
        Me.btn_Last.Location = New System.Drawing.Point(673, 532)
        Me.btn_Last.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Last.Name = "btn_Last"
        Me.btn_Last.Size = New System.Drawing.Size(100, 28)
        Me.btn_Last.TabIndex = 2
        Me.btn_Last.Text = "Last"
        Me.btn_Last.UseVisualStyleBackColor = True
        '
        'btn_Next
        '
        Me.btn_Next.Location = New System.Drawing.Point(565, 532)
        Me.btn_Next.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(100, 28)
        Me.btn_Next.TabIndex = 3
        Me.btn_Next.Text = "Next"
        Me.btn_Next.UseVisualStyleBackColor = True
        '
        'lbl_cur_Record
        '
        Me.lbl_cur_Record.AutoSize = True
        Me.lbl_cur_Record.Location = New System.Drawing.Point(232, 538)
        Me.lbl_cur_Record.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cur_Record.Name = "lbl_cur_Record"
        Me.lbl_cur_Record.Size = New System.Drawing.Size(96, 17)
        Me.lbl_cur_Record.TabIndex = 4
        Me.lbl_cur_Record.Text = "99999999999"
        '
        'lbl_Of
        '
        Me.lbl_Of.AutoSize = True
        Me.lbl_Of.Location = New System.Drawing.Point(385, 538)
        Me.lbl_Of.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Of.Name = "lbl_Of"
        Me.lbl_Of.Size = New System.Drawing.Size(20, 17)
        Me.lbl_Of.TabIndex = 5
        Me.lbl_Of.Text = "of"
        '
        'lbl_Record_Count
        '
        Me.lbl_Record_Count.Location = New System.Drawing.Point(455, 538)
        Me.lbl_Record_Count.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Record_Count.Name = "lbl_Record_Count"
        Me.lbl_Record_Count.Size = New System.Drawing.Size(103, 16)
        Me.lbl_Record_Count.TabIndex = 6
        Me.lbl_Record_Count.Text = "99999999999"
        Me.lbl_Record_Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 571)
        Me.Controls.Add(Me.lbl_Record_Count)
        Me.Controls.Add(Me.lbl_Of)
        Me.Controls.Add(Me.lbl_cur_Record)
        Me.Controls.Add(Me.btn_Next)
        Me.Controls.Add(Me.btn_Last)
        Me.Controls.Add(Me.btn_First)
        Me.Controls.Add(Me.btn_Previous)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_Main"
        Me.Text = "PC Inventory"
        Me.TabControl1.ResumeLayout(False)
        Me.tbpg_Overview.ResumeLayout(False)
        Me.tbpg_Overview.PerformLayout()
        Me.tbpg_Hardware.ResumeLayout(False)
        Me.grp_Memory.ResumeLayout(False)
        Me.grp_Memory.PerformLayout()
        Me.grp_Drives.ResumeLayout(False)
        Me.grp_Drives.PerformLayout()
        Me.grp_Processor.ResumeLayout(False)
        Me.grp_Processor.PerformLayout()
        Me.grp_Sys_Model.ResumeLayout(False)
        Me.grp_Sys_Model.PerformLayout()
        Me.tbpg_Software.ResumeLayout(False)
        Me.tbpg_Software.PerformLayout()
        Me.tbpg_Users.ResumeLayout(False)
        Me.tbpg_Users.PerformLayout()
        Me.grp_Domain.ResumeLayout(False)
        Me.grp_Domain.PerformLayout()
        Me.grp_Local.ResumeLayout(False)
        Me.grp_Local.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbpg_Overview As TabPage
    Friend WithEvents tbpg_Hardware As TabPage
    Friend WithEvents tbpg_Software As TabPage
    Friend WithEvents tbpg_Users As TabPage
    Friend WithEvents btn_First As Button
    Friend WithEvents btn_Previous As Button
    Friend WithEvents btn_Last As Button
    Friend WithEvents btn_Next As Button
    Friend WithEvents lbl_cur_Record As Label
    Friend WithEvents lbl_Of As Label
    Friend WithEvents lbl_Record_Count As Label
    Friend WithEvents lbl_Domain As Label
    Friend WithEvents lbl_User As Label
    Friend WithEvents lbl_Updated As Label
    Friend WithEvents lbl_Desc_Updated As Label
    Friend WithEvents lbl_PC_Name As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_Install_Date As Label
    Friend WithEvents lbl_OS As Label
    Private WithEvents lbl_Desc_Domain As Label
    Private WithEvents lbl_Desc_User As Label
    Private WithEvents lbl_Desc_PC_Name As Label
    Private WithEvents lbl_Desc_Brand As Label
    Private WithEvents lbl_Desc_Install_Date As Label
    Private WithEvents lbl_Desc_OS As Label
    Friend WithEvents lbl_Memory As Label
    Private WithEvents lbl_Desc_Memory As Label
    Friend WithEvents lbl_Processor As Label
    Private WithEvents lbl_Desc_Processor As Label
    Friend WithEvents lbl_Boot_Mode As Label
    Private WithEvents lbl_Desc_Boot_Mode As Label
    Friend WithEvents txt_Processor As TextBox
    Friend WithEvents lbl_Storage As Label
    Private WithEvents lbl_Desc_Storage As Label
    Friend WithEvents lbl_Virus_Protection As Label
    Friend WithEvents lbl_Desc_Virus_Protection As Label
    Friend WithEvents lbl_Software_Count As Label
    Friend WithEvents lbl_Desc_Software_Count As Label
    Friend WithEvents grp_Memory As GroupBox
    Friend WithEvents txt_Memory As TextBox
    Friend WithEvents grp_Drives As GroupBox
    Friend WithEvents txt_Drives As TextBox
    Friend WithEvents grp_Processor As GroupBox
    Friend WithEvents grp_Sys_Model As GroupBox
    Friend WithEvents txt_Sys_Model As TextBox
    Friend WithEvents grp_Domain As GroupBox
    Friend WithEvents lst_Domain_Users As ListBox
    Friend WithEvents grp_Local As GroupBox
    Friend WithEvents lst_Local_Users As ListBox
    Private WithEvents txt_Key As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txt_Local_User_Info As TextBox
    Private WithEvents txt_Software_Info As TextBox
    Friend WithEvents lst_Software As ListBox
    Friend WithEvents lbl_File_Location As Label
    Friend WithEvents lbl_Desc_File_Loaction As Label
End Class
