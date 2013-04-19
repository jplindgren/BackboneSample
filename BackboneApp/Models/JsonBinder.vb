Imports System.Runtime.Serialization.Json

Public Class JsonBinder
    Implements IModelBinder

    Public Function BindModel(controllerContext As System.Web.Mvc.ControllerContext, bindingContext As System.Web.Mvc.ModelBindingContext) As Object Implements System.Web.Mvc.IModelBinder.BindModel
        If controllerContext Is Nothing Then
            Throw New ArgumentNullException("controllerContext")
        End If

        If (bindingContext Is Nothing) Then
            Throw New ArgumentNullException("bindingContext")
        End If

        Dim serializer = New DataContractJsonSerializer(bindingContext.ModelType)
        Return serializer.ReadObject(controllerContext.HttpContext.Request.InputStream)
    End Function
End Class
