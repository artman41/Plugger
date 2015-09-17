Imports System.IO

Public Class Creator
    Dim ref As New References
    Dim PluginPath As String
    Dim rbtnContextName As String

    Private Sub SavePlugin_Click(sender As Object, e As EventArgs) Handles SavePlugin.Click

        If Not PluginPath = Nothing Then
            Console.Write(ref.TempDir + "info.txt")

            File.Create(ref.TempDir + "info.txt").Dispose() 'error when attmepting to create file. Will need to fix for rest to work

            Using sw As StreamWriter = New StreamWriter(ref.TempDir + "info.txt")
                sw.WriteLine(PluginName.Text)
                sw.WriteLine(PluginPath)
                sw.WriteLine(PluginDescription.Name)
                sw.Close()
            End Using

            Compression.ZipFile.CreateFromDirectory(ref.TempDir, ref.PluginsDir + PluginName.Text + ".plugin")

            Dim x As String() = Directory.GetFiles(ref.TempDir, "*.txt")

            For index = 0 To x.Count() - 1
                File.Delete(x(index))
            Next

        Else
            MsgBox("You need to add a file to the plugin and choose it as the executable!")
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

        If rbtn.Checked Then
            PluginPath = rbtn.Tag
        End If
    End Sub

    Private Sub rButtonContext_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles rButtonContext.Opening
        rbtnContextName = "rbt_" + DirectCast(sender, ContextMenuStrip).SourceControl.Name
        Console.WriteLine("rbt_" + DirectCast(sender, ContextMenuStrip).SourceControl.Parent.Name)
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem.Click
        Console.WriteLine(rbtnContextName)
        FileHolder.Container.Remove(FileHolder.Container.Components.Item(rbtnContextName))
    End Sub

    Private Sub Creator_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            For Each item As ComponentModel.Component In FileHolder.Container.Components
                Console.WriteLine(item.GetType())
                FileHolder.Container.Remove(item)
            Next
        Catch ex As Exception
            Console.WriteLine("Exception: " + ex.Message)
            Console.WriteLine("Exception: " + ex.StackTrace)
        End Try
    End Sub
End Class