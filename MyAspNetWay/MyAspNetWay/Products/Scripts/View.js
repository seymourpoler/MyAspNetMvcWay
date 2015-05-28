function View(service) {
    $("#btnAdd").click(function () {
    });
    $("#listOfProducts").empty();
    
    this.loadProducts = function() {
        var promiseResult = service.all();
        promiseResult.done(function (products) {
            _.each(product, function (product) {
                $("#listOfProducts")
                .prepend('<div>' + task.title + ' ' + task.description +
                            ' <a id=' + task.id + ' href=\'#\' class="remove_task">Remove</a>' +
                            ' <a id=' + task.id + ' href=\'#\' class="update_task">Update</a>' +
                        '</div>');
            });
        });
    };
}