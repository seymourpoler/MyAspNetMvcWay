function View(service) {
    $("#btnAdd").click(function () {
    });
    $("#listOfProducts").empty();
    
    this.loadProducts = function() {
        var promiseResult = service.all();
        promiseResult.done(function (products) {
            _.each(products, function (product) {
                $("#listOfProducts")
                .prepend('<div>' + product.id + ' ' + product.name +
                            ' <a id=' + product.id + ' href=\'#\' class="remove_product">Remove</a>' +
                            ' <a id=' + product.id + ' href=\'#\' class="update_product">Update</a>' +
                        '</div>');
            });
        });
    };
}