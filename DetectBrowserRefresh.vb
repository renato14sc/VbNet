Protected Sub Page_Load(sender As Object, e As EventArgs)
 If Not IsPostBack Then
  Session("CheckRefresh") = Server.UrlDecode(System.DateTime.Now.ToString())
 End If
End Sub
Protected Sub Button1_Click(sender As Object, e As EventArgs)
 If Session("CheckRefresh").ToString() = ViewState("CheckRefresh").ToString() Then
  Label1.Text = "Hello"
  Session("CheckRefresh") = Server.UrlDecode(System.DateTime.Now.ToString())
 Else
  Label1.Text = "Page Refreshed"
 End If
End Sub

Protected Sub Page_PreRender(sender As Object, e As EventArgs)
 ViewState("CheckRefresh") = Session("CheckRefresh")
End Sub
