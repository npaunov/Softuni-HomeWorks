function calculateQuadraticRoot() {
    var a = Number(document.getElementById("input_a").value);
    var b = Number(document.getElementById("input_b").value);
    var c = Number(document.getElementById("input_c").value);
    var d = (b * b - 4 * a * c);
    var x1 = (-b - Math.sqrt(d)) / (2 * a);
    var x2 = (-b + Math.sqrt(d)) / (2 * a);

    if(d < 0){
        return document.getElementById("x1").innerHTML =
            "No real rots!"
    }

    if(d === 0) {
        document.getElementById("x1").innerHTML = "x = " + x1;
        document.getElementById("x2").innerHTML = "";
    } else {
        document.getElementById("x1").innerHTML = "x" + "1".sub() + " = " + x1;
        document.getElementById("x2").innerHTML = "x" + "2".sub() + " = " + x2;
    }
}
