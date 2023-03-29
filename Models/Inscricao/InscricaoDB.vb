Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class InscricaoDB
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=SponteConnectDB")
    End Sub

    Public Overridable Property INSCRICAO As DbSet(Of InscricaoModel)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of InscricaoModel)() _
            .Property(Function(e) e.VALOR) _
            .HasPrecision(15, 2)
    End Sub
End Class
