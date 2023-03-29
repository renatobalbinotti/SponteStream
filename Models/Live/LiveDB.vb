Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class LiveDB
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=SponteConnectDB")
    End Sub

    Public Overridable Property LIVE As DbSet(Of LiveModel)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of LiveModel)() _
            .Property(Function(e) e.NOME) _
            .IsUnicode(False)

        modelBuilder.Entity(Of LiveModel)() _
            .Property(Function(e) e.DESCRIÇÃO) _
            .IsUnicode(False)

        modelBuilder.Entity(Of LiveModel)() _
            .Property(Function(e) e.VALOR) _
            .HasPrecision(15, 2)
    End Sub
End Class
