function solve(arr) {
    var directions = arr[0].split(', ');
    var matrix = [];
    var wallHits = 0;
    var row = 0;
    var col = 0;
    var carrots = 0;
    var cabbage = 0;
    var lettuce = 0;
    var turnip = 0;
    var gardens = [];

    for (var i = 1; i < arr.length; i++) {
        matrix.push(arr[i].split(', '))

    }
    directions.forEach(function (dir) {
        var isMoved = true;
        if (dir == 'left') {
            col--;
            if (col < 0) {
                wallHits++;
                col++;
                isMoved = false;
            }
        } else if (dir == 'right') {
            col++;
            if (col > matrix[row].length - 1) {
                wallHits++;
                col--;
                isMoved = false;
            }
        } else if (dir == 'up') {
            row--;
            if (row < 0) {
                wallHits++;
                row++;
                isMoved = false;
            }
        } else if (dir == 'down') {
            row++;
            if (row > matrix.length - 1) {
                wallHits++;
                row--;
                isMoved = false;
            }
        }
        if (isMoved) {
            var currentPlace = matrix[row][col];
            while (currentPlace.indexOf('{!}') != -1) {
                carrots++;
                currentPlace = currentPlace.replace('{!}', '@');
            }
            while (currentPlace.indexOf('{*}') != -1) {
                cabbage++;
                currentPlace = currentPlace.replace('{*}', '@');
            }
            while (currentPlace.indexOf('{&}') != -1) {
                lettuce++;
                currentPlace = currentPlace.replace('{&}', '@');
            }
            while (currentPlace.indexOf('{#}') != -1) {
                turnip++;
                currentPlace = currentPlace.replace('{#}', '@');
            }
            gardens.push(currentPlace);
        }
    });

    console.log('{' + '"&":' + lettuce +
        ',"*":' + cabbage +
        ',"#":' + turnip +
        ',"!":' + carrots + '' +
        ',"wall hits":' + wallHits + '}');
    if (gardens.length == 0) {
        console.log('no');
    } else {
        console.log(gardens.join('|'));
    }
}

var arr = ['right, right, down, left, left, down, right, right, down, left',
    'qwekjs, asd{#}a, mxz{#}{*}',
    'qwekjs, asd{#}a, xnc{&}a',
    'qwekjs, asd{#}a, xnc{&}a',
    'qwekjs, asd{#}a, xnc{&}a'];

solve(arr);