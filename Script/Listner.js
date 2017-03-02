$(document).ready(function () {

    CountView = localStorage.getItem("CountView");
    if (CountView == null) {
        $('#step').text('1');
    } else {
        $('#step').text(parseInt(localStorage.getItem("CountView")) + 1);
    }
    $('.selectImage').click(function () {

        var type =  $(this).attr('data-image-type');
        var imageId = $(this).attr('data-image-id');
        
        //CountView = localStorage.getItem("CountView");   

        if (CountView == null) {
            localStorage.setItem("CountView", 1);
        } else {
            localStorage.setItem("CountView", parseInt(localStorage.getItem("CountView"))+ 1);
        }
        if (parseInt(localStorage.getItem("CountView")) < 10) {


            $.ajax({
                type: "POST",
                url: "Home/ListnerSelectImage",
                dataType: "text",
                data: { idType: type, idSelectImage: imageId },
                success: function (data) {
                    window.location.reload();
                },
                error: function (e) {
                    console.log("error = " + e);
                }
            })
        } else {
            $.ajax({
                type: "POST",
                url: "/Home/EndIteration",
                dataType: "text",
                data: { idType: type, idSelectImage: imageId },
                success: function (data) {
                    console.log(data);
                    document.location.replace(data);
                },
                error: function (e) {
                    console.log("error = " + e);
                }
            })
        }

    });
});