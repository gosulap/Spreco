var recentTracks = document.getElementsByClassName("recent-track");

for (var i = 0; i < recentTracks.length; i++) {
    recentTracks[i].childNodes[1].addEventListener("click", function () {
        console.log("in listener"); 
    }); 
}