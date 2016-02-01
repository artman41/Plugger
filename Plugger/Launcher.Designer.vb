<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.PluggerMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenPluginsFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadPluginsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisablePluginsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshPluginListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadPluginListToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.CreateAPluginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutArtmanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PluginList = New System.Windows.Forms.CheckedListBox()
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PluginDescription = New System.Windows.Forms.RichTextBox()
        Me.PluggerMenu.SuspendLayout()
        Me.TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PluggerMenu
        '
        Me.PluggerMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.PluggerMenu.Location = New System.Drawing.Point(0, 0)
        Me.PluggerMenu.Name = "PluggerMenu"
        Me.PluggerMenu.Size = New System.Drawing.Size(290, 24)
        Me.PluggerMenu.TabIndex = 1
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenPluginsFolderToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'OpenPluginsFolderToolStripMenuItem
        '
        Me.OpenPluginsFolderToolStripMenuItem.Name = "OpenPluginsFolderToolStripMenuItem"
        Me.OpenPluginsFolderToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.OpenPluginsFolderToolStripMenuItem.Text = "Open Plugins Folder"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadPluginsToolStripMenuItem, Me.DisablePluginsToolStripMenuItem, Me.ToolStripMenuItem1, Me.RefreshPluginListToolStripMenuItem, Me.ReloadPluginListToolStripMenuItem, Me.CreateAPluginToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.HelpToolStripMenuItem.Text = "Plugins"
        '
        'ReloadPluginsToolStripMenuItem
        '
        Me.ReloadPluginsToolStripMenuItem.Name = "ReloadPluginsToolStripMenuItem"
        Me.ReloadPluginsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ReloadPluginsToolStripMenuItem.Text = "Reload Plugins"
        '
        'DisablePluginsToolStripMenuItem
        '
        Me.DisablePluginsToolStripMenuItem.Name = "DisablePluginsToolStripMenuItem"
        Me.DisablePluginsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DisablePluginsToolStripMenuItem.Text = "Disable Plugins"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 6)
        '
        'RefreshPluginListToolStripMenuItem
        '
        Me.RefreshPluginListToolStripMenuItem.Name = "RefreshPluginListToolStripMenuItem"
        Me.RefreshPluginListToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RefreshPluginListToolStripMenuItem.Text = "Refresh Plugin List"
        '
        'ReloadPluginListToolStripMenuItem
        '
        Me.ReloadPluginListToolStripMenuItem.Name = "ReloadPluginListToolStripMenuItem"
        Me.ReloadPluginListToolStripMenuItem.Size = New System.Drawing.Size(168, 6)
        '
        'CreateAPluginToolStripMenuItem
        '
        Me.CreateAPluginToolStripMenuItem.Name = "CreateAPluginToolStripMenuItem"
        Me.CreateAPluginToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CreateAPluginToolStripMenuItem.Text = "Create a Plugin"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.ToolStripMenuItem2, Me.AboutArtmanToolStripMenuItem})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewHelpToolStripMenuItem.Text = "Instructions"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'AboutArtmanToolStripMenuItem
        '
        Me.AboutArtmanToolStripMenuItem.Name = "AboutArtmanToolStripMenuItem"
        Me.AboutArtmanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutArtmanToolStripMenuItem.Text = "About artman"
        '
        'PluginList
        '
        Me.PluginList.FormattingEnabled = True
        Me.PluginList.Location = New System.Drawing.Point(3, 3)
        Me.PluginList.Name = "PluginList"
        Me.PluginList.Size = New System.Drawing.Size(118, 139)
        Me.PluginList.TabIndex = 2
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel.Controls.Add(Me.PluginDescription, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.PluginList, 0, 0)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(12, 27)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 1
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(258, 152)
        Me.TableLayoutPanel.TabIndex = 3
        '
        'PluginDescription
        '
        Me.PluginDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PluginDescription.Location = New System.Drawing.Point(127, 3)
        Me.PluginDescription.Name = "PluginDescription"
        Me.PluginDescription.ReadOnly = True
        Me.PluginDescription.Size = New System.Drawing.Size(128, 139)
        Me.PluginDescription.TabIndex = 3
        Me.PluginDescription.Text = ""
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 191)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Controls.Add(Me.PluggerMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.PluggerMenu
        Me.Name = "Main"
        Me.Text = "Plugger"
        Me.PluggerMenu.ResumeLayout(False)
        Me.PluggerMenu.PerformLayout()
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PluggerMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PluginList As System.Windows.Forms.CheckedListBox
    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PluginDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadPluginsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisablePluginsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshPluginListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadPluginListToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutArtmanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenPluginsFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateAPluginToolStripMenuItem As ToolStripMenuItem
End Class
