@ModelType InscricaoModel

@Code
    ViewBag.Title = "Inscrição"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div>
    <h4>Instrutor</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.VALOR)
        </dt>

        <dd>
            @Html.TextBoxFor(Function(model) model.VALOR, "", New With {.value = Model.VALOR,
                                                                                                .readonly = "true",
                                                                                                .Class = "form-control"})

        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DATAVENCIMENTO)
        </dt>

        <dd>
            @Html.TextBoxFor(Function(model) model.DATAVENCIMENTO, "{0:yyyy-MM-dd}", New With {.value = Model.DATAVENCIMENTO,
                                                                                                     .readonly = "true",
                                                                                                     .Class = "form-control",
                                                                                                     .type = "date"})

        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.STATUS)
        </dt>

        <dd>
            @Html.TextBoxFor(Function(model) model.STATUS, "", New With {.value = Model.STATUS,
                                                                                                                    .readonly = "true",
                                                                                                                    .Class = "form-control"})
        </dd>
    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.IDINSCRICAO}) |
    <button onclick="'@Url.Action("Index")'" class="btn btn-primary">
        @Html.ActionLink("Voltar", "Index", Nothing, New With {.style = "color: white;"})
    </button>
</p>
