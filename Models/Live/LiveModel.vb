Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("LIVE")>
Partial Public Class LiveModel
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property IDLIVE As Integer

    <StringLength(80)>
    Public Property NOME As String

    <StringLength(50)>
    Public Property DESCRIÇÃO As String

    Public Property IDINSTRUTOR As Integer?

    Public Property DATAHORAINICIO As Date?

    Public Property DURACAO As Integer?

    Public Property VALOR As Decimal?
End Class
