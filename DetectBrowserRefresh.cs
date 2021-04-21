protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["CheckRefresh"] =
            Server.UrlDecode(System.DateTime.Now.ToString());
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["CheckRefresh"].ToString() == ViewState["CheckRefresh"].ToString())
        {
            Label1.Text = "Hello";
            Session["CheckRefresh"] =
            Server.UrlDecode(System.DateTime.Now.ToString());
        }
        else
        {
            Label1.Text = "Page Refreshed";
        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        ViewState["CheckRefresh"] = Session["CheckRefresh"];
    }
