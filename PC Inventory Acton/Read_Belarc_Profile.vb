Imports System.IO



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

    Public Function get_element() As String
        Return html_list(0).get_Element()
    End Function

    Public Function get_all_Elements()
        'Return html_list(0).get_all_Elements
    End Function

    Public ReadOnly Property open_Files As Integer
        Get
            Return html_list.Count
        End Get
    End Property

    Public ReadOnly Property Name(Optional index As Integer = 0) As String
        Get
            Return html_list(index).pc_name
        End Get
    End Property

    Public ReadOnly Property Profile_Date(Optional index As Integer = 0) As String
        Get
            Return html_list(index).profile_date
        End Get
    End Property

    Public ReadOnly Property file(index As Integer) As FileInfo
        Get
            Return File_List(index)
        End Get
    End Property

    Public ReadOnly Property Current_Login(index As Integer) As String
        Get
            Return html_list(index).Current_Login
        End Get
    End Property

    Public ReadOnly Property os(index As Integer) As String
        Get
            Return html_list(index).os
        End Get
    End Property

    Public ReadOnly Property os_Install_Date(index As Integer) As String
        Get
            Return html_list(index).os_Install_Date
        End Get
    End Property

    Public ReadOnly Property boot_mode(index As Integer) As String
        Get
            Return html_list(index).boot_Mode
        End Get
    End Property

    Public ReadOnly Property proc(index As Integer) As String
        Get
            Return html_list(index).proc
        End Get
    End Property

    Public ReadOnly Property mem(index As Integer) As String
        Get
            Return html_list(index).mem
        End Get
    End Property

    Public ReadOnly Property hdds(index As Integer) As String
        Get
            Return html_list(index).hdds
        End Get
    End Property

    Public ReadOnly Property virus_Protection(index As Integer) As String
        Get
            Return html_list(index).virus_protection
        End Get
    End Property

    Public ReadOnly Property app_Count(index As Integer) As Integer
        Get
            Return html_list(index).installed_Apps
        End Get
    End Property

    Public ReadOnly Property Applications(index As Integer) As List(Of String)
        Get
            Return html_list(index).Applications
        End Get
    End Property
End Class

Public Class HTML_Document_Array
    Private doc As String
    Private all_Apps As New List(Of String)

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

    Sub New(html_Doc As FileInfo)

        Using reader As StreamReader = New StreamReader(html_Doc.FullName)
            doc = reader.ReadToEnd
        End Using

    End Sub

    Public Function get_Element() As String
        Return doc
    End Function

    Public Function pc_name() As String
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Computer Name:", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Substring(0, s.IndexOf("(", comparisons(5)))      ' This could cause an issue if the ( is missing.
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            Return s
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function Current_Login() As String
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Windows Logon:", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            Return s
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function os() As String
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Operating System", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("   ", " ").Replace("  ", " ").Trim
            Return s
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function os_Install_Date() As String
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Installed:", comparisons(5)))
            s = s.Substring(s.IndexOf(":", comparisons(5)) + 1)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("   ", " ").Replace("  ", " ").Trim
            Return s
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function boot_Mode() As String
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Boot Mode:", comparisons(5)))
            s = s.Substring(s.IndexOf(":", comparisons(5)) + 1)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)) - 1)
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("   ", " ").Replace("  ", " ").Trim
            Return s
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function proc() As String
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Processor", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("   ", " ").Replace("  ", " ").Trim
            Return s
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function mem() As String
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Memory Modules <", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("   ", " ").Replace("  ", " ").Trim
            Return s
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function hdds() As String
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Drives", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("   ", " ").Replace("  ", " ").Trim
            Return s
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function virus_protection() As String
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("<CAPTION>						Virus Protection", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("</TD>", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("<B>", " ").Replace("</B>", " ").Trim
            s = s.Replace("   ", " ").Replace("  ", " ").Trim
            Return s
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ' *************  This function needs to be completely re-written.  It is to dependent on the HTML files being formated
    ' *************  The same, AND they are far from.
    ' #############  I think I have corrected the issue mentioned above.
    ''' <summary>
    ''' Gets a count of all the applications, and fills a list containing all the application names.
    ''' </summary>
    ''' <returns>Application count</returns>
    Public Function installed_Apps() As Integer
        If all_Apps.Count > 0 Then Return all_Apps.Count
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

            Return all_Apps.Count   ' Return the final Count.
        Catch ex As Exception
            Return -1   ' If we get an error return -1 so we know there was an error
        End Try

        Return 9999     ' If we get here return a ridiculous number so we know something went wrong.
    End Function

    Public Function profile_date() As String
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Profile Date:", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            Return s
        Catch ex As Exception
            Return ""
        End Try
    End Function



End Class