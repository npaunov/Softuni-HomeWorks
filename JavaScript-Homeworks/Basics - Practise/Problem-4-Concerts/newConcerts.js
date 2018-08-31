function solve(arr) {
    var input = arr;
    var output = {};
    for (var i = 0; i < input.length; i++) {
        var temp = input[i].split('|');
        var group = temp[0].trim();
        var city = temp[1].trim();
        var place = temp[3].trim();

        if (!output[city]) {
            output[city] = {};
        }
        if (!output[city][place]) {
            output[city][place] = [];
        }
        if (output[city][place].indexOf(group) == -1) {
            output[city][place].push(group);
        }

    }
    output = sortObjects(output);

    for (var town in output) {
        output[town] = sortObjects(output[town]);
        for (var stadium in output[town]) {
            output[town][stadium].sort();
        }
    }

    console.log(JSON.stringify(output));

    function sortObjects(obj) {
        var sortedArr = Object.keys(obj).sort();
        var sortedObjects = {};
        for (var key in sortedArr) {
            var temp = sortedArr[key];
            sortedObjects[temp] = obj[temp];
        }
        return sortedObjects;
    }
}
var arr = ['ZZ Top | London | 2-Aug-2014 | Wembley Stadium',
    'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium',
    'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium',
    'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium',
    'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium',
    'Helloween | London | 28-Jul-2014 | Wembley Stadium',
    'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium',
    'Metallica | London | 03-Oct-2014 | Olympic Stadium',
    'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium',
    'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium'];

solve(arr);