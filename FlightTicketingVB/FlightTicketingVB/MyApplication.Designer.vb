<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyApplication
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbIn_TwoWay = New System.Windows.Forms.RadioButton()
        Me.rbIn_OneWay = New System.Windows.Forms.RadioButton()
        Me.txtIn_seatNo = New System.Windows.Forms.TextBox()
        Me.cmbIn_seatCode = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtO_tax = New System.Windows.Forms.TextBox()
        Me.txtO_totalFare = New System.Windows.Forms.TextBox()
        Me.txtO_seatFare = New System.Windows.Forms.TextBox()
        Me.txtO_grossFare = New System.Windows.Forms.TextBox()
        Me.txtO_classification = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbIn_TwoWay)
        Me.GroupBox1.Controls.Add(Me.rbIn_OneWay)
        Me.GroupBox1.Controls.Add(Me.txtIn_seatNo)
        Me.GroupBox1.Controls.Add(Me.cmbIn_seatCode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 178)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(65, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Trip:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No of Seats"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seat Code"
        '
        'rbIn_TwoWay
        '
        Me.rbIn_TwoWay.AutoSize = True
        Me.rbIn_TwoWay.Location = New System.Drawing.Point(104, 155)
        Me.rbIn_TwoWay.Name = "rbIn_TwoWay"
        Me.rbIn_TwoWay.Size = New System.Drawing.Size(71, 17)
        Me.rbIn_TwoWay.TabIndex = 2
        Me.rbIn_TwoWay.Text = "Two Way"
        Me.rbIn_TwoWay.UseVisualStyleBackColor = True
        '
        'rbIn_OneWay
        '
        Me.rbIn_OneWay.AutoSize = True
        Me.rbIn_OneWay.Checked = True
        Me.rbIn_OneWay.Location = New System.Drawing.Point(104, 132)
        Me.rbIn_OneWay.Name = "rbIn_OneWay"
        Me.rbIn_OneWay.Size = New System.Drawing.Size(70, 17)
        Me.rbIn_OneWay.TabIndex = 2
        Me.rbIn_OneWay.TabStop = True
        Me.rbIn_OneWay.Text = "One Way"
        Me.rbIn_OneWay.UseVisualStyleBackColor = True
        '
        'txtIn_seatNo
        '
        Me.txtIn_seatNo.Location = New System.Drawing.Point(16, 81)
        Me.txtIn_seatNo.Name = "txtIn_seatNo"
        Me.txtIn_seatNo.Size = New System.Drawing.Size(285, 20)
        Me.txtIn_seatNo.TabIndex = 1
        '
        'cmbIn_seatCode
        '
        Me.cmbIn_seatCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIn_seatCode.FormattingEnabled = True
        Me.cmbIn_seatCode.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cmbIn_seatCode.Location = New System.Drawing.Point(16, 41)
        Me.cmbIn_seatCode.Name = "cmbIn_seatCode"
        Me.cmbIn_seatCode.Size = New System.Drawing.Size(285, 21)
        Me.cmbIn_seatCode.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtO_tax)
        Me.GroupBox2.Controls.Add(Me.txtO_totalFare)
        Me.GroupBox2.Controls.Add(Me.txtO_seatFare)
        Me.GroupBox2.Controls.Add(Me.txtO_grossFare)
        Me.GroupBox2.Controls.Add(Me.txtO_classification)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 221)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 192)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(189, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Total Fare"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(189, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Gross Fare"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Seat Fare"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Seat Code"
        '
        'txtO_tax
        '
        Me.txtO_tax.Enabled = False
        Me.txtO_tax.Location = New System.Drawing.Point(192, 98)
        Me.txtO_tax.Name = "txtO_tax"
        Me.txtO_tax.Size = New System.Drawing.Size(100, 20)
        Me.txtO_tax.TabIndex = 1
        '
        'txtO_totalFare
        '
        Me.txtO_totalFare.Enabled = False
        Me.txtO_totalFare.Location = New System.Drawing.Point(192, 154)
        Me.txtO_totalFare.Name = "txtO_totalFare"
        Me.txtO_totalFare.Size = New System.Drawing.Size(100, 20)
        Me.txtO_totalFare.TabIndex = 1
        '
        'txtO_seatFare
        '
        Me.txtO_seatFare.Enabled = False
        Me.txtO_seatFare.Location = New System.Drawing.Point(16, 98)
        Me.txtO_seatFare.Name = "txtO_seatFare"
        Me.txtO_seatFare.Size = New System.Drawing.Size(100, 20)
        Me.txtO_seatFare.TabIndex = 1
        '
        'txtO_grossFare
        '
        Me.txtO_grossFare.Enabled = False
        Me.txtO_grossFare.Location = New System.Drawing.Point(192, 45)
        Me.txtO_grossFare.Name = "txtO_grossFare"
        Me.txtO_grossFare.Size = New System.Drawing.Size(100, 20)
        Me.txtO_grossFare.TabIndex = 1
        '
        'txtO_classification
        '
        Me.txtO_classification.Enabled = False
        Me.txtO_classification.Location = New System.Drawing.Point(16, 45)
        Me.txtO_classification.Name = "txtO_classification"
        Me.txtO_classification.Size = New System.Drawing.Size(100, 20)
        Me.txtO_classification.TabIndex = 1
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(89, 437)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(183, 437)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'MyApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 489)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MyApplication"
        Me.Text = "MyApplication"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbIn_TwoWay As RadioButton
    Friend WithEvents rbIn_OneWay As RadioButton
    Friend WithEvents txtIn_seatNo As TextBox
    Friend WithEvents cmbIn_seatCode As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtO_tax As TextBox
    Friend WithEvents txtO_totalFare As TextBox
    Friend WithEvents txtO_seatFare As TextBox
    Friend WithEvents txtO_grossFare As TextBox
    Friend WithEvents txtO_classification As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents errorProvider As ErrorProvider
End Class
