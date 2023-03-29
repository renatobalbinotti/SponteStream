@ModelType LiveModel

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
            @Html.DisplayNameFor(Function(model) model.DESCRIÇÃO)
        </dt>

        <dd>
            @Html.TextBoxFor(Function(model) model.DESCRIÇÃO, "", New With {.value = Model.DESCRIÇÃO,
                                                                                                .readonly = "true",
                                                                                                .Class = "form-control"})

        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DATAHORAINICIO)
        </dt>

        <dd>
            @Html.TextBoxFor(Function(model) model.DATAHORAINICIO, "{0:yyyy-MM-dd 00:00}", New With {.value = Model.DATAHORAINICIO,
                                                                                                                    .readonly = "true",
                                                                                                                    .Class = "form-control",
                                                                                                                    .type = "datetime"})

        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DURACAO)
        </dt>

        <dd>
            @Html.TextBoxFor(Function(model) model.DURACAO, "", New With {.value = Model.DURACAO,
                                                                                                               .readonly = "true",
                                                                                                               .Class = "form-control"})
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.VALOR)
        </dt>

        <dd>
            @Html.TextBoxFor(Function(model) model.VALOR, "", New With {.value = Model.VALOR,
                                                                                                               .readonly = "true",
                                                                                                               .Class = "form-control"})
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.idlive}) |
    <button onclick="'@Url.Action("Index")'" class="btn btn-primary">
        @Html.ActionLink("Voltar", "Index", Nothing, New With {.style = "color: white;"})
    </button>
</p>
