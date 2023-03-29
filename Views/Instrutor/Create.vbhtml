@ModelType InstrutorModel

@Code
    ViewBag.Title = "Cadastro"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

@Using (Html.BeginForm("Create", "InstrutorController", FormMethod.Post))
    @<div class="form-horizontal">

        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

        <div class="form-group">
            @Html.DisplayNameFor(Function(model) model.NOME)
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.NOME, New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.NOME, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.DisplayNameFor(Function(model) model.DATANASCIMENTO)
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.DATANASCIMENTO, "{0:yyyy-MM-dd}", New With {.Class = "form-control", .type = "date"})
                @Html.ValidationMessageFor(Function(model) model.DATANASCIMENTO, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.DisplayNameFor(Function(model) model.EMAIL)
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.EMAIL, New With {.class = "form-control", .type = "email", .placeholder = "eu@sponte.com"})
                @Html.ValidationMessageFor(Function(model) model.EMAIL, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.INSTAGRAM, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.INSTAGRAM, New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.INSTAGRAM, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-4 m-1">
                <button type="submit" class="btn btn-primary btn-md">Salvar</button>
                <button onclick="'@Url.Action("Index")'" class="btn btn-primary">
                    @Html.ActionLink("Voltar", "Index", Nothing, New With {.style = "color: white;"})
                </button>
            </div>
        </div>
    </div>  
End Using

@Scripts.Render("~/bundles/jqueryval")