Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class InstrutorDB
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=SponteConnectDB")
    End Sub

    Public Overridable Property INSTRUTOR As DbSet(Of InstrutorModel)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of InstrutorModel)() _
            .Property(Function(e) e.NOME) _
            .IsUnicode(False)

        modelBuilder.Entity(Of InstrutorModel)() _
            .Property(Function(e) e.EMAIL) _
            .IsUnicode(False)

        modelBuilder.Entity(Of InstrutorModel)() _
            .Property(Function(e) e.INSTAGRAM) _
            .IsUnicode(False)
    End Sub
End Class
