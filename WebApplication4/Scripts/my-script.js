$(function () {
    $("#btnButton").click(function () {
        Sdd();
    })
})

function Sdd() {
    var link = new Object();
    link.id = $('#txtId').val(); // không cần phải ép 
    link.name = "2";

    $.ajax({
        type: "POST",
        url: "/Home/AddLink",
        data: JSON.stringify(link),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response.success === true) {
                toastr.success(response.message, "Success Alert", { timeOut: 1800 });
            } else {
                toastr.info(response.message, "Information Alert", { timeOut: 1800 });
            }
        },
        error: function () {
            toastr.error("Error", "Erro Alert", { timeOut: 1800 });
        }
    }
    );
}