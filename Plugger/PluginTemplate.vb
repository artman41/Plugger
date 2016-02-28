Class PluginTemplate : Implements IPlugin

#Region "Properties"
    Private _title As String = "Template"
    Private _desc As String = "Plugin Template"
    Private _usage As String = ""

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property Desc As String
        Get
            Return _desc
        End Get
        Set(value As String)
            _desc = value
        End Set
    End Property

    Public Property USage As String
        Get
            Return _usage
        End Get
        Set(value As String)
            _usage = value
        End Set
    End Property

    Private _moduleInstance As Integer
    Private _parentList As CheckedListBox
#End Region

#Region "Methods"

    Public Sub New()

    End Sub

    Public Sub New(ByVal Title As String, ByVal Desc As String, ByVal Usage As String)
        Title = Title
        Desc = Desc
        Usage = Usage
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("Title : {0}  Desc : {1}  Usage : {2}", _title, _desc, _usage)
    End Function
#End Region

    Public Function runModule(sender As CheckedListBox, ByVal moduleInstance As Integer) Implements IPlugin.runModule
        MessageBox.Show("I am a test module")

        'KEEP THIS
        _moduleInstance = moduleInstance
        _parentList = sender
        check()
        Return Nothing
    End Function

    Private Sub check()
        Dim canRun As Boolean = True
        While canRun
            If _parentList.GetItemChecked(_moduleInstance) = 0 Then
                canRun = False
                Dispose()
            End If
        End While
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
