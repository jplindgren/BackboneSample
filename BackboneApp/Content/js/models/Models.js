var PostModel = Backbone.Model.extend({
    urlRoot: 'Post',
    url: 'Post/post',
//    url: function() {
//        return this.isNew() ? '/Post/Create' : '/Post/' + this.get('id');
//    },
    defaults: {
        title: '',
        content: ''
    }
});