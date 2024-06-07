<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class h_beli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(h_beli))
        Me.cb_sup = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.txt_nonota = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_no_ref = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dptanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nama_sup = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_sup
        '
        Me.cb_sup.FormattingEnabled = True
        Me.cb_sup.Location = New System.Drawing.Point(244, 95)
        Me.cb_sup.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_sup.Name = "cb_sup"
        Me.cb_sup.Size = New System.Drawing.Size(316, 24)
        Me.cb_sup.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Kode Supplier"
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(232, 304)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(132, 44)
        Me.btn_simpan.TabIndex = 18
        Me.btn_simpan.Text = "Tambah"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'txt_nonota
        '
        Me.txt_nonota.Location = New System.Drawing.Point(244, 254)
        Me.txt_nonota.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nonota.Name = "txt_nonota"
        Me.txt_nonota.Size = New System.Drawing.Size(316, 22)
        Me.txt_nonota.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "No Referensi"
        '
        'txt_no_ref
        '
        Me.txt_no_ref.Location = New System.Drawing.Point(244, 203)
        Me.txt_no_ref.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_no_ref.Name = "txt_no_ref"
        Me.txt_no_ref.Size = New System.Drawing.Size(316, 22)
        Me.txt_no_ref.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 254)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "No Pembeli"
        '
        'dptanggal
        '
        Me.dptanggal.Location = New System.Drawing.Point(244, 43)
        Me.dptanggal.Margin = New System.Windows.Forms.Padding(4)
        Me.dptanggal.Name = "dptanggal"
        Me.dptanggal.Size = New System.Drawing.Size(316, 22)
        Me.dptanggal.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 149)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nama Supplier"
        '
        'txt_nama_sup
        '
        Me.txt_nama_sup.Location = New System.Drawing.Point(244, 149)
        Me.txt_nama_sup.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nama_sup.Name = "txt_nama_sup"
        Me.txt_nama_sup.Size = New System.Drawing.Size(316, 22)
        Me.txt_nama_sup.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(610, 363)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'h_beli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 363)
        Me.Controls.Add(Me.txt_nama_sup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_sup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_nonota)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_no_ref)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dptanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "h_beli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form beli awal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_sup As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents txt_nonota As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_no_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dptanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nama_sup As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
