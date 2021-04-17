<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class suname
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(suname))
        Me.sin = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.entr = New System.Windows.Forms.Button()
        Me.showp = New System.Windows.Forms.Button()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.sinname = New System.Windows.Forms.TextBox()
        Me.sin1 = New System.Windows.Forms.Button()
        Me.sup = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.supname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.suppass1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.suppass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.sup1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.sin.SuspendLayout()
        Me.sup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sin
        '
        Me.sin.BackColor = System.Drawing.Color.Turquoise
        Me.sin.Controls.Add(Me.Label12)
        Me.sin.Controls.Add(Me.Label8)
        Me.sin.Controls.Add(Me.Label2)
        Me.sin.Controls.Add(Me.Label1)
        Me.sin.Controls.Add(Me.entr)
        Me.sin.Controls.Add(Me.showp)
        Me.sin.Controls.Add(Me.pass)
        Me.sin.Controls.Add(Me.sinname)
        Me.sin.Location = New System.Drawing.Point(41, 346)
        Me.sin.Name = "sin"
        Me.sin.Size = New System.Drawing.Size(382, 259)
        Me.sin.TabIndex = 0
        Me.sin.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(143, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 20)
        Me.Label12.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(237, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Forget Password?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name"
        '
        'entr
        '
        Me.entr.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.entr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entr.Location = New System.Drawing.Point(135, 183)
        Me.entr.Name = "entr"
        Me.entr.Size = New System.Drawing.Size(125, 38)
        Me.entr.TabIndex = 7
        Me.entr.Text = "Get-In"
        Me.entr.UseVisualStyleBackColor = False
        '
        'showp
        '
        Me.showp.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.showp.Location = New System.Drawing.Point(324, 110)
        Me.showp.Name = "showp"
        Me.showp.Size = New System.Drawing.Size(40, 26)
        Me.showp.TabIndex = 6
        Me.showp.Text = "show"
        Me.showp.UseVisualStyleBackColor = False
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.Location = New System.Drawing.Point(98, 110)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(231, 26)
        Me.pass.TabIndex = 5
        Me.pass.UseSystemPasswordChar = True
        '
        'sinname
        '
        Me.sinname.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.sinname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinname.Location = New System.Drawing.Point(98, 62)
        Me.sinname.Name = "sinname"
        Me.sinname.Size = New System.Drawing.Size(266, 26)
        Me.sinname.TabIndex = 4
        '
        'sin1
        '
        Me.sin1.BackColor = System.Drawing.Color.Teal
        Me.sin1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sin1.Location = New System.Drawing.Point(375, 204)
        Me.sin1.Name = "sin1"
        Me.sin1.Size = New System.Drawing.Size(125, 38)
        Me.sin1.TabIndex = 2
        Me.sin1.Text = "Sign-In"
        Me.sin1.UseVisualStyleBackColor = False
        '
        'sup
        '
        Me.sup.BackColor = System.Drawing.Color.Teal
        Me.sup.Controls.Add(Me.Label7)
        Me.sup.Controls.Add(Me.GroupBox1)
        Me.sup.Controls.Add(Me.supname)
        Me.sup.Controls.Add(Me.Label6)
        Me.sup.Controls.Add(Me.TextBox2)
        Me.sup.Controls.Add(Me.Label5)
        Me.sup.Controls.Add(Me.suppass1)
        Me.sup.Controls.Add(Me.Label3)
        Me.sup.Controls.Add(Me.suppass)
        Me.sup.Controls.Add(Me.Button1)
        Me.sup.Controls.Add(Me.Button2)
        Me.sup.Location = New System.Drawing.Point(375, 248)
        Me.sup.Name = "sup"
        Me.sup.Size = New System.Drawing.Size(382, 259)
        Me.sup.TabIndex = 1
        Me.sup.TabStop = False
        Me.sup.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Name"
        '
        'supname
        '
        Me.supname.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.supname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supname.Location = New System.Drawing.Point(103, 59)
        Me.supname.Name = "supname"
        Me.supname.Size = New System.Drawing.Size(266, 26)
        Me.supname.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Sec Qes"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(103, 183)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(231, 22)
        Me.TextBox2.TabIndex = 18
        Me.TextBox2.Text = "Enter your favorite no"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Comfirm"
        '
        'suppass1
        '
        Me.suppass1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.suppass1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suppass1.Location = New System.Drawing.Point(103, 137)
        Me.suppass1.Name = "suppass1"
        Me.suppass1.Size = New System.Drawing.Size(231, 26)
        Me.suppass1.TabIndex = 16
        Me.suppass1.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Password"
        '
        'suppass
        '
        Me.suppass.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.suppass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suppass.Location = New System.Drawing.Point(103, 98)
        Me.suppass.Name = "suppass"
        Me.suppass.Size = New System.Drawing.Size(231, 26)
        Me.suppass.TabIndex = 11
        Me.suppass.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(147, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 38)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Get-In"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button2.Location = New System.Drawing.Point(340, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 26)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "show"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Turquoise
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(234, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 259)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(73, 9)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 44)
        Me.DataGridView1.TabIndex = 11
        Me.DataGridView1.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Red
        Me.Button5.Location = New System.Drawing.Point(350, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 26)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "X"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(237, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Forget Password?"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Sec Qes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Name"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(135, 183)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 38)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Get-Pass"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button4.Location = New System.Drawing.Point(324, 110)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 26)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "show"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(98, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(231, 26)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(98, 62)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(266, 26)
        Me.TextBox3.TabIndex = 4
        '
        'sup1
        '
        Me.sup1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.sup1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sup1.Location = New System.Drawing.Point(634, 204)
        Me.sup1.Name = "sup1"
        Me.sup1.Size = New System.Drawing.Size(125, 38)
        Me.sup1.TabIndex = 3
        Me.sup1.Text = "Sign-Up"
        Me.sup1.UseVisualStyleBackColor = False
        '
        'suname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1132, 749)
        Me.Controls.Add(Me.sin)
        Me.Controls.Add(Me.sin1)
        Me.Controls.Add(Me.sup1)
        Me.Controls.Add(Me.sup)
        Me.DoubleBuffered = True
        Me.Name = "suname"
        Me.Text = "Name"
        Me.sin.ResumeLayout(False)
        Me.sin.PerformLayout()
        Me.sup.ResumeLayout(False)
        Me.sup.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sin As GroupBox
    Friend WithEvents sup As GroupBox
    Friend WithEvents sin1 As Button
    Friend WithEvents sup1 As Button
    Friend WithEvents pass As TextBox
    Friend WithEvents sinname As TextBox
    Friend WithEvents showp As Button
    Friend WithEvents entr As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents suppass1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents suppass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents supname As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
End Class
