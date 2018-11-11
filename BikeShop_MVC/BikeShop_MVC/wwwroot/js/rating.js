(function () {
    $(document).ready(function () {
        var ratingInput = $("#ratingInput");
        var userIsAuthenticated = ratingInput.data("userIsAuthenticated");
        if (userIsAuthenticated === "True") {
            ratingInput.show();
        }
    });

    var options = {
        max_value: 5,
        step_size: 1,
        initial_value: 0
    }
    $(".rating").rate(options);

    $(".rating").click(function () {
        var ratValue = $(".rating").rate("getValue");
        var productId = $(this).data("productId");
        $("#newText").text(ratValue);
        $.ajax({
            type: "POST",
            url: "/Product/SaveRating",
            data: {
                productId: productId,
                ratingValue: ratValue
            },
            success: function (response) {
                if (response.isSuccess) {
                    $("#averageRating").text(response.result.averageOfRatings);
                    $("#ratingsQuantity").text(response.result.ratingsQuantity);
                }
            },
            error: function (response) {
                alert("Error! Sorry, your rating can't be saved now.");
            }
        })
    });
})();