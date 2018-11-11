(function () {
    $(".radioInput").change(function () {
        var radioBtn = $(this);
        var costOfShipmentValue = radioBtn.val();
        $("#typeOfShipment").val(radioBtn.attr('data-typeOfShipment'));
        $.ajax({
            type: "POST",
            url: "/Order/ChangeTypeOfShipment",
            data: {
                costOfShipment: costOfShipmentValue,
                summaryCost: $("#summaryCostValue").val()
            },
            success: function (response) {
                if (response.isSuccess) {
                    $("#totalCost").text(response.result.totalCost);
                }
                else {
                    alert(response.errorMessage);
                }
            }
        })
    });
})();