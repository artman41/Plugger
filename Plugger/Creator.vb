Imports System.IO

Public Class Creator
    Dim ref As New References
    Dim PluginPath As String
    Dim rbtnContextName As String

    Dim Func As MainFunctions
    Dim Launcher As Main

    Private Sub Creator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists(ref.TempDir) Then
            Directory.CreateDirectory(ref.TempDir)
            Debug.WriteLine("TempDir created at " & ref.TempDir)
        Else
            For Each item In Directory.GetFiles(ref.TempDir)
                File.Delete(item)
            Next
            Directory.Delete(ref.TempDir)
            Creator_Load(sender, e)
        End If

        If Not Directory.Exists(ref.AppDataDir) Then
            Directory.CreateDirectory(ref.AppDataDir)
        End If
    End Sub

    Private Sub SavePlugin_Click(sender As Object, e As EventArgs) Handles SavePlugin.Click
        Dim i = 0
        If Not PluginPath = Nothing Then
            Debug.Write(ref.TempDir + "info.txt")

            File.Create(ref.TempDir + "info.txt").Dispose()

            For Each item As RadioButton In FileHolder.Controls
                File.Copy(item.Tag, ref.TempDir & item.Text)
            Next

            Using sw As StreamWriter = New StreamWriter(ref.TempDir + "info.txt")
                sw.WriteLine(PluginName.Text)
                sw.WriteLine(PluginPath.Split("\")(PluginPath.Split("\").Length - 1))
                sw.WriteLine(PluginDescription.Text)
                sw.Close()
            End Using

            Compression.ZipFile.CreateFromDirectory(ref.TempDir, ref.PluginsDir + PluginName.Text + ".plugin")

            Dim x As String() = Directory.GetFiles(ref.TempDir, "*.txt")

            For index = 0 To x.Count() - 1
                File.Delete(x(index))
            Next

        Else
            If i = 0 Then
                MsgBox("You need to add a file to the plugin and choose it as the executable!")
                i += 1
            End If
        End If
    End Sub

    Private Sub AddFiles_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AddFiles.FileOk
        Dim rButton As RadioButton

        'FileHolder.SuspendLayout()

        For Each fl As String In AddFiles.FileNames
            rButton = New RadioButton()
            rButton.AutoSize = True
            rButton.ContextMenuStrip = rButtonContext
            rButton.Name = "rbt_" & Path.GetFileName(fl)
            Console.Write(rButton.Name)
            rButton.Text = Path.GetFileName(fl)
            rButton.Tag = fl
            rButton.Top = (FileHolder.Controls.Count * rButton.Size.Height) + 10
            AddHandler rButton.CheckedChanged, AddressOf RadioButton1_CheckedChanged
            FileHolder.Controls.Add(rButton)

        Next

        'FileHolder.ResumeLayout()

        'For index = 0 To AddFiles.SafeFileNames.Length() - 1
        '    rButton.Name = AddFiles.SafeFileNames(index)
        '    rButton.Text = rButton.Name
        '    Console.Write(AddFiles.SafeFileNames(index))
        '    rButton.Tag = AddFiles.FileNames(index)
        '    Console.Write(AddFiles.FileNames(index))
        '    AddHandler rButton.CheckedChanged, AddressOf RadioButton1_CheckedChanged
        '    FileHolder.Controls.Add(rButton)

        'Next

    End Sub

    Private Sub FindFiles_Click(sender As Object, e As EventArgs) Handles FindFiles.Click
        AddFiles.ShowDialog()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

        Dim rbtn As RadioButton = DirectCast(sender, RadioButton)

        If rbtn.Text.Split(".")(rbtn.Text.Split(".").Length - 1).ToLower().Equals("vb") Then
            If rbtn.Checked Then
                PluginPath = rbtn.Tag
            End If
        Else
            Debug.WriteLine(rbtn.Text.Split(".")(rbtn.Text.Split(".").Length - 1).ToLower())
            MsgBox("Please select a vb file!")
            rbtn.Checked = False
        End If
    End Sub

    Private Sub rButtonContext_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles rButtonContext.Opening
        rbtnContextName = DirectCast(sender, ContextMenuStrip).SourceControl.Name
        Debug.WriteLine("rbtnContextName : " & DirectCast(sender, ContextMenuStrip).SourceControl.Name)
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem.Click
        Debug.WriteLine(rbtnContextName)
        Debug.WriteLine(FileHolder.Container)
        FileHolder.Controls.Remove(FileHolder.Controls.Item(rbtnContextName))
    End Sub

    Private Sub Creator_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            For Each item As ComponentModel.Component In FileHolder.Container.Components
                Debug.WriteLine(item.GetType())
                FileHolder.Container.Remove(item)
            Next
        Catch ex As Exception
            Debug.WriteLine("Exception: " + ex.Message)
            Debug.WriteLine("Exception: " + ex.StackTrace)
        End Try

        Launcher.PluginList.Items.Clear()
        Func.loadPlugins(Launcher.PluginList)
    End Sub
End Class