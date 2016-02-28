Imports System.Reflection

Public Interface IPlugin : Inherits IDisposable

    Function runModule(sender As CheckedListBox, ByVal moduleInstance As Integer)

End Interface

Public Class PluginFactory

    Public Shared Function GetComposite(path As String, name As String) As Object
        Dim assembly As Assembly = AppDomain.CreateDomain("aDomain").Load(AssemblyName.GetAssemblyName(path))

        Dim cls As Object =
          assembly.CreateInstance(path & "." & name)
        Return cls
    End Function

End Class