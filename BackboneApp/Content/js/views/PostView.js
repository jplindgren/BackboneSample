    var HelloView = Backbone.View.extend({
        el: $('#main'),
        initialize: function () {
            this.render();
        },
        render: function () {
            $(this.el).append("<pre><h1>Hello backbone!</h1></pre>")
        }
    });

    /******* VERSÃO 1 ***********/
    //            var PostView = Backbone.View.extend({
    //                tagName: 'article',
    //                className: 'page-posts',
    //                render: function () {
    //                    var htmlGenerated = "<h2>Nome do Post</h2>";
    //                    htmlGenerated += "<p>Conteudo do post</p>";
    //                    //$(this.el).html(htmlGenerated);
    //                    this.$el.html(htmlGenerated); //boas práticas
    //                }
    //            });

    /************** VErsão 2 utilizando Templates **************/
    _.templateSettings = {
        interpolate: /\{\{(.+?)\}\}/g
    };

    var PostView = Backbone.View.extend({
        tagName: 'article',
        className: 'page-posts',
        template: _.template('<a href="#" id="add-button">Add Post</a><h2>{{ title }}</h2><p>{{ content }}</p><h3>Comments</h3><label>Username: <input id="username" type="text" /></label>'),
        events: {
            "dblclick": "fullScreen",
            "click #add-button": "newPost",
            "blur #username": "searchUsername"
        },
        render: function () {
            this.$el.html(this.template({ title: "Nome do Post", content: "Conteúdo do Post" }));
        },

        newPost: function () {
            window.alert("Adicionar novo post");
        },

        searchUsername: function (e) {
            window.alert("Searching username " + e.target.value);
        },

        fullScreen: function () {
            window.alert("Post full screen");
        }
    });