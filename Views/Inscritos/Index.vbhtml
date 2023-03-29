@ModelType IEnumerable(Of InscritosModel)

@Code
    ViewBag.Title = "Inscritos"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Inscritos</h2>

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
                    @item.Nome
                </td>
                <td>
                    @FormatDateTime(item.DATANASCIMENTO, DateFormat.ShortDate)
                </td>
                <td>
                    @item.Email
                </td>
                <td>
                    @item.Instagram
                </td>
                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.IDINSCRITO}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.IDINSCRITO}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.IDINSCRITO})
                </td>
            </tr>

        Next
    </tbody>
</Table>