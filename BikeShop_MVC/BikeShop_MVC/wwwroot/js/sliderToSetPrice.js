var slider = new Slider('#rangeOfPrice');
slider.on("slideStop", function (sliderValue) {
    document.getElementById("minPriceVal").textContent = sliderValue[0];
})
slider.on("slideStop", function (sliderValue) {
    document.getElementById("minPriceToSend").value = sliderValue[0];
})
slider.on("slideStop", function (sliderValue) {
    document.getElementById("maxPriceVal").textContent = sliderValue[1];
})
slider.on("slideStop", function (sliderValue) {
    document.getElementById("maxPriceToSend").value = sliderValue[1];
})