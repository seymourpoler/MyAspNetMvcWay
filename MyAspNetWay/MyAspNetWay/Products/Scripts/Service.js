function Service() {
    this.all = function() {
        return $.get("/api/Products/Get");
    };
}