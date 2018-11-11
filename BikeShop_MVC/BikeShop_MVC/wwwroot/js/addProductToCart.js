$(document).ready(function () {
    $("#btnToAdd").click(function () {
        var pId = $('input[id="productId"]');
        var sQ = $('input[id="selectedQuantity"]');
        $.ajax({
            type: "POST",
            url: "/Cart/AddProductToCart",
            data: {
                productId: pId.val(),
                selectedQuantity: sQ.val()
            },
            success: function (response) {
                if (response.isSuccess) {
                    $("#availableQuantity").load(" #availableQuantity");
                    $("#cartViewComponent").load(" #cartViewComponent");
                }
                else {
                    alert(response.errorMessage);
                }
            },
            error: function (response) {
                alert("You selected too many quantity of product");
            }
        })
    });
});