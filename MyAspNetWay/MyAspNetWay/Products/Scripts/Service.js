function Service() {
    this.all = function() {
        var tasks = $.get("/api/Products/Get");
        console.log(tasks);
        return tasks;
    };
}