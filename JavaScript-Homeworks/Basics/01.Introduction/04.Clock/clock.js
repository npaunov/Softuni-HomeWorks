function time() {
    var date = new Date();
    var hour = date.getHours();
    var minutes = date.getMinutes();
    var seconds = date.getSeconds();
    minutes = addZero(minutes);
    seconds = addZero(seconds);
    document.getElementById("clock").innerHTML =
        hour + ":" + minutes + ":" + seconds;
    var t = setTimeout(time, 200);

}
function addZero(i) {
    if (i < 10) {
        i = "0" + i;
    }
    return i;
}