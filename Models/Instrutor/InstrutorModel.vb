Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("INSTRUTOR")>
Partial Public Class InstrutorModel
    <Key>
    <DisplayName("Código")>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property IDINSTRUTOR As Integer

    <StringLength(80)>
    <DisplayName("Nome")>
    Public Property NOME As String

    <Column(TypeName:="date")>
    <DisplayName("Data de Nascimento")>
    Public Property DATANASCIMENTO As Date?

    <StringLength(80)>
    <DisplayName("Email")>
    Public Property EMAIL As String

    <StringLength(100)>
    <DisplayName("Instagram")>
    Public Property INSTAGRAM As String
End Class
