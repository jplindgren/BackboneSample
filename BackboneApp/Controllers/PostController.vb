Namespace BackboneApp
    Public Class PostController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /
        Function Index() As JsonResult
            Dim p As New Post
            p.title = "Post teste do servidor"
            p.content = "Conteudo teste vindo do servidor"
            Return Json(p, JsonRequestBehavior.AllowGet)
            'Return View()
        End Function

        '
        ' Post: /
        <ActionName("post")> _
        <HttpPost()> _
        Function Index(ByVal _post As Post) As JsonResult
            Dim teste As Post = _post
            Return Json(_post)
        End Function

        '
        ' GET: /Post
        <ActionName("post")> _
        <HttpGet()> _
        Function Post() As JsonResult
            Dim p As New Post
            p.title = "Post teste do servidor"
            p.content = "Conteudo teste vindo do servidor"
            Return Json(p, JsonRequestBehavior.AllowGet)
            'Return View()
        End Function

        ''
        '' GET: /Post/Details/5

        'Function Post(ByVal id As Integer) As ActionResult
        '    Return View()
        'End Function

        '
        ' GET: /Post/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Post/Create

        <HttpPost()> _
        Function Create(ByVal _post As Post) As ActionResult
            Try
                Dim teste As Post = _post
                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
        
        '
        ' GET: /Post/Edit/5

        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' POST: /Post/Edit/5

        <HttpPost> _
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        '
        ' GET: /Post/Delete/5

        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' POST: /Post/Delete/5

        <HttpPost> _
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function     
    End Class
End Namespace