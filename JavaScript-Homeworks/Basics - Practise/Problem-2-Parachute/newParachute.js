function solve(arr) {
    var row = 0;
    var col = -1;
    while(true){
        col = arr[row].indexOf('o');
        if(col !== -1){
            break;
        }
        row++;
    }
    while (row < arr.length - 1) {
        var leftWind = (arr[row + 1].match(/>/g) || []).length;
        var rightWind = (arr[row + 1].match(/</g) || []).length;
        col += (leftWind - rightWind);
        row += 1;
        var symbol = arr[row][col];
        if (symbol == '_') {
            console.log('Landed on the ground like a boss!');
            console.log(row + ' ' + col);
            break;
        }
        if (symbol == '~') {
            console.log('Drowned in the water like a cat!');
            console.log(row + ' ' + col);
            break;
        }
        if (symbol == '\\' || symbol == '/' || symbol == '|') {
            console.log('Got smacked on the rock like a dog!');
            console.log(row + ' ' + col);
            break;
        }
    }

}
var arr = ['-------------0-<<--------',
    "-------o>>>>>///////////////",
    '---------------->-<---<--',
    '------<<<<<-------/\\--<--',
    '--------------<--/-<\\----',
    '>>--------/\\----/<-<-\\---',
    '---------/<-\\--/------\\--',
    '<-------/----\\/--------\\-',
    '\\------/--------------<-\\',
    '-\\___~/------<-----------'];

solve(arr);