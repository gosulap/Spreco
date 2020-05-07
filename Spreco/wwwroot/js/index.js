particlesJS.load('particles-js', 'jsons/particlesjs-config.json', function () {
    console.log('callback - particles.js config loaded');
});


var button = document.getElementById("spreco-login");

button.addEventListener("click", function () {
    var loginpack = document.getElementById("spreco-loginpack");

    for (var i = 0; i < loginpack.children.length; i++) {
        loginpack.children[i].style.visibility = "hidden";
    }

    var loader = document.getElementById("spreco-loader");
    loader.style.visibility = "visible"; 
}); 
