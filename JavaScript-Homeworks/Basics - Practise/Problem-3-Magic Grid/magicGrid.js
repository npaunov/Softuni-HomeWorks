function solve(arr) {

    var string = arr[0];
    var magicNumber = Number(arr[1]);
    var matrix = [];
    var result = '';

    for (var i = 2; i < arr.length; i++) {
        matrix.push(arr[i].split(' ').map(function (n) {
            return Number(n);
        }));
    }
    var code = (function () {
        for (var row = 0; row < matrix.length; row++) {
            var current,
                next;
            for (var col = 0; col < matrix[row].length; col++) {
                current = matrix[row][col];
                for (var rowSecond = 0; rowSecond < matrix.length; rowSecond++) {
                    for (var colSecond = 0; colSecond < matrix[row].length; colSecond++) {
                        if(row == rowSecond && col == colSecond ){
                            continue;
                        }
                        next = matrix[rowSecond][colSecond];
                        if (current + next === magicNumber) {
                            return row + col + rowSecond + colSecond;
                        }
                    }

                }

            }

        }
    })();
    for (var j = 0; j < string.length; j++) {
        var temp = string.charCodeAt(j);
        if (j % 2 === 0) {
            result += String.fromCharCode(temp + code);
        }else{
            result += String.fromCharCode(temp - code);
        }

    }
    console.log(result)
}

var arr = ['QqdvSpg',
    '400', '100 200 120', '120 300 310', '150 290 370'];

solve(arr);