<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TimerRed = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBlue = New System.Windows.Forms.Timer(Me.components)
        Me.TimerGreen = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape3, Me.OvalShape2, Me.OvalShape1, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(876, 507)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape3
        '
        Me.OvalShape3.BackColor = System.Drawing.Color.Green
        Me.OvalShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape3.Location = New System.Drawing.Point(28, 252)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(70, 72)
        '
        'OvalShape2
        '
        Me.OvalShape2.BackColor = System.Drawing.Color.MediumBlue
        Me.OvalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape2.FillColor = System.Drawing.Color.MediumBlue
        Me.OvalShape2.Location = New System.Drawing.Point(29, 157)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(70, 72)
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.Red
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.FillColor = System.Drawing.Color.Red
        Me.OvalShape1.FillGradientColor = System.Drawing.Color.Transparent
        Me.OvalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape1.Location = New System.Drawing.Point(29, 66)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(70, 72)
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 52
        Me.LineShape3.X2 = 742
        Me.LineShape3.Y1 = 324
        Me.LineShape3.Y2 = 324
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 52
        Me.LineShape2.X2 = 743
        Me.LineShape2.Y1 = 229
        Me.LineShape2.Y2 = 230
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 51
        Me.LineShape1.X2 = 740
        Me.LineShape1.Y1 = 138
        Me.LineShape1.Y2 = 141
        '
        'TimerRed
        '
        '
        'TimerBlue
        '
        '
        'TimerGreen
        '
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Location = New System.Drawing.Point(33, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Play"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 507)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents OvalShape3 As PowerPacks.OvalShape
    Friend WithEvents OvalShape2 As PowerPacks.OvalShape
    Friend WithEvents OvalShape1 As PowerPacks.OvalShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents TimerRed As Timer
    Friend WithEvents TimerBlue As Timer
    Friend WithEvents TimerGreen As Timer
    Friend WithEvents Button1 As Button
End Class
