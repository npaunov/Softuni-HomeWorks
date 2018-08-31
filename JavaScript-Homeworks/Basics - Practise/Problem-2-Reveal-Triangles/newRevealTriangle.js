function solve(arr) {
    var input = arr;
    var output = [];
    for (var i = 0; i < input.length; i++) {
        output[i] = input[i].split('');

    }
    for (var row = 1; row < input.length; row++) {
        for (var col = 1; col < input[row].length; col++) {
            var a = input[row - 1][col];
            var b = input[row][col - 1];
            var c = input[row][col];
            var d = input[row][col + 1];
            if (a == b && b == c && c == d) {
                output[row - 1][col] = '*';
                output[row][col - 1] = '*';
                output[row][col] = '*';
                output[row][col + 1] = '*';

            }
        }

    }
    for (var i = 0; i < output.length; i++) {
        var result = output[i].join('');
        console.log(result);
    }
}

var arr =
        ['aa',
        'aaa',
        'aaaa',
        'aaaaa'];
solve(arr);
