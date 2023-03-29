@ModelType IEnumerable(Of InscricaoModel)

@Code
    ViewBag.Title = "Inscrição"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Inscrições</h2>

<p>
    <button onclick="'@Url.Action("Create")'" class="btn btn-primary">
        @Html.ActionLink("Novo", "Create", Nothing, New With {.style = "color: white;"})
    </button>
</p>
<Table Class="table">
    <thead>
        <tr>
            <th>Nome</th>
            <th>Data de Nascimento</th>
            <th>Email</th>
            <th>Instagram</th>
        </tr>
    </thead>
    <tbody>
        @For Each item In Model
            @<tr>
                <td>
                    @FormatDateTime(item.DATAVENCIMENTO, DateFormat.ShortDate)
                </td>
                <td>
                    @item.STATUS
                </td>
                <td>
                    @item.Valor
                </td>
                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.IDINSCRICAO}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.IDINSCRICAO}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.IDINSCRICAO})
                </td>
            </tr>

        Next
    </tbody>
</Table>