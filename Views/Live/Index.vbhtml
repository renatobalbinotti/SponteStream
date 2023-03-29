@ModelType IEnumerable(Of LiveModel)

@Code
    ViewBag.Title = "Lives"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Lives</h2>

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
                    @item.DESCRIÇÃO
                </td>

                <td>
                    @FormatDateTime(item.DATAHORAINICIO, DateFormat.LongDate)
                </td>
                <td>
                    @item.DURACAO
                </td>
                <td>
                    @item.Valor
                </td>
                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.IDLIVE}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.IDLIVE}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.IDLIVE})
                </td>
            </tr>

        Next
    </tbody>
</Table>