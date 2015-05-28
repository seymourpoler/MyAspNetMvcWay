function View(service) {
    this.loadProducts = function() {
        var promiseResult = service.all();
        promiseResult.done(function () {
            
        });
    };
}