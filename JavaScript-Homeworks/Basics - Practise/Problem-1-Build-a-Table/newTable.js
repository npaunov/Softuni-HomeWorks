function solve(arr) {
    var start = Number(arr[0]);
    var end = Number(arr[1]);
    var fib = [];
    fib.push(Number(0));
    (function () {
        var numMax = 29;
        for (i = 0, j = 1, k = 0; k < numMax; i = j, j = x, k++) {
            x = i + j;
            fib.push(x);
        }
    })();
    console.log("<table>");
    var text = "<tr><th>Num</th><th>Square</th><th>Fib</th></tr>";
    for (var i = start; i <= end; i++) {
        text += "\n<tr><td>" + i + "</td><td>" + i * i + "</td><td>";
        if (fib.indexOf(Number(i)) == -1) {
            text += "no</td></tr>";
        } else {
            text += "yes</td></tr>";
        }
    }
    console.log(text);
    console.log("</table>");
}
var arr = [ '2', '6' ];
solve(arr);