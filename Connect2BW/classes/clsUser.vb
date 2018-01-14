Public Class clsUser

#Region "Variables"

    Private _userKey As String
    Private _systemIdentifier As String
    Private _client As String
    Private _userName As String
    Private _password As String
    Private _language As String

#End Region

#Region "Constructors"

    Friend Sub New()
        _systemIdentifier = String.Empty
        _client = String.Empty
        _userName = String.Empty
        _password = String.Empty
        _language = String.Empty
        _userKey = _userName & "@" & _systemIdentifier
    End Sub

#End Region

End Class
