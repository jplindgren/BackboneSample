Imports System.Runtime.Serialization
<DataContract()> _
<ModelBinder(GetType(JsonBinder))> _
<Serializable()> _
Public Class Post
    Public _title As String
    <DataMember()> _
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public _content As String
    <DataMember()> _
    Public Property Content As String
        Get
            Return _content
        End Get
        Set(value As String)
            _content = value
        End Set
    End Property
End Class
