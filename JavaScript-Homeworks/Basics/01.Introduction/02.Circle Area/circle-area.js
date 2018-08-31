function calcCircleArea(r) {
    var area = Math.PI * Math.pow(r, 2)
    return("r = " + r + "; area =" + area + "<br>");
}

function calculateInput() {
    var r = document.getElementById("input").value;
    if(isNaN(r)){
        document.getElementById("result").innerHTML = "This is not a Number!";
        return;
    }
    document.getElementById("result").innerHTML = calcCircleArea(r);
}