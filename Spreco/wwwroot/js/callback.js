/*
var recentTracks = document.getElementsByClassName("recent-track");

for (var i = 0; i < recentTracks.length; i++) {
    document.getElementById(recentTracks[i].childNodes[1].className).style.display = "none"; 

    recentTracks[i].childNodes[1].addEventListener("click", function () {
        document.getElementById(this.className).style.display = "inline";
        for (var j = 0; j < recentTracks.length; j++) {
            if (recentTracks[j].childNodes[1].className != this.className) {
                document.getElementById(recentTracks[j].childNodes[1].className).style.display = "none"; 
            }
        }
    }); 
}
*/
var parallax_images = document.getElementsByClassName("parallax");

for (var i = 0; i < parallax_images.length; i++) {
    parallax_images[i].style.backgroundImage = "url(" + parallax_images[i].id + ")"; 
}


var tracks = document.getElementsByClassName("contents"); 
var ids = []; 

for (var i = 0; i < tracks.length; i++) {
    var temp = tracks[i].childNodes[3]; 
    for (var j = 1; j < 6; j += 2) {
        console.log(temp.childNodes[j].childNodes[1].href); 
        ids.push(temp.childNodes[j].childNodes[1].href.split("https://open.spotify.com/track/")[1]); 
    }
}


/*
var tracks = document.getElementsByClassName("row");
var ids = [];

for (var i = 0; i < tracks.length; i++) {
    for (var j = 0; j < 3; j++) {
        // not all rows have three things 
        if (tracks[i].children[j]) {
            ids.push(tracks[i].children[j].children[0].href.split("https://open.spotify.com/track/")[1]);
        }
    }
} */ 

var newhref = "/home/export?ids="; 

for (var i = 0; i < ids.length; i++) {
    newhref = newhref + ids[i] + ","; 
}

var exportTag = document.getElementById("spreco-export"); 
exportTag.href = newhref; 