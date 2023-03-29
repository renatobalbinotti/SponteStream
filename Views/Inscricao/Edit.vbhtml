@ModelType InscricaoModel

@Code
    ViewBag.Title = "Editar"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

@Using (Html.BeginForm("Edit", "SponteStream.Controllers.InscricaoController", FormMethod.Post))
    @<div class="form-horizontal">

        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.IDINSCRICAO)

        <div class="form-group">
            @Html.DisplayNameFor(Function(model) model.VALOR)
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.VALOR, New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.VALOR, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.DisplayNameFor(Function(model) model.DATAVENCIMENTO)
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.DATAVENCIMENTO, "{0:yyyy-MM-dd}", New With {.Class = "form-control", .type = "date"})
                @Html.ValidationMessageFor(Function(model) model.DATAVENCIMENTO, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.DisplayNameFor(Function(model) model.STATUS)
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.STATUS, New With {.class = "form-control", .type = "email", .placeholder = "eu@sponte.com"})
                @Html.ValidationMessageFor(Function(model) model.STATUS, "", New With {.class = "text-danger"})
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
    </div>  End Using


@Scripts.Render("~/bundles/jqueryval")