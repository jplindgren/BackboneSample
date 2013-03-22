<%@ Page Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
    <script src="../../Content/js/views/PostView.js" type="text/javascript"></script>
    <script src="../../Content/js/models/Models.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            //            var post = new PostModel({
            //                title: "Novo post Model",
            //                content: "Conteudo post Model"
            //            });

            //            console.log(post.get('title'));
            //            console.log(post.get('content'));
            //            post.set({ content: 'Novo Conteúdo Model' });
            //            //post.set('content','teste'); funciona também
            //            console.log(post.get('content'));

            //            post.set({
            //                title: '<h1>HTML</h1>',
            //                text: '<h2>Teste</h2>'
            //            });

            //            console.log(post.escape('text'));
            //            alert(JSON.stringify(post));

            //            //postView.template(post.toJSON()); //verificar porque não funcionou?

            //            var postView = new PostView();
            //            postView.render();
            //            $('#main').append(postView.el);

            var post = new PostModel();
            post.fetch({
                success: function (model, response) {
                    console.log(model.get('title'));
                },
                error: function (model, response) {
                    window.alert('Ocorreu um erro');
                }
            });

            post = new PostModel({
                title: 'First Post criado client e salvo',
                content: 'Text of the post criado client e salvo'
            });

            post.save(null, {
                success: function (model, response) {
                    console.log(model.get('title'));
                },
                error: function (model, response) {
                    window.alert('Ocorreu um erro');
                }
            });         
        });
    </script>
</asp:Content>
