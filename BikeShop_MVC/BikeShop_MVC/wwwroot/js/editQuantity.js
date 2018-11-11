(function () {
    $(".editButton").click(function () {
        var button = $(this);
        var orderPositionId = button.data("orderPositionId");
        var quantityInput = $(".quantityInput[data-order-position-id=" + orderPositionId + "]");
        var totalPriceValue = $(".totalPriceValue[data-order-position-id=" + orderPositionId + "]");
        var quantityValue = $(".quantityValue[data-order-position-id=" + orderPositionId + "]");
        var aButton = $(".acceptButton[data-order-position-id=" + orderPositionId + "]");
        if (button.hasClass("btn-warning")) {
            showInput(button, quantityValue, quantityInput, aButton);
            aButton.click(function () {
                acceptFunction(quantityValue, quantityInput, totalPriceValue, orderPositionId);
                hideInput(button, quantityValue, quantityInput, aButton);
            });
        }
        else {
            hideInput(button, quantityValue, quantityInput, aButton);
        }
    });

    var acceptFunction = function (quantityValue, quantityInput, totalPriceValue, orderPositionId) {
        $.ajax({
            type: "POST",
            url: "/Cart/UpdateQuantity",
            data: {
                orderPositionId: orderPositionId,
                newQuantity: quantityInput.val()
            },
            success: function (response) {
                if (response.isSuccess) {
                    $("#summaryCost").text(response.result.summaryCost);
                    quantityValue.text(response.result.countOfProducts);
                    totalPriceValue.text(response.result.totalPrice);
                }
                else {
                    alert(response.errorMessage);
                }
            },
            error: function (response) {
                alert("You selected too many quantity of product");
            }
        })
    }

    var showInput = function (button, quantityValue, quantityInput, aButton) {
        button.removeClass("btn-warning").addClass("btn-primary");
        button.children(".editIcon").removeClass("glyphicon glyphicon-edit").addClass("glyphicon glyphicon-remove");
        quantityValue.hide();
        quantityInput.show();
        aButton.show();
    };

    var hideInput = function (button, quantityValue, quantityInput, aButton) {
        button.removeClass("btn-primary").addClass("btn-warning");
        button.children(".editIcon").removeClass("glyphicon glyphicon-remove").addClass("glyphicon glyphicon-edit");
        quantityValue.show();
        quantityInput.hide();
        aButton.hide();
    }
})();

