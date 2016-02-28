<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Creator
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
        Me.PluginName = New System.Windows.Forms.TextBox()
        Me.FindFiles = New System.Windows.Forms.Button()
        Me.PluginDescription = New System.Windows.Forms.TextBox()
        Me.SavePlugin = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FileHolder = New System.Windows.Forms.Panel()
        Me.AddFiles = New System.Windows.Forms.OpenFileDialog()
        Me.rButtonContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rButtonContext.SuspendLayout()
        Me.SuspendLayout()
        '
        'PluginName
        '
        Me.PluginName.Location = New System.Drawing.Point(12, 12)
        Me.PluginName.Name = "PluginName"
        Me.PluginName.Size = New System.Drawing.Size(118, 20)
        Me.PluginName.TabIndex = 1
        Me.PluginName.Text = "NAME"
        Me.ToolTip1.SetToolTip(Me.PluginName, "Type in the name of your plugin here")
        '
        'FindFiles
        '
        Me.FindFiles.Location = New System.Drawing.Point(248, 77)
        Me.FindFiles.Name = "FindFiles"
        Me.FindFiles.Size = New System.Drawing.Size(75, 24)
        Me.FindFiles.TabIndex = 2
        Me.FindFiles.Text = "Browse"
        Me.FindFiles.UseVisualStyleBackColor = True
        '
        'PluginDescription
        '
        Me.PluginDescription.Location = New System.Drawing.Point(12, 39)
        Me.PluginDescription.Name = "PluginDescription"
        Me.PluginDescription.Size = New System.Drawing.Size(316, 20)
        Me.PluginDescription.TabIndex = 5
        Me.PluginDescription.Text = "DESCRIPTION"
        '
        'SavePlugin
        '
        Me.SavePlugin.Location = New System.Drawing.Point(141, 9)
        Me.SavePlugin.Name = "SavePlugin"
        Me.SavePlugin.Size = New System.Drawing.Size(187, 24)
        Me.SavePlugin.TabIndex = 4
        Me.SavePlugin.Text = "Save Plugin"
        Me.SavePlugin.UseVisualStyleBackColor = True
        '
        'FileHolder
        '
        Me.FileHolder.AutoScroll = True
        Me.FileHolder.Location = New System.Drawing.Point(12, 77)
        Me.FileHolder.Name = "FileHolder"
        Me.FileHolder.Size = New System.Drawing.Size(230, 145)
        Me.FileHolder.TabIndex = 6
        '
        'AddFiles
        '
        Me.AddFiles.Multiselect = True
        Me.AddFiles.SupportMultiDottedExtensions = True
        Me.AddFiles.ValidateNames = False
        '
        'rButtonContext
        '
        Me.rButtonContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteItemToolStripMenuItem})
        Me.rButtonContext.Name = "rButtonContext"
        Me.rButtonContext.Size = New System.Drawing.Size(135, 26)
        '
        'DeleteItemToolStripMenuItem
        '
        Me.DeleteItemToolStripMenuItem.Name = "DeleteItemToolStripMenuItem"
        Me.DeleteItemToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DeleteItemToolStripMenuItem.Text = "Delete Item"
        '
        'Creator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 234)
        Me.Controls.Add(Me.FileHolder)
        Me.Controls.Add(Me.PluginDescription)
        Me.Controls.Add(Me.SavePlugin)
        Me.Controls.Add(Me.FindFiles)
        Me.Controls.Add(Me.PluginName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Creator"
        Me.Text = "Plugin Creator"
        Me.rButtonContext.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PluginName As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents FindFiles As Button
    Friend WithEvents PluginDescription As TextBox
    Friend WithEvents SavePlugin As Button
    Friend WithEvents FileHolder As Panel
    Friend WithEvents AddFiles As OpenFileDialog
    Friend WithEvents rButtonContext As ContextMenuStrip
    Friend WithEvents DeleteItemToolStripMenuItem As ToolStripMenuItem
End Class
