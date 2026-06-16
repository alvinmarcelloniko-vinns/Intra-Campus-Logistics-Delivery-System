<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxasal = New System.Windows.Forms.ComboBox()
        Me.cbxtujuan = New System.Windows.Forms.ComboBox()
        Me.cbxtgl = New System.Windows.Forms.ComboBox()
        Me.cbxbulan = New System.Windows.Forms.ComboBox()
        Me.cbxtahun = New System.Windows.Forms.ComboBox()
        Me.listlayanan = New System.Windows.Forms.ListBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtdiskon = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnpesan = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gedung Asal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(220, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Gedung Tujuan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Layanan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(220, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Diskon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Jumlah"
        '
        'cbxasal
        '
        Me.cbxasal.FormattingEnabled = True
        Me.cbxasal.Items.AddRange(New Object() {"Fransiskus Asisi", "Santa Clara", "Leopold Mandic", "Lorenzo Brindisi", "Padre Pio"})
        Me.cbxasal.Location = New System.Drawing.Point(92, 76)
        Me.cbxasal.Name = "cbxasal"
        Me.cbxasal.Size = New System.Drawing.Size(122, 21)
        Me.cbxasal.TabIndex = 14
        '
        'cbxtujuan
        '
        Me.cbxtujuan.FormattingEnabled = True
        Me.cbxtujuan.Items.AddRange(New Object() {"Fransiskus Asisi", "Santa Clara", "Leopold Mandic", "Lorenzo Brindisi", "Padre Pio"})
        Me.cbxtujuan.Location = New System.Drawing.Point(307, 76)
        Me.cbxtujuan.Name = "cbxtujuan"
        Me.cbxtujuan.Size = New System.Drawing.Size(122, 21)
        Me.cbxtujuan.TabIndex = 15
        '
        'cbxtgl
        '
        Me.cbxtgl.FormattingEnabled = True
        Me.cbxtgl.Location = New System.Drawing.Point(284, 6)
        Me.cbxtgl.Name = "cbxtgl"
        Me.cbxtgl.Size = New System.Drawing.Size(42, 21)
        Me.cbxtgl.TabIndex = 16
        '
        'cbxbulan
        '
        Me.cbxbulan.FormattingEnabled = True
        Me.cbxbulan.Location = New System.Drawing.Point(332, 6)
        Me.cbxbulan.Name = "cbxbulan"
        Me.cbxbulan.Size = New System.Drawing.Size(55, 21)
        Me.cbxbulan.TabIndex = 17
        '
        'cbxtahun
        '
        Me.cbxtahun.FormattingEnabled = True
        Me.cbxtahun.Location = New System.Drawing.Point(393, 6)
        Me.cbxtahun.Name = "cbxtahun"
        Me.cbxtahun.Size = New System.Drawing.Size(74, 21)
        Me.cbxtahun.TabIndex = 18
        '
        'listlayanan
        '
        Me.listlayanan.FormattingEnabled = True
        Me.listlayanan.Items.AddRange(New Object() {"Makanan", "Bunga", "Dokumen"})
        Me.listlayanan.Location = New System.Drawing.Point(71, 120)
        Me.listlayanan.Name = "listlayanan"
        Me.listlayanan.Size = New System.Drawing.Size(124, 108)
        Me.listlayanan.TabIndex = 19
        '
        'txtharga
        '
        Me.txtharga.Enabled = False
        Me.txtharga.Location = New System.Drawing.Point(265, 132)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(138, 20)
        Me.txtharga.TabIndex = 20
        '
        'txtdiskon
        '
        Me.txtdiskon.Enabled = False
        Me.txtdiskon.Location = New System.Drawing.Point(265, 160)
        Me.txtdiskon.Name = "txtdiskon"
        Me.txtdiskon.Size = New System.Drawing.Size(138, 20)
        Me.txtdiskon.TabIndex = 21
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(265, 189)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(138, 20)
        Me.txttotal.TabIndex = 22
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(92, 265)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(65, 20)
        Me.NumericUpDown1.TabIndex = 23
        '
        'btnpesan
        '
        Me.btnpesan.Location = New System.Drawing.Point(168, 326)
        Me.btnpesan.Name = "btnpesan"
        Me.btnpesan.Size = New System.Drawing.Size(75, 23)
        Me.btnpesan.TabIndex = 24
        Me.btnpesan.Text = "PESAN"
        Me.btnpesan.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(265, 326)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 25
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 379)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnpesan)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtdiskon)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.listlayanan)
        Me.Controls.Add(Me.cbxtahun)
        Me.Controls.Add(Me.cbxbulan)
        Me.Controls.Add(Me.cbxtgl)
        Me.Controls.Add(Me.cbxtujuan)
        Me.Controls.Add(Me.cbxasal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxasal As ComboBox
    Friend WithEvents cbxtujuan As ComboBox
    Friend WithEvents cbxtgl As ComboBox
    Friend WithEvents cbxbulan As ComboBox
    Friend WithEvents cbxtahun As ComboBox
    Friend WithEvents listlayanan As ListBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtdiskon As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents btnpesan As Button
    Friend WithEvents btnkeluar As Button
End Class
