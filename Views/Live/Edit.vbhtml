@ModelType LiveModel

@Code
    ViewBag.Title = "Editar"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

@Using (Html.BeginForm("Edit", "LiveController", FormMethod.Post))
    @<div class="form-horizontal">

        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.IDINSTRUTOR)

         <div class="form-group">
             @Html.DisplayNameFor(Function(model) model.NOME)
             <div class="col-md-10">
                 @Html.TextBoxFor(Function(model) model.NOME, New With {.class = "form-control"})
                 @Html.ValidationMessageFor(Function(model) model.NOME, "", New With {.class = "text-danger"})
             </div>
         </div>

        <div class="form-group">
            @Html.DisplayNameFor(Function(model) model.DESCRIÇÃO)
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.DESCRIÇÃO, New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.DESCRIÇÃO, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.DisplayNameFor(Function(model) model.DATAHORAINICIO)
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.DATAHORAINICIO, "{0:yyyy-MM-dd 00:00}", New With {.Class = "form-control", .type = "datetime"})
                @Html.ValidationMessageFor(Function(model) model.DATAHORAINICIO, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.DisplayNameFor(Function(model) model.DURACAO)
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.DURACAO, New With {.class = "form-control", .type = "email", .placeholder = "eu@sponte.com"})
                @Html.ValidationMessageFor(Function(model) model.DURACAO, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.VALOR, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.VALOR, New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.VALOR, "", New With {.class = "text-danger"})
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