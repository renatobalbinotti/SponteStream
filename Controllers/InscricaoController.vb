Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports SponteStream

Namespace Controllers
    Public Class InscricaoController
        Inherits System.Web.Mvc.Controller

        Private db As New InscricaoDB

        ' GET: Inscricao
        Function Index() As ActionResult
            Return View(db.INSCRICAO.ToList())
        End Function

        ' GET: Inscricao/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim inscricaoModel As InscricaoModel = db.INSCRICAO.Find(id)
            If IsNothing(inscricaoModel) Then
                Return HttpNotFound()
            End If
            Return View(inscricaoModel)
        End Function

        ' GET: Inscricao/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Inscricao/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="IDINSCRICAO,IDLIVE,IDINSCRITO,VALOR,DATAVENCIMENTO,STATUS")> ByVal inscricaoModel As InscricaoModel) As ActionResult
            If ModelState.IsValid Then
                db.INSCRICAO.Add(inscricaoModel)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(inscricaoModel)
        End Function

        ' GET: Inscricao/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim inscricaoModel As InscricaoModel = db.INSCRICAO.Find(id)
            If IsNothing(inscricaoModel) Then
                Return HttpNotFound()
            End If
            Return View(inscricaoModel)
        End Function

        ' POST: Inscricao/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="IDINSCRICAO,IDLIVE,IDINSCRITO,VALOR,DATAVENCIMENTO,STATUS")> ByVal inscricaoModel As InscricaoModel) As ActionResult
            If ModelState.IsValid Then
                db.Entry(inscricaoModel).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(inscricaoModel)
        End Function

        ' GET: Inscricao/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim inscricaoModel As InscricaoModel = db.INSCRICAO.Find(id)
            If IsNothing(inscricaoModel) Then
                Return HttpNotFound()
            End If
            Return View(inscricaoModel)
        End Function

        ' POST: Inscricao/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim inscricaoModel As InscricaoModel = db.INSCRICAO.Find(id)
            db.INSCRICAO.Remove(inscricaoModel)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Function GeraCodigoBarras() As String
            Dim dataVencimento As DateTime = ViewData("DataVencimento")
            Dim dateBase As DateTime = #1997-10-07#

            Dim fatorVencimento As Integer = DateDiff(DateInterval.Day, dateBase, dataVencimento)

            System.Diagnostics.Debug.WriteLine("FatorVencimento: " + fatorVencimento.ToString())
            Return "00000.00000 00000.000000 00000.000000 0 " + fatorVencimento.ToString()
        End Function
    End Class
End Namespace
