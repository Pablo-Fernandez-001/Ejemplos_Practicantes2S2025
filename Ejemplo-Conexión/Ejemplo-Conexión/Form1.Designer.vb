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
        btnLoad = New Button()
        btnInsert = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        DataGridView1 = New DataGridView()
        txtTitle = New TextBox()
        btnSaveChanges = New Button()
        chkDone = New CheckBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLoad
        ' 
        btnLoad.Location = New Point(42, 351)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(94, 29)
        btnLoad.TabIndex = 0
        btnLoad.Text = "Load"
        btnLoad.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(142, 351)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(94, 29)
        btnInsert.TabIndex = 1
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(242, 351)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(342, 351)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(42, 94)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(710, 234)
        DataGridView1.TabIndex = 4
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(45, 38)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(354, 27)
        txtTitle.TabIndex = 5
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.Location = New Point(581, 351)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(171, 29)
        btnSaveChanges.TabIndex = 6
        btnSaveChanges.Text = "Save Changes"
        btnSaveChanges.UseVisualStyleBackColor = True
        ' 
        ' chkDone
        ' 
        chkDone.AutoSize = True
        chkDone.Location = New Point(468, 40)
        chkDone.Name = "chkDone"
        chkDone.Size = New Size(67, 24)
        chkDone.TabIndex = 7
        chkDone.Text = "Done"
        chkDone.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(chkDone)
        Controls.Add(btnSaveChanges)
        Controls.Add(txtTitle)
        Controls.Add(DataGridView1)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnInsert)
        Controls.Add(btnLoad)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLoad As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents chkDone As CheckBox

End Class
