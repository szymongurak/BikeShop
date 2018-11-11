(function () {
    $(".detailsButton").click(function () {
        var button = $(this);
        var orderId = button.data("orderId");
        var detailsPartial = $(".detailsPartial[data-order-id=" + orderId + "]");
        if (button.hasClass("btn-primary")) {
            $.ajax({
                type: "POST",
                url: "/Order/OrderDetails",
                data: {
                    orderId: orderId,
                },
                success: function (response) {
                    detailsPartial.html(response);
                },
                error: function () {
                    alert("Error! Details can't be displayed");
                }
            })
            button.removeClass("btn-primary").addClass("btn-danger");
            button.children(".detailsIcon").removeClass("glyphicon glyphicon-plus").addClass("glyphicon glyphicon-minus");
        }
        else
        {
            button.removeClass("btn-danger").addClass("btn-primary");
            button.children(".detailsIcon").removeClass("glyphicon glyphicon-minus").addClass("glyphicon glyphicon-plus");
        }
    });
})();