Imports System.Data.OleDb

Public Class bill
    ' Dim coonection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Prithviraj\Desktop\GAD MICRO\Databasebilling.mdf;Integrated Security=True;Connect Timeout=30")
    ' Dim abc = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Prithviraj\Desktop\GAD MICRO\Databasebilling.mdf;Integrated Security=True;Connect Timeout=30")
    Dim coonection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Prithviraj\Desktop\GAD MICRO1\ShopBilling.mdb")
    Public incrementvalue As Integer = 1

    Private Property dr As Object



    Dim da As OleDbDataAdapter
    Dim cmd, cmd1 As OleDbCommand
    Dim ds As DataSet






    Private Sub Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Qty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub Qty_TextChanged(sender As Object, e As EventArgs) Handles Qty.TextChanged

    End Sub



    Private Sub Discount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Discount.KeyPress
        Dim tot, a As Double
        a = Double.Parse(Qty.Text)

        tot = Double.Parse(utprice.Text)
        tot1.Text = tot * a

        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub tDiscount_MouseClick(sender As Object, e As MouseEventArgs) Handles Discount.MouseClick

    End Sub

    Private Sub Discount_TextChanged(sender As Object, e As EventArgs) Handles Discount.TextChanged

    End Sub

    Public Sub Newcust_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        If cust.Text = "" Or address.Text = "" Or mobile.Text = "" Or dt.Text = "" Or Qty.Text = "" Or Discount.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim a, b, c, d, taxrate, f, g, h, j As Double
            a = Double.Parse(Qty.Text)
            UpdateItemQuantity()

            b = Double.Parse(utprice.Text)
            c = Double.Parse(Discount.Text)
            taxrate = Double.Parse(Tax.Text)
            h = Double.Parse(mobile.Text)
            f = a * b
            d = f - c
            '   d = Double.Parse((a * b) - c)
            'tot1.Text = d
            tot2.Text = d
            j = tot2.Text
            g = (d * taxrate \ 100)
            g = g + d
            tot3.Text = g





                ' tot3.Text = (d * taxrate \ 100) + d

            '                coonection.open()
                ' Dim query As String = "INSERT INTO mainform VALUES ('"&inno.Text"','" & dt.Text & "','" & cust.Text & "','" & address.Text & "','" &mobile.Text & "','" & tot2.Text & "','" & Tax.Text & "','" & tot1.Text & "')"
            ' Dim query As String = "INSERT INTO mainnform VALUES ('" & inno.Text & "','" & dt.Text & "','" & cust.Text & "','" & address.Text & "', " & h & "," & j & "," & taxrate & "," & tot1.Text & ")"
            'Dim cmd As SqlCommand

            coonection.Open()
            cmd.Connection = coonection
            cmd.CommandText = "Insert into mainform values('" & inno.Text & "','" & dt.Text & "','" & cust.Text & "','" & address.Text & "', " & h & "," & j & "," & taxrate & "," & tot1.Text & ")"
            cmd.ExecuteNonQuery()
            MsgBox("Data Saved")
            cmd1.Connection = coonection
            cmd1.CommandText = "Insert into datagrid values('" & inno.Text & "','" & Combo.SelectedItem & "'," & a & "," & b & "," & c & "," & tot1.Text & ")"
            cmd1.ExecuteNonQuery()
            coonection.Close()
        End If










        '    cmd = New SqlCommand(query, coonection)
        'Try

        ' Dim str As String = "INSERT INTO datagrid VALUES ('" & inno.Text & "','" & Combo.SelectedItem & "'," & a & "," & b & "," & c & "," & tot1.Text & ")"
        'Dim cn As SqlCommand
        'cn = New SqlCommand(str, coonection)
        'Try
        'cn.ExecuteNonQuery()
        ' coonection.close()

        'Catch ex As SqlException
        'End Try

        'abc.open()
        ' Dim str As String = "INSERT INTO datagrid VALUES ('" & inno.Text & "','" & description.Text & "'," & a & "," & b & "," & c & "," & tot1.Text & ")"
        ' Dim cn As SqlCommand
        ' cn = New SqlCommand(str, abc)
        'Try
        ' cn.ExecuteNonQuery()
        'Catch ex As Exception
        'End Try

        ' abc.close()

        'End If

    End Sub



    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display() 'inno.Text = getinvoice()
        Dim newInvoiceNo As String = GenerateInvoiceNumber()
        inno.Text = newInvoiceNo
        FillComboBox()
        Timer1.Interval = 1000
        Timer1.Start()

    End Sub


    Private Sub FillComboBox()
        Combo.Items.Clear()

        Try
            ' Open the connection
            coonection.Open()

            ' Define the SQL query
            Dim queryyy As String = "SELECT iname FROM itemadd"

            ' Create a command object
            Dim cmd As New OleDbCommand(queryyy, coonection)

            ' Execute the query and retrieve data using a data reader
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            ' Iterate through the results and add them to the ComboBox
            While reader.Read()
                Combo.Items.Add(reader.GetString(0))
            End While

            ' Close the data reader
            reader.Close()
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            If coonection.State = ConnectionState.Open Then
                coonection.Close()
            End If
        End Try
    End Sub



    Private Sub Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo.SelectedIndexChanged

        coonection.Open()
        Dim query As String = "SELECT * FROM itemadd WHERE iname = @SelectedItem"
        Dim cmd As New OleDbCommand(query, coonection)
        cmd.Parameters.AddWithValue("@SelectedItem", Combo.SelectedItem.ToString())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then

            'Qty.Text = reader.GetString(reader.GetOrdinal(""))
            utprice.Text = reader.GetDecimal(reader.GetOrdinal("sellingpricr"))
        End If
        reader.Close()
        cmd.ExecuteNonQuery()

        ' Dispose of the command object
        cmd.Dispose()
        coonection.Close()

    End Sub


    Private Sub mobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mobile.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub



    Private Sub mobile_TextChanged(sender As Object, e As EventArgs) Handles mobile.TextChanged

    End Sub
    Public Sub calculatee(ByRef a As Integer, ByRef b As Integer)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()

    End Sub

    Private Sub Tax_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select

    End Sub

    Private Sub Tax_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Function cm() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Newcust_Click_1(sender As Object, e As EventArgs) Handles Newcust.Click
        'inno.Text = getinvoice()
        Try
            coonection.Open()
            Dim query = "select * from  datagrid order by invoice desc"
            Dim adapter As OleDbDataAdapter
            Dim cmd = New OleDbCommand(query, coonection)
            adapter = New OleDbDataAdapter(cmd)
            Dim builder = New OleDbCommandBuilder(adapter)
            Dim ds = New DataSet
            adapter.Fill(ds)
            datashow.DataSource = ds.Tables(0)
            coonection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Dim newInvoiceNo As String = GenerateInvoiceNumber()
        inno.Text = newInvoiceNo
        address.Text = ""
        cust.Text = ""
        description.Text = ""
        Discount.Text = ""
        mobile.Text = ""
        Qty.Text = ""
        Tax.Text = ""

        tot1.Text = ""
        tot2.Text = ""
        tot3.Text = ""
        '  display()


    End Sub
    Private Function GenerateInvoiceNumber() As String
        Dim currentDate As String = DateTime.Now.ToString("yyyyMMdd")

        Dim maxInvoiceNo As String = GetMaxInvoiceNumber(currentDate)

        If String.IsNullOrEmpty(maxInvoiceNo) Then
            Return currentDate & "001"
        Else

            Dim numericPart As Integer = Integer.Parse(maxInvoiceNo.Substring(8))
            numericPart += 1

            Dim paddedNumericPart As String = numericPart.ToString().PadLeft(3, "0"c)
            Return currentDate & paddedNumericPart
        End If
    End Function
    Private Function GetMaxInvoiceNumber(datePrefix As String) As String
        Dim query As String = "SELECT MAX(invoiceno) FROM mainform WHERE Invoiceno LIKE @datePrefix"
        Dim cmd As New OleDbCommand(query, coonection)
        cmd.Parameters.AddWithValue("@datePrefix", datePrefix & "%")

        Dim maxInvoiceNo As Object = Nothing

        Try
            coonection.Open()
            maxInvoiceNo = cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            coonection.Close()
        End Try

        If maxInvoiceNo IsNot Nothing AndAlso Not IsDBNull(maxInvoiceNo) Then
            Return maxInvoiceNo.ToString()
        Else
            Return Nothing
        End If
    End Function


    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim Invent As New Inventory()
        Invent.Show()
        Me.Close()
    End Sub
    Private Sub display()
        ' Try
        'coonection.Open()
        ' Dim query = "select * from  datagrid order by Invoice desc"
        'Dim adapter As OleDbDataAdapter
        'Dim cmd = New OleDbCommand(query, abc)
        'adapter = New OleDbDataAdapter(cmd)
        'Dim builder = New OleDb.OleDbCommandBuilder(adapter)
        'Dim ds = New DataSet
        'adapter.Fill(ds)
        'datashow.DataSource = ds.Tables(0)
        Dim query As String = "SELECT * FROM datagrid ORDER BY Invoice DESC"

        ' Create a data adapter and command objects
        Dim adapter As New OleDbDataAdapter(query, coonection)
        Dim builder As New OleDbCommandBuilder(adapter)
        Try

            coonection.Open()


            adapter.Fill(ds)


            datashow.DataSource = ds.Tables(0)
        Catch ex As Exception

            MsgBox("Error: " & ex.Message)
        Finally
            coonection.Close()

        End Try
        ' abc.close()
        'Catch ex As Exception
        '   MsgBox("ex")

        '        End Try
    End Sub

    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click
        address.Text = ""
        cust.Text = ""
        description.Text = ""
        Discount.Text = ""
        mobile.Text = ""
        Qty.Text = ""
        Tax.Text = ""
        Combo.Text = ""
        tot1.Text = ""
        tot2.Text = ""

    End Sub








    Private Sub Receipt_Click(sender As Object, e As EventArgs) Handles Receipt.Click
        Me.Hide()
        '  Receiipt.Show()
    End Sub
    Private Sub UpdateItemQuantity()
        Dim getItemQuery As String = "SELECT quantity FROM itemadd WHERE iname = @ItemName"
        Dim updateQuery As String = "UPDATE itemadd SET quantity = @NewQuantity WHERE iname = @ItemName"
        Dim itemName As String = Combo.SelectedItem
        Dim quantityBought As Integer

        Try
            quantityBought = Convert.ToInt32(Qty.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter a valid quantity.")
            Return
        End Try

        Dim connection As New OleDbConnection("Your connection string here")

        Try
            connection.Open()

            Dim getItemCommand As New OleDbCommand(getItemQuery, connection)
            getItemCommand.Parameters.AddWithValue("@ItemName", itemName)

            Dim currentQuantity As Integer = CInt(getItemCommand.ExecuteScalar())
            Dim newQuantity As Integer = currentQuantity - quantityBought

            Dim updateCommand As New OleDbCommand(updateQuery, connection)
            updateCommand.Parameters.AddWithValue("@NewQuantity", newQuantity)
            updateCommand.Parameters.AddWithValue("@ItemName", itemName)
            updateCommand.ExecuteNonQuery()

            If newQuantity <= 1 Then
                MsgBox(itemName & " has reached 1. Please add items to the inventory.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally

            connection.Close()

        End Try

    End Sub
End Class



