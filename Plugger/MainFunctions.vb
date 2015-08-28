Imports System.IO
Imports System.IO.Compression

Public Class MainFunctions

    Dim ref As New References

    Public Function getPlugins(ByVal dir As String) As Array
        Console.WriteLine("Given plugin path : " + dir)

        Dim files As Array = Directory.GetFiles(dir, "*.plugin")

        Return files

    End Function

    Public Function loadPlugins(clb As CheckedListBox) As Boolean
        Dim loadedPlugins As Array = getPlugins(ref.PluginsDir)

        Try
            For index = 0 To loadedPlugins.GetUpperBound(0)
                Try
                    Using reader As StreamReader = New StreamReader(ZipFile.Open(loadedPlugins(0), ZipArchiveMode.Read).GetEntry("info.txt").Open())
                        Dim name As String = reader.ReadLine()
                        Dim path As String = reader.ReadLine()
                        Dim desc As String = reader.ReadLine()

                        Dim item As ListViewItem = New ListViewItem(name) '.Split("|")(0))
                        item.Name = name '.Split("|")(0)
                        item.Tag = path + "╔" + desc '.Split("|")(0)

                        clb.Items.Add(item)
                    End Using
                Catch ex As InvalidExpressionException
                    Console.Write(ex)
                End Try
            Next

            Return True
        Catch ex As InvalidExpressionException
            Console.Write(ex)
            Return False
        End Try
    End Function

    Public Function reloadPlugins(clb As CheckedListBox) As Boolean
        Dim x As CheckedListBox = New CheckedListBox

        Try
            For index = 0 To clb.Items.Count - 1
                x.Items.Add(clb.Items.Item(index))
                x.SetItemCheckState(index, clb.GetItemCheckState(index))
                clb.SetItemCheckState(index, CheckState.Unchecked)

                If x.GetItemCheckState(index) = CheckState.Checked Then
                    clb.SetItemCheckState(index, CheckState.Checked)
                End If
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
