// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var checkbox = document.querySelector("input[name=moon]");
var storeImg = document.getElementById("store-img");

checkbox.addEventListener('change', function () {
    if (this.checked) {
        document.body.style.backgroundColor = "#13223E";
        storeImg.src = "/Imports/img/store-nite.png";
        storeImg.style = "height:400px";
        document.getElementsByClassName("inner-child")[0].style.backgroundColor = "#1d1d1d";
    }
    else {
        document.body.style.backgroundColor = "#85caee";
        storeImg.src = "/Imports/img/store-day.png";
        storeImg.style = "";
        document.getElementsByClassName("inner-child")[0].style.backgroundColor = "#9ba4b5";
    }
});