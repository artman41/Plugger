Public Class PluginHost
    Public Shared Function loadClass(PClass As IPlugin, sender As Object, moduleInstance As Integer)
        Return PClass.runModule(sender, moduleInstance)
    End Function
End Class
