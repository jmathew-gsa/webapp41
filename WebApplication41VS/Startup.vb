Imports Microsoft.Owin
Imports Owin

<Assembly: OwinStartupAttribute("WebApp41FriendlyName", GetType(WebApplication41VS.Startup))>


Partial Public Class Startup
    Public Sub Configuration(app As IAppBuilder)
        ConfigureAuth(app)
    End Sub
End Class
