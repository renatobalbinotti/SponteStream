@ModelType InstrutorModel

@Code       
    ViewBag.Title = Model.NOME
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div>
    <h4>Instrutor</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.NOME)
        </dt>

        <dd>
            @Html.TextBoxFor(Function(model) model.NOME, "", New With {.value = Model.NOME,
                                                                                 .readonly = "true",
                                                                                 .Class = "form-control"})

        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DATANASCIMENTO)
        </dt>

        <dd>
            @Html.TextBoxFor(Function(model) model.DATANASCIMENTO, "{0:yyyy-MM-dd}", New With {.value = Model.DATANASCIMENTO,
                                                                                      .readonly = "true",
                                                                                      .Class = "form-control",
                                                                                      .type = "date"})

        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EMAIL)
        </dt>

        <dd>
            @Html.TextBoxFor(Function(model) model.EMAIL, "", New With {.value = Model.EMAIL,
                                                                                                .readonly = "true",
                                                                                                .Class = "form-control"})
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.INSTAGRAM)
        </dt>

        <dd>
            @Html.TextBoxFor(Function(model) model.INSTAGRAM, "", New With {.value = Model.INSTAGRAM,
                                                                                                .readonly = "true",
                                                                                                .Class = "form-control"})
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.IDINSTRUTOR}) |
    <button onclick="'@Url.Action("Index")'" class="btn btn-primary">
        @Html.ActionLink("Voltar", "Index", Nothing, New With {.style = "color: white;"})
    </button>
</p>
