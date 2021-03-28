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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnCatch = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCatch
        '
        Me.btnCatch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCatch.Location = New System.Drawing.Point(1127, 142)
        Me.btnCatch.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.btnCatch.Name = "btnCatch"
        Me.btnCatch.Size = New System.Drawing.Size(272, 71)
        Me.btnCatch.TabIndex = 0
        Me.btnCatch.Text = "Catch"
        Me.btnCatch.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(1127, 435)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(272, 85)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1127, 712)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(272, 68)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightCoral
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 137)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 213)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "?"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(418, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 211)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "?"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(770, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 208)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "?"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 407)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 80)
        Me.Label4.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(79, 527)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(998, 398)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1498, 1099)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnCatch)
        Me.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Name = "Form1"
        Me.Text = "My Slot Machine"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCatch As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
