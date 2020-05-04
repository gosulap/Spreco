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