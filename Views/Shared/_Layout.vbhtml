 <!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title - Sponte</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-primary">
        <div class="container">
            <div class="navbar-header">
                @Html.ActionLink("SponteStream", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
                
            </div>
            <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
                <ul class="navbar-nav flex-grow-1">
                    <li>@Html.ActionLink("Home", "Index", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>

                    <li>@Html.ActionLink("Instrutor", "Index", "Instrutor", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Inscrições", "Index", "Inscricao", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Inscritos", "Index", "Inscritos", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Lives", "Index", "Live", New With {.area = ""}, New With {.class = "nav-link"})</li>
                </ul>
            </div>
        </div>
    </nav>

    <div Class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - Sponte - Software de Gestão Educacional</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
