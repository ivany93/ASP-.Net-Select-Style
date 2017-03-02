$(document).ready(function () {
    localStorage.removeItem('CountView');
    $.ajax({
        type: "POST",
        url: "/Home/clearDB",
        dataType: "text",
        data: {},
        success: function (data) {
    
        },
        error: function (e) {
            console.log("error = " + e);
        }
    })
});