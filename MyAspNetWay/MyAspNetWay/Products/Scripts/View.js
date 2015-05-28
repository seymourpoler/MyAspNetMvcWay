function View(service) {
    $("#btnAdd").click(function () {
    });
        
    this.loadProducts = function() {
        var promiseResult = service.all();
        promiseResult.done(function () {
        });
    };
}