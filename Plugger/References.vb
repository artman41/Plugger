Public Class References
    Public ReadOnly PluginsDir As String = Application.StartupPath + "\Plugins\"
    Public ReadOnly TempDir As String = Application.StartupPath + "\Temp\"
    Public ReadOnly AppDataDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugger\"
End Class