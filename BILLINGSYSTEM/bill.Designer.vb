<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bill
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.inno = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mobile = New System.Windows.Forms.TextBox()
        Me.cust = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.utprice = New System.Windows.Forms.Label()
        Me.Combo = New System.Windows.Forms.ComboBox()
        Me.clr = New System.Windows.Forms.Button()
        Me.tot3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Tax = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tot2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tot1 = New System.Windows.Forms.Label()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.Discount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Qty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.description = New System.Windows.Forms.TextBox()
        Me.datashow = New System.Windows.Forms.DataGridView()
        Me.Receipt = New System.Windows.Forms.Button()
        Me.Newcust = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datashow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1358, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(40, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(228, 47)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Billing Form"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._error
        Me.PictureBox1.Location = New System.Drawing.Point(1309, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.inno)
        Me.GroupBox1.Controls.Add(Me.PictureBox6)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.address)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.mobile)
        Me.GroupBox1.Controls.Add(Me.cust)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1319, 156)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'inno
        '
        Me.inno.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.inno.Location = New System.Drawing.Point(805, 24)
        Me.inno.Name = "inno"
        Me.inno.Size = New System.Drawing.Size(321, 32)
        Me.inno.TabIndex = 15
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.WindowsApplication1.My.Resources.Resources.receipt
        Me.PictureBox6.Location = New System.Drawing.Point(747, 24)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 14
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.WindowsApplication1.My.Resources.Resources.july
        Me.PictureBox5.Location = New System.Drawing.Point(750, 65)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources.user
        Me.PictureBox4.Location = New System.Drawing.Point(142, 22)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.address
        Me.PictureBox3.Location = New System.Drawing.Point(142, 60)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.phone_call
        Me.PictureBox2.Location = New System.Drawing.Point(142, 105)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.address.Location = New System.Drawing.Point(182, 61)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(406, 32)
        Me.address.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bill To "
        '
        'mobile
        '
        Me.mobile.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.mobile.Location = New System.Drawing.Point(181, 105)
        Me.mobile.Name = "mobile"
        Me.mobile.Size = New System.Drawing.Size(406, 32)
        Me.mobile.TabIndex = 10
        '
        'cust
        '
        Me.cust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cust.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.cust.Location = New System.Drawing.Point(183, 21)
        Me.cust.Name = "cust"
        Me.cust.Size = New System.Drawing.Size(406, 32)
        Me.cust.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(33, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Mobile No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(30, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Address"
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.dt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt.Location = New System.Drawing.Point(805, 63)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(321, 32)
        Me.dt.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(622, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Invoice No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(673, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.utprice)
        Me.GroupBox2.Controls.Add(Me.Combo)
        Me.GroupBox2.Controls.Add(Me.clr)
        Me.GroupBox2.Controls.Add(Me.tot3)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Tax)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tot2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tot1)
        Me.GroupBox2.Controls.Add(Me.addbtn)
        Me.GroupBox2.Controls.Add(Me.Discount)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Qty)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.description)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1319, 232)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(19, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(129, 23)
        Me.Label19.TabIndex = 50
        Me.Label19.Text = "Select Items"
        '
        'utprice
        '
        Me.utprice.AutoSize = True
        Me.utprice.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.utprice.Location = New System.Drawing.Point(530, 59)
        Me.utprice.Name = "utprice"
        Me.utprice.Size = New System.Drawing.Size(0, 23)
        Me.utprice.TabIndex = 49
        '
        'Combo
        '
        Me.Combo.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Combo.FormattingEnabled = True
        Me.Combo.Location = New System.Drawing.Point(19, 53)
        Me.Combo.Name = "Combo"
        Me.Combo.Size = New System.Drawing.Size(264, 31)
        Me.Combo.TabIndex = 48
        '
        'clr
        '
        Me.clr.BackColor = System.Drawing.SystemColors.Window
        Me.clr.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold)
        Me.clr.ForeColor = System.Drawing.Color.Black
        Me.clr.Location = New System.Drawing.Point(1142, 112)
        Me.clr.Name = "clr"
        Me.clr.Size = New System.Drawing.Size(146, 58)
        Me.clr.TabIndex = 47
        Me.clr.Text = "Clear"
        Me.clr.UseVisualStyleBackColor = False
        '
        'tot3
        '
        Me.tot3.AutoSize = True
        Me.tot3.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tot3.Location = New System.Drawing.Point(897, 150)
        Me.tot3.Name = "tot3"
        Me.tot3.Size = New System.Drawing.Size(71, 34)
        Me.tot3.TabIndex = 46
        Me.tot3.Text = "0.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(792, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 28)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "TOTAL"
        '
        'Tax
        '
        Me.Tax.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tax.Location = New System.Drawing.Point(1008, 55)
        Me.Tax.Name = "Tax"
        Me.Tax.Size = New System.Drawing.Size(99, 32)
        Me.Tax.TabIndex = 44
        Me.Tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(993, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 23)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Tax Rate(%)"
        '
        'tot2
        '
        Me.tot2.AutoSize = True
        Me.tot2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.tot2.Location = New System.Drawing.Point(924, 55)
        Me.tot2.Name = "tot2"
        Me.tot2.Size = New System.Drawing.Size(0, 23)
        Me.tot2.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(872, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 23)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Sub Total"
        '
        'tot1
        '
        Me.tot1.AutoSize = True
        Me.tot1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.tot1.Location = New System.Drawing.Point(683, 56)
        Me.tot1.Name = "tot1"
        Me.tot1.Size = New System.Drawing.Size(0, 23)
        Me.tot1.TabIndex = 17
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.SystemColors.Window
        Me.addbtn.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.Black
        Me.addbtn.Location = New System.Drawing.Point(1142, 29)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(146, 58)
        Me.addbtn.TabIndex = 16
        Me.addbtn.Text = "Add "
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'Discount
        '
        Me.Discount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Discount.Location = New System.Drawing.Point(750, 55)
        Me.Discount.Name = "Discount"
        Me.Discount.Size = New System.Drawing.Size(93, 32)
        Me.Discount.TabIndex = 14
        Me.Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(657, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 23)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Total"
        '
        'Qty
        '
        Me.Qty.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Qty.Location = New System.Drawing.Point(331, 52)
        Me.Qty.Name = "Qty"
        Me.Qty.Size = New System.Drawing.Size(101, 32)
        Me.Qty.TabIndex = 8
        Me.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(749, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 23)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Discount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(481, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Unit Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(330, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 23)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(15, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Description(Optional)"
        '
        'description
        '
        Me.description.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.description.Location = New System.Drawing.Point(19, 159)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(665, 32)
        Me.description.TabIndex = 4
        '
        'datashow
        '
        Me.datashow.AllowUserToAddRows = False
        Me.datashow.BackgroundColor = System.Drawing.SystemColors.Window
        Me.datashow.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datashow.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datashow.ColumnHeadersHeight = 30
        Me.datashow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datashow.EnableHeadersVisualStyles = False
        Me.datashow.GridColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.datashow.Location = New System.Drawing.Point(244, 508)
        Me.datashow.Name = "datashow"
        Me.datashow.RowHeadersVisible = False
        Me.datashow.RowTemplate.Height = 24
        Me.datashow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datashow.Size = New System.Drawing.Size(811, 170)
        Me.datashow.TabIndex = 31
        '
        'Receipt
        '
        Me.Receipt.BackColor = System.Drawing.SystemColors.Window
        Me.Receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Receipt.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Receipt.ForeColor = System.Drawing.Color.Black
        Me.Receipt.Location = New System.Drawing.Point(1190, 543)
        Me.Receipt.Name = "Receipt"
        Me.Receipt.Size = New System.Drawing.Size(141, 40)
        Me.Receipt.TabIndex = 33
        Me.Receipt.Text = "Receipt"
        Me.Receipt.UseVisualStyleBackColor = False
        '
        'Newcust
        '
        Me.Newcust.BackColor = System.Drawing.SystemColors.Window
        Me.Newcust.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Newcust.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Newcust.ForeColor = System.Drawing.Color.Black
        Me.Newcust.Location = New System.Drawing.Point(1190, 609)
        Me.Newcust.Name = "Newcust"
        Me.Newcust.Size = New System.Drawing.Size(141, 45)
        Me.Newcust.TabIndex = 32
        Me.Newcust.Text = "New Bill"
        Me.Newcust.UseVisualStyleBackColor = False
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.SystemColors.Window
        Me.Back.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Back.ForeColor = System.Drawing.Color.Black
        Me.Back.Location = New System.Drawing.Point(20, 648)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(118, 40)
        Me.Back.TabIndex = 34
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1359, 700)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Receipt)
        Me.Controls.Add(Me.Newcust)
        Me.Controls.Add(Me.datashow)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainform"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datashow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents inno As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents address As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mobile As System.Windows.Forms.TextBox
    Friend WithEvents cust As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents utprice As System.Windows.Forms.Label
    Friend WithEvents Combo As System.Windows.Forms.ComboBox
    Friend WithEvents clr As System.Windows.Forms.Button
    Friend WithEvents tot3 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Tax As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tot2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tot1 As System.Windows.Forms.Label
    Friend WithEvents addbtn As System.Windows.Forms.Button
    Friend WithEvents Discount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Qty As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents description As System.Windows.Forms.TextBox
    Friend WithEvents datashow As System.Windows.Forms.DataGridView
    Friend WithEvents Receipt As System.Windows.Forms.Button
    Friend WithEvents Newcust As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
