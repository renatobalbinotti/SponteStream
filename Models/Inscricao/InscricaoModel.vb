Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("INSCRICAO")>
Partial Public Class InscricaoModel
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property IDINSCRICAO As Integer

    Public Property IDLIVE As Integer?

    Public Property IDINSCRITO As Integer?

    <DisplayName("Valor")>
    Public Property VALOR As Decimal?

    <Column(TypeName:="date")>
    <DisplayName("Data de Vencimento")>
    Public Property DATAVENCIMENTO As Date?

    <DisplayName("Status")>
    Public Property STATUS As Byte?
End Class
