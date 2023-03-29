Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports SponteStream

Namespace Controllers
    Public Class InstrutorController
        Inherits System.Web.Mvc.Controller

        Private db As New InstrutorDB

        ' GET: InstrutorModels
        Function Index() As ActionResult
            System.Diagnostics.Debug.WriteLine("INDEX")
            Return View(db.INSTRUTOR.ToList())
        End Function

        ' GET: InstrutorModels/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim instrutorModel As InstrutorModel = db.INSTRUTOR.Find(id)
            If IsNothing(instrutorModel) Then
                Return HttpNotFound()
            End If
            Return View(instrutorModel)
        End Function

        ' GET: InstrutorModels/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: InstrutorModels/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ActionName("Create")>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="DATANASCIMENTO,EMAIL,INSTAGRAM,IDINSTRUTOR,NOME")> ByVal instrutorModel As InstrutorModel) As ActionResult

            System.Diagnostics.Debug.WriteLine("Create Post")
            If ModelState.IsValid Then
                db.INSTRUTOR.Add(instrutorModel)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(instrutorModel)
        End Function

        ' GET: InstrutorModels/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim instrutorModel As InstrutorModel = db.INSTRUTOR.Find(id)
            If IsNothing(instrutorModel) Then
                Return HttpNotFound()
            End If
            Return View(instrutorModel)
        End Function

        ' POST: InstrutorModels/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="DATANASCIMENTO,EMAIL,INSTAGRAM,IDINSTRUTOR,NOME")> ByVal instrutorModel As InstrutorModel) As ActionResult
            If ModelState.IsValid Then
                db.Entry(instrutorModel).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(instrutorModel)
        End Function

        ' GET: InstrutorModels/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim instrutorModel As InstrutorModel = db.INSTRUTOR.Find(id)
            If IsNothing(instrutorModel) Then
                Return HttpNotFound()
            End If
            Return View(instrutorModel)
        End Function

        ' POST: InstrutorModels/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim instrutorModel As InstrutorModel = db.INSTRUTOR.Find(id)
            db.INSTRUTOR.Remove(instrutorModel)
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
