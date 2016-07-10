Imports System.IO
Imports System.ComponentModel


''' <summary>
''' Reads information from HTML documents created from the Belarc Advisor.
''' </summary>
Public Class Read_Belarc_Profile

    Private html_list As New List(Of HTML_Document_Array)
    Private File_List As New List(Of FileInfo)

    ''' <summary>
    ''' Initialize a new Blank instance of this class.
    ''' </summary>
    Sub New()

    End Sub
    ''' <summary>
    ''' Reads an HTML file into an array for parsing.
    ''' </summary>
    ''' <param name="file">A file as a string. (ex: C:\profiles\profile.html)</param>
    Public Sub read_html_Profile(file As String)
        read_html_Profile(New FileInfo(file))
    End Sub
    ''' <summary>
    ''' Reads an HTML file into an array for parsing.
    ''' </summary>
    ''' <param name="file">A file as a Fileinfo Object.</param>
    Public Sub read_html_Profile(file As FileInfo)

    End Sub
    ''' <summary>
    ''' Loads a directory and reads all HTML files into seperate arrays for parsing.
    ''' </summary>
    ''' <param name="directory">A directory as a string. (ex: C:\profiles)</param>
    Public Sub load_Directory(directory As String)
        load_Directory(New DirectoryInfo(directory))
    End Sub
    ''' <summary>
    ''' Loads a directory and reads all HTML files into seperate arrays for parsing.
    ''' </summary>
    ''' <param name="directory">A directory as a DirectoryInfo object.</param>
    Public Sub load_Directory(directory As DirectoryInfo)
        For Each file As FileInfo In directory.EnumerateFiles
            If LCase(file.Extension) = ".html" Then
                File_List.Add(file)
                html_list.Add(New HTML_Document_Array(file))
            End If
        Next
    End Sub

    Public Function get_all_Elements(index As Integer)
        Dim temp_string As String = ""
        With html_list(index)
            temp_string &= .computer_Name & ","
            temp_string &= .computer_model & ","
            temp_string &= .system_serial & ","
            temp_string &= .installed_Processor & ","
            temp_string &= .installed_Memory & ","
            temp_string &= .boot_type & ","
            temp_string &= .hdd_stoage_space & ","
            temp_string &= .operating_System & ","
            temp_string &= .os_Installed_Date & ","
            temp_string &= .application_count & ","
            temp_string &= .installed_Virus_protection & ","
            temp_string &= .last_profile_date.Replace(",", " ")

        End With
        Return temp_string
    End Function

    Public ReadOnly Property open_Files As Integer
        Get
            Return html_list.Count
        End Get
    End Property

    Public ReadOnly Property pc_Name(Optional index As Integer = 0) As String
        Get
            Return html_list(index).computer_Name
        End Get
    End Property

    Public ReadOnly Property Profile_Date(Optional index As Integer = 0) As String
        Get
            Return html_list(index).last_profile_date
        End Get
    End Property

    Public ReadOnly Property file(index As Integer) As FileInfo
        Get
            Return File_List(index)
        End Get
    End Property

    Public ReadOnly Property Current_Login(index As Integer) As String
        Get
            Return html_list(index).profiled_login
        End Get
    End Property

    Public ReadOnly Property os(index As Integer) As String
        Get
            Return html_list(index).operating_System
        End Get
    End Property

    Public ReadOnly Property os_Install_Date(index As Integer) As String
        Get
            Return html_list(index).os_Installed_Date
        End Get
    End Property

    Public ReadOnly Property boot_mode(index As Integer) As String
        Get
            Return html_list(index).boot_type
        End Get
    End Property

    Public ReadOnly Property proc(index As Integer) As String
        Get
            Return html_list(index).installed_Processor
        End Get
    End Property

    Public ReadOnly Property mem(index As Integer) As String
        Get
            Return html_list(index).installed_Memory
        End Get
    End Property

    Public ReadOnly Property hdds(index As Integer) As String
        Get
            Return html_list(index).hdd_stoage_space
        End Get
    End Property

    Public ReadOnly Property virus_Protection(index As Integer) As String
        Get
            Return html_list(index).installed_Virus_protection
        End Get
    End Property

    Public ReadOnly Property app_Count(index As Integer) As Integer
        Get
            Return html_list(index).application_count
        End Get
    End Property

    Public ReadOnly Property Applications(index As Integer) As List(Of String)
        Get
            Return html_list(index).Applications
        End Get
    End Property

    Public ReadOnly Property PC_Model(index) As String
        Get
            Return html_list(index).computer_model
        End Get
    End Property

    Public ReadOnly Property serial(index) As String
        Get
            Return html_list(index).system_serial
        End Get
    End Property
