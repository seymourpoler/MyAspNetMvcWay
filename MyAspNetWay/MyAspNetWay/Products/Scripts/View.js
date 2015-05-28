function View(service) {
    $("#btnAdd").click(function () {
    });
    $("#listOfTasks").empty();
    
    this.loadProducts = function() {
        var promiseResult = service.all();
        promiseResult.done(function (tasks) {
            _.each(tasks, function (task) {
                $("#listOfTasks")
                .prepend('<div>' + task.title + ' ' + task.description +
                            ' <a id=' + task.id + ' href=\'#\' class="remove_task">Remove</a>' +
                            ' <a id=' + task.id + ' href=\'#\' class="update_task">Update</a>' +
                        '</div>');
            });
        });
    };
}