Imports System.Net.Http

Module HttpClientManager
    Public ReadOnly Client As New HttpClient()

    Sub New()
        Client.BaseAddress = New Uri("http://localhost:3000/")
    End Sub
End Module
