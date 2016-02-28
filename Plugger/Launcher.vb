Imports System.ComponentModel
Imports System.Reflection

Public Class Main
    Dim Func As New MainFunctions
    Dim ref As New References

    Dim oSI As ListViewItem
    Dim nSI As New ListViewItem

    Private Function initialize() As Boolean
        Try
            System.IO.Directory.Delete(ref.AppDataDir, True)
        Catch ex As Exception
        End Try

        IO.Directory.CreateDirectory(ref.PluginsDir) ' To make sure that the plugins folder exists
        IO.Directory.CreateDirectory(ref.AppDataDir) ' To make sure that the tempPlugin folder exists

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
        'Dim oType As System.Type
        'Dim oAssembly As System.Reflection.Assembly
        'Dim oObject As System.Object
        Try
            If PluginList.GetItemCheckState(PluginList.SelectedIndex) = CheckState.Checked Then

                Dim x As ListViewItem = PluginList.SelectedItem()

                Dim path As String = ref.AppDataDir & x.Name & "\" & x.Tag.split("╔")(0)

                Dim cls As IPlugin

                '  cls = PluginFactory.GetComposite(path, x.Name)

                Template.Title = "Dave"

                MessageBox.Show(Template.Title)
                MessageBox.Show(Template.ToString)

                ' PluginHost.loadClass(cls, PluginList, PluginList.SelectedIndex)

                'oAssembly = Assembly.LoadFrom(path)
                'Debug.WriteLine("Module Loaded from : " & path)
                'oType = oAssembly.GetType(x.Name & "." & x.Name)
                'Debug.WriteLine("Type retrieved ((" & oType.ToString() & "))")
                'oObject = Activator.CreateInstance(oType)
                'Debug.WriteLine("Instance of Module created")
                'oObject.runModule(PluginList, PluginList.SelectedIndex)
                'Debug.WriteLine("Module Ran")
            Else

            End If
        Catch ex As NullReferenceException

        End Try

    End Sub

    Private Sub PluginList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PluginList.SelectedIndexChanged
        Try
            Dim x As ListViewItem = PluginList.SelectedItem()

            Dim desc As String = x.Tag.split("╔")(1)

            PluginDescription.Text = desc
        Catch ex As Exception

        End Try

        oSI = nSI
        nSI = PluginList.SelectedItem()

        If Not oSI.Text.Equals("") Then
            Func.cleanPlugin(oSI.Text)
        End If
        Func.loadPlugin(nSI.Text)

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

    Private Sub CreateAPluginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAPluginToolStripMenuItem.Click
        Creator.ShowDialog()
    End Sub
End Class