End Class

' *****************************************************************************************

Public Class HTML_Document_Array
    Implements System.IDisposable
    Private doc, PC_nme, op_sys, os_Install, boot_method, processor, memory, hd_space, virus_Soft, profiled_on As String
    Private model, pc_Serial, profiled_user As String
    Private all_Apps As New List(Of String)
    ' Track whether Dispose has been called.
    Private disposed As Boolean = False
    ' Other managed resource this class uses.
    Private component As Component
    ' Pointer to an external unmanaged resource.
    Private handle As IntPtr

    ' Used to evaluate the difference between strings (html document, to static arguments)
    Private comparisons() As StringComparison = CType([Enum].GetValues(GetType(StringComparison)), StringComparison())


    ''' <summary>
    ''' Expose the list of Applications without allowing for external changes.
    ''' </summary>
    ''' <returns>List of String</returns>
    Public ReadOnly Property Applications As List(Of String)
        Get
            Return all_Apps
        End Get
    End Property

    Public ReadOnly Property html_Document
        Get
            Return doc
        End Get
    End Property

    Public ReadOnly Property computer_Name As String
        Get
            Return PC_nme
        End Get
    End Property

    Public ReadOnly Property operating_System As String
        Get
            Return op_sys
        End Get
    End Property

    Public ReadOnly Property os_Installed_Date As String
        Get
            Return os_Install
        End Get
    End Property

    Public ReadOnly Property boot_type As String
        Get
            Return boot_method
        End Get
    End Property

    Public ReadOnly Property installed_Processor As String
        Get
            Return processor
        End Get
    End Property

    Public ReadOnly Property installed_Memory As String
        Get
            Return memory
        End Get
    End Property

    Public ReadOnly Property hdd_stoage_space As String
        Get
            Return hd_space
        End Get
    End Property

    Public ReadOnly Property installed_Virus_protection As String
        Get
            Return virus_Soft
        End Get
    End Property

    Public ReadOnly Property last_profile_date As String
        Get
            Return profiled_on
        End Get
    End Property

    Public ReadOnly Property computer_model As String
        Get
            Return model
        End Get
    End Property

    Public ReadOnly Property system_serial As String
        Get
            Return pc_Serial
        End Get
    End Property

    Public ReadOnly Property application_count As Integer
        Get
            Return all_Apps.Count
        End Get
    End Property

    Public ReadOnly Property profiled_login As String
        Get
            Return profiled_user
        End Get
    End Property


    ''' <summary>
    ''' Create a new instance of this class.
    ''' </summary>
    ''' <param name="html_Doc">The HTML document created by Belarc to read.</param>
    Sub New(html_Doc As FileInfo)
        Me.handle = handle

        Using reader As StreamReader = New StreamReader(html_Doc.FullName)
            doc = reader.ReadToEnd
        End Using
        pc_name()
        Current_Login()
        os()
        os_Install_Date()
        boot_Mode()
        proc()
        mem()
        hdds()
        virus_protection()
        installed_Apps()
        profile_date()
        PC_Model()
        serial()
    End Sub

    Public Overloads Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    ''' <summary>
    ''' executes in two distinct scenarios. 
    ''' If disposing equals true, the method has been called directly or indirectly by a user's code. 
    ''' Managed and unmanaged resources can be disposed. If disposing equals false, the method has been called by the 
    ''' runtime from inside the finalizer and you should not reference other objects.
    ''' </summary>
    ''' <param name="disposing">True if called by user code.</param>
    Protected Overridable Overloads Sub Dispose(ByVal disposing As Boolean)
        ' Check to see if Dispose has already been called.
        If Not Me.disposed Then
            ' If disposing equals true, dispose all managed 
            ' and unmanaged resources.
            If disposing Then
                ' Dispose managed resources.
                component.Dispose()
            End If

            ' Call the appropriate methods to clean up 
            ' unmanaged resources here.
            ' If disposing is false, 
            ' only the following code is executed.
            CloseHandle(handle)
            handle = IntPtr.Zero

            ' Note disposing has been done.
            disposed = True

        End If
    End Sub


    ' ### Private section ###

    ' Use interop to call the method necessary  
    ' to clean up the unmanaged resource.
    <System.Runtime.InteropServices.DllImport("Kernel32")>
    Private Shared Function CloseHandle(ByVal handle As IntPtr) As [Boolean]
    End Function

    ' This finalizer will run only if the Dispose method 
    ' does not get called.
    ' It gives your base class the opportunity to finalize.
    ' Do not provide finalize methods in types derived from this class.
    Protected Overrides Sub Finalize()
        ' Do not re-create Dispose clean-up code here.
        ' Calling Dispose(false) is optimal in terms of
        ' readability and maintainability.
        Dispose(False)
        MyBase.Finalize()
    End Sub

    Private Sub pc_name()
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Computer Name:", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Substring(0, s.IndexOf("(", comparisons(5)))      ' This could cause an issue if the ( is missing.
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            PC_nme = s
        Catch ex As Exception
            PC_nme = ex.Message
        End Try
    End Sub

    Private Sub Current_Login()
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Windows Logon:", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            profiled_user = s
        Catch ex As Exception
            profiled_user = ex.Message
        End Try
    End Sub

    Private Sub os()
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Operating System", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("   ", " ").Replace("  ", " ").Trim
            op_sys = s
        Catch ex As Exception
            op_sys = ex.Message
        End Try
    End Sub

    Private Sub os_Install_Date()
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Installed:", comparisons(5)))
            s = s.Substring(s.IndexOf(":", comparisons(5)) + 1)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("   ", " ").Replace("  ", " ").Trim
            os_Install = s
        Catch ex As Exception
            os_Install = ex.Message
        End Try
    End Sub

    Private Sub boot_Mode()
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Boot Mode:", comparisons(5)))
            s = s.Substring(s.IndexOf(":", comparisons(5)) + 1)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)) - 1)
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("   ", " ").Replace("  ", " ").Trim
            boot_method = s
        Catch ex As Exception
            boot_method = ex.Message
        End Try
    End Sub

    Private Sub proc()
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Processor", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("   ", " ").Replace("  ", " ").Trim
            processor = s
        Catch ex As Exception
            processor = ex.Message
        End Try
    End Sub

    Private Sub mem()
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Memory Modules <", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("   ", " ").Replace("  ", " ").Trim
            memory = s
        Catch ex As Exception
            memory = ex.Message
        End Try
    End Sub

    Private Sub hdds()
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Drives", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("   ", " ").Replace("  ", " ").Trim
            hd_space = s
        Catch ex As Exception
            hd_space = ex.Message
        End Try
    End Sub

    Private Sub virus_protection()
        Try
            Dim Temp_String As String = doc.Substring(doc.IndexOf("[Virus Protection]", comparisons(5)))
            Temp_String = Temp_String.Substring(Temp_String.IndexOf("<B>", comparisons(5)) + 3)
            Temp_String = Temp_String.Substring(0, Temp_String.IndexOf("</TD>", comparisons(5)))
            Temp_String = Temp_String.Replace(vbCr, "").Replace(vbLf, "").Trim
            Temp_String = Temp_String.Replace("</b>", " ").Replace("</B>", " ").Trim
            Temp_String = Temp_String.Replace("   ", " ").Replace("  ", " ").Trim
            virus_Soft = Temp_String
        Catch ex As Exception
            virus_Soft = ex.Message
        End Try
    End Sub

    ''' <summary>
    ''' Gets a count of all the applications, and fills a list containing all the application names.
    ''' </summary>
    ''' <returns>Application count</returns>
    Private Sub installed_Apps()
        Try
            ' Take out the part with the application names, and clean up some of the HTML code.
            Dim Temp_String As String = doc.Substring(doc.IndexOf("[Software Versions]", comparisons(5))) ' Create a new string starting at the applications section of the HTML code.
            Temp_String = Temp_String.Substring(Temp_String.IndexOf(">i</SPAN></A>", comparisons(5)) + 13) ' Remove some of the unneeded beginning of the string.
            Temp_String = Temp_String.Substring(0, Temp_String.IndexOf("</table>", comparisons(5))) ' Set the end of the block of HTML code.

            Temp_String = Temp_String.Replace(vbCr, "").Replace(vbLf, "").Trim ' Remove some of the unwanted formating from the HTML code.
            Temp_String = Temp_String.Replace("<B>", " ").Replace("</B>", " ").Trim ' Remove more of the unwanted formating from the HTML.
            Temp_String = Temp_String.Replace("   ", " ").Replace("  ", " ").Trim ' Remove the extra spacing of the unwanted HTML.

            Dim temp_String_list As New List(Of String)
            temp_String_list.AddRange(Temp_String.Split("</A>"))   ' Create a list of seperate lines.

            For Each line As String In temp_String_list
                If line.Contains("&nbsp") Then ' Get just the parts with Application titles.
                    If line(0) = "A" Then Continue For ' Remove lines starting with A.
                    If line.Contains("SPAN") Then Continue For ' remove lines containing SPAN.
                    Dim temp_Line As String = line.Remove(0, line.LastIndexOf(";") + 1) ' Remove the unwanted section at the beginning of the line.
                    temp_Line = temp_Line.Replace("   ", " ").Trim() ' remove large spaces, beginning, and trailing spaces.
                    If temp_Line = "" Then Continue For ' Do not add blank lines.
                    all_Apps.Add(temp_Line) ' Add the application title to the list.
                End If
            Next
        Catch ex As Exception
            all_Apps.Add(ex.Message)
        End Try
    End Sub

    Private Sub profile_date()
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Profile Date:", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            profiled_on = s
        Catch ex As Exception
            profiled_on = ex.Message
        End Try
    End Sub

    Private Sub PC_Model()
        Try
            Dim temp_String As String = doc.Substring(doc.IndexOf("[System Model]", comparisons(5)))
            temp_String = temp_String.Remove(0, 10)
            temp_String = temp_String.Substring(temp_String.IndexOf("System Model", comparisons(5)))
            temp_String = temp_String.Substring(temp_String.IndexOf("<TD>", comparisons(5)) + 4)
            temp_String = temp_String.Substring(0, temp_String.IndexOf("<", comparisons(5)))
            temp_String = temp_String.Replace(vbCr, "").Replace(vbLf, "").Trim
            model = temp_String
        Catch ex As Exception
            model = ex.Message
        End Try
    End Sub

    Private Sub serial()
        Try
            Dim temp_String As String = doc.Substring(doc.IndexOf("[System Model]", comparisons(5)))
            temp_String = temp_String.Substring(temp_String.IndexOf("Serial Number", comparisons(5)) + "Serial Number".Length)
            temp_String = temp_String.Replace(":", "")
            temp_String = temp_String.Substring(0, temp_String.IndexOf("<", comparisons(5)))
            temp_String = temp_String.Replace(vbCr, "").Replace(vbLf, "").Trim
            pc_Serial = temp_String
        Catch ex As Exception
            pc_Serial = ex.Message
        End Try
    End Sub

End Class