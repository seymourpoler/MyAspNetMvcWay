
$(document).ready(function () {
    $.get("/api/Products/Get")
        .done(function(data) {
            console.log('data from server: ', data);
        });
});