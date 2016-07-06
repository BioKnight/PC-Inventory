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
End Class

Public Class HTML_Document_Array
    Private doc As String

    Private comparisons() As StringComparison = CType([Enum].GetValues(GetType(StringComparison)), StringComparison())


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
        'Profile Date:
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
        'Profile Date:
        Try
            Dim s As String = doc.Substring(doc.IndexOf("<body>", comparisons(5)))
            s = s.Substring(s.IndexOf("Operating System", comparisons(5)))
            s = s.Substring(s.IndexOf("<TD>", comparisons(5)) + 4)
            s = s.Substring(0, s.IndexOf("<", comparisons(5)))
            s = s.Replace(vbCr, "").Replace(vbLf, "").Trim
            s = s.Replace("   ", " ").Replace("   ", " ").Trim
            s = s.Replace("  ", " ").Replace("  ", " ").Trim
            Return s
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function profile_date() As String
        'Profile Date:
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