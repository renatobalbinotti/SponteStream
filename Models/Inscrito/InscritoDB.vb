Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class InscritoDB
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=SponteConnectDB")
    End Sub

    Public Overridable Property INSCRITOS As DbSet(Of InscritosModel)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of InscritosModel)() _
            .Property(Function(e) e.NOME) _
            .IsUnicode(False)

        modelBuilder.Entity(Of InscritosModel)() _
            .Property(Function(e) e.EMAIL) _
            .IsUnicode(False)

        modelBuilder.Entity(Of InscritosModel)() _
            .Property(Function(e) e.INSTAGRAM) _
            .IsUnicode(False)
    End Sub
End Class
