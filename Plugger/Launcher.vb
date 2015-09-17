Public Class Main
    Dim Func As New MainFunctions
    Dim ref As New References

    Private Function initialize() As Boolean
        IO.Directory.CreateDirectory(ref.PluginsDir) ' To make sure that the plugins folder exists
<<<<<<< HEAD
        IO.Directory.CreateDirectory(ref.TempDir) ' To make sure that the plugins folder exists
=======
>>>>>>> origin/master

        PluginList.DisplayMember = "Text"

        Func.loadPlugins(PluginList)
        Return True
    End Function

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        initialize()

    End Sub

    Private Sub OpenPluginsFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPluginsFolderToolStripMenuItem.Click
        Process.Start(ref.PluginsDir)
    End Sub

    Private Sub PluginList_SelectedValueChanged(sender As Object, e As EventArgs) Handles PluginList.SelectedValueChanged
        Try
            If PluginList.GetItemCheckState(PluginList.SelectedIndex) = CheckState.Checked Then
                Dim x As ListViewItem = PluginList.SelectedItem()

                Dim prog As String = x.Tag.split("╔")(0)

                Process.Start(prog)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PluginList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PluginList.SelectedIndexChanged
        Try
            Dim x As ListViewItem = PluginList.SelectedItem()

            Dim desc As String = x.Tag.split("╔")(1)

            PluginDescription.Text = desc
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DisablePluginsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisablePluginsToolStripMenuItem.Click
        For index = 0 To PluginList.Items.Count - 1
            PluginList.SetItemCheckState(index, CheckState.Unchecked)
        Next
    End Sub

    Private Sub ReloadPluginsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadPluginsToolStripMenuItem.Click
        Func.reloadPlugins(PluginList)
    End Sub

    Private Sub RefreshPluginListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshPluginListToolStripMenuItem.Click

        PluginList.Items.Clear()
        Func.loadPlugins(PluginList)

    End Sub

    Private Sub AboutArtmanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutArtmanToolStripMenuItem.Click
        MsgBox("I created this program as a precursor to my A-Level project.")
    End Sub
<<<<<<< HEAD

    Private Sub CreateAPluginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAPluginToolStripMenuItem.Click
        Creator.ShowDialog()
    End Sub
=======
>>>>>>> origin/master
End Class
