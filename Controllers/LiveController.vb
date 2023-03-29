Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports SponteStream

Namespace Controllers
    Public Class LiveController
        Inherits System.Web.Mvc.Controller

        Private db As New LiveDB

        ' GET: Live
        Function Index() As ActionResult
            Return View(db.LIVE.ToList())
        End Function

        ' GET: Live/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim liveModel As LiveModel = db.LIVE.Find(id)
            If IsNothing(liveModel) Then
                Return HttpNotFound()
            End If
            Return View(liveModel)
        End Function

        ' GET: Live/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Live/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="IDLIVE,NOME,DESCRIÇÃO,IDINSTRUTOR,DATAHORAINICIO,DURACAO,VALOR")> ByVal liveModel As LiveModel) As ActionResult
            If ModelState.IsValid Then
                db.LIVE.Add(liveModel)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(liveModel)
        End Function

        ' GET: Live/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim liveModel As LiveModel = db.LIVE.Find(id)
            If IsNothing(liveModel) Then
                Return HttpNotFound()
            End If
            Return View(liveModel)
        End Function

        ' POST: Live/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="IDLIVE,NOME,DESCRIÇÃO,IDINSTRUTOR,DATAHORAINICIO,DURACAO,VALOR")> ByVal liveModel As LiveModel) As ActionResult
            If ModelState.IsValid Then
                db.Entry(liveModel).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(liveModel)
        End Function

        ' GET: Live/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim liveModel As LiveModel = db.LIVE.Find(id)
            If IsNothing(liveModel) Then
                Return HttpNotFound()
            End If
            Return View(liveModel)
        End Function

        ' POST: Live/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim liveModel As LiveModel = db.LIVE.Find(id)
            db.LIVE.Remove(liveModel)
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
