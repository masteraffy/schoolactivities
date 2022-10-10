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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.rbPermanent = New System.Windows.Forms.RadioButton()
        Me.cbSSS = New System.Windows.Forms.CheckBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbContractual = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbPhilhealth = New System.Windows.Forms.CheckBox()
        Me.cbPagibig = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHrsWorked = New System.Windows.Forms.TextBox()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rate:"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(130, 41)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 1
        '
        'rbPermanent
        '
        Me.rbPermanent.AutoSize = True
        Me.rbPermanent.Checked = True
        Me.rbPermanent.Location = New System.Drawing.Point(39, 27)
        Me.rbPermanent.Name = "rbPermanent"
        Me.rbPermanent.Size = New System.Drawing.Size(76, 17)
        Me.rbPermanent.TabIndex = 2
        Me.rbPermanent.TabStop = True
        Me.rbPermanent.Text = "Permanent"
        Me.rbPermanent.UseVisualStyleBackColor = True
        '
        'cbSSS
        '
        Me.cbSSS.AutoSize = True
        Me.cbSSS.Location = New System.Drawing.Point(39, 19)
        Me.cbSSS.Name = "cbSSS"
        Me.cbSSS.Size = New System.Drawing.Size(47, 17)
        Me.cbSSS.TabIndex = 3
        Me.cbSSS.Text = "SSS"
        Me.cbSSS.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(41, 366)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbContractual)
        Me.GroupBox1.Controls.Add(Me.rbPermanent)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'rbContractual
        '
        Me.rbContractual.AutoSize = True
        Me.rbContractual.Location = New System.Drawing.Point(39, 50)
        Me.rbContractual.Name = "rbContractual"
        Me.rbContractual.Size = New System.Drawing.Size(79, 17)
        Me.rbContractual.TabIndex = 2
        Me.rbContractual.Text = "Contractual"
        Me.rbContractual.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbPhilhealth)
        Me.GroupBox2.Controls.Add(Me.cbPagibig)
        Me.GroupBox2.Controls.Add(Me.cbSSS)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deductions"
        '
        'cbPhilhealth
        '
        Me.cbPhilhealth.AutoSize = True
        Me.cbPhilhealth.Location = New System.Drawing.Point(39, 65)
        Me.cbPhilhealth.Name = "cbPhilhealth"
        Me.cbPhilhealth.Size = New System.Drawing.Size(72, 17)
        Me.cbPhilhealth.TabIndex = 3
        Me.cbPhilhealth.Text = "Philhealth"
        Me.cbPhilhealth.UseVisualStyleBackColor = True
        '
        'cbPagibig
        '
        Me.cbPagibig.AutoSize = True
        Me.cbPagibig.Location = New System.Drawing.Point(39, 42)
        Me.cbPagibig.Name = "cbPagibig"
        Me.cbPagibig.Size = New System.Drawing.Size(61, 17)
        Me.cbPagibig.TabIndex = 3
        Me.cbPagibig.Text = "Pagibig"
        Me.cbPagibig.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(130, 366)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No of hours worked:"
        '
        'txtHrsWorked
        '
        Me.txtHrsWorked.Location = New System.Drawing.Point(130, 69)
        Me.txtHrsWorked.Name = "txtHrsWorked"
        Me.txtHrsWorked.Size = New System.Drawing.Size(100, 20)
        Me.txtHrsWorked.TabIndex = 1
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 418)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtHrsWorked)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Midterm Activity 2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents rbPermanent As RadioButton
    Friend WithEvents cbSSS As CheckBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbContractual As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbPhilhealth As CheckBox
    Friend WithEvents cbPagibig As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHrsWorked As TextBox
    Friend WithEvents errorProvider As ErrorProvider
End Class
