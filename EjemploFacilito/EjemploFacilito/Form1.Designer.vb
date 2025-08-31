<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(120, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(382, 91)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(206, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(382, 136)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(202, 27)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(382, 173)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(202, 27)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(382, 214)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(202, 27)
        TextBox4.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(212, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 5
        Label2.Text = "Registro"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(120, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 20)
        Label3.TabIndex = 6
        Label3.Text = "Apellido"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(120, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 20)
        Label4.TabIndex = 7
        Label4.Text = "Correo Electrónico"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(120, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 20)
        Label5.TabIndex = 8
        Label5.Text = "Teléfono"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 353)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
