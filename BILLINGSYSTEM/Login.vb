Imports System.Data.SqlClient

Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading.Hide()
        Me.Show()
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""

    End Sub
    Dim Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Prithviraj\Desktop\GAD MICRO\Databasebilling.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '  If PasswordTextBox.Text = "" Or UsernameTextBox.Text = "" Then
        'MsgBox("Enter Password for Admin")
        ' ElseIf PasswordTextBox.Text = "Admin" Then
        'Inventory.Show()
        'Me.Hide()
        ' Else
        'MsgBox("Wrong Password")
        'End If

        If PasswordTextBox.Text = "" Or UsernameTextBox.Text = "' Then" Then
            MsgBox("Enter credentials")
        ElseIf PasswordTextBox.Text = "" Then
            MsgBox("Enter Password")
        Else
            Con.Open()

            Dim query = "select * from login where [user] ='" & UsernameTextBox.Text & "' and [password] ='" & PasswordTextBox.Text & "'"
            Dim cmd = New SqlCommand(query, Con)
            Dim da = New SqlDataAdapter(cmd)
            Dim ds = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count

            If a = 0 Then
                MsgBox("Wrong Password and Username", 0, "Invalid credentials")
            Else
                MsgBox("Login Success", 0, "Login")
                Me.Hide()
                Inventory.Show()

            End If

            Con.Close()

        End If

    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
       new_signin.Show()
        Me.Hide()
    End Sub
End Class
