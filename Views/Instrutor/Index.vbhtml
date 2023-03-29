@ModelType IEnumerable(Of InstrutorModel)

@Code
    ViewBag.Title = "Instrutores"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Instrutores</h2>

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
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.IDINSTRUTOR}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.IDINSTRUTOR}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.IDINSTRUTOR})
                </td>
            </tr>

        Next
    </tbody>
</Table>