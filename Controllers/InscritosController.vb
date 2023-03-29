Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports SponteStream

Namespace Controllers
    Public Class InscritosController
        Inherits System.Web.Mvc.Controller

        Private db As New InscritoDB

        ' GET: Inscritos
        Function Index() As ActionResult
            Return View(db.INSCRITOS.ToList())
        End Function

        ' GET: Inscritos/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim inscritosModel As InscritosModel = db.INSCRITOS.Find(id)
            If IsNothing(inscritosModel) Then
                Return HttpNotFound()
            End If
            Return View(inscritosModel)
        End Function

        ' GET: Inscritos/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Inscritos/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="IDINSCRITO,NOME,DATANASCIMENTO,EMAIL,INSTAGRAM")> ByVal inscritosModel As InscritosModel) As ActionResult
            If ModelState.IsValid Then
                db.INSCRITOS.Add(inscritosModel)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(inscritosModel)
        End Function

        ' GET: Inscritos/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim inscritosModel As InscritosModel = db.INSCRITOS.Find(id)
            If IsNothing(inscritosModel) Then
                Return HttpNotFound()
            End If
            Return View(inscritosModel)
        End Function

        ' POST: Inscritos/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="IDINSCRITO,NOME,DATANASCIMENTO,EMAIL,INSTAGRAM")> ByVal inscritosModel As InscritosModel) As ActionResult
            If ModelState.IsValid Then
                db.Entry(inscritosModel).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(inscritosModel)
        End Function

        ' GET: Inscritos/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim inscritosModel As InscritosModel = db.INSCRITOS.Find(id)
            If IsNothing(inscritosModel) Then
                Return HttpNotFound()
            End If
            Return View(inscritosModel)
        End Function

        ' POST: Inscritos/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim inscritosModel As InscritosModel = db.INSCRITOS.Find(id)
            db.INSCRITOS.Remove(inscritosModel)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
