function solve(arr) {
    var jumps = Number(arr[0]);
    var track = Number(arr[1]);
    var results = [];
    for (var i = 2; i < arr.length; i++) {
        var data = arr[i].split(',');
        var name = data[0];
        var tempFlee = data[1].trim();
        var fleePower = Number(tempFlee);

        var currentFlee = {name: name, fleePower: fleePower, position: 1};
        results.push(currentFlee);
    }

    var winner = '';
    var isExit = false;
    while (jumps > 0) {
        for (var j = 0; j < results.length; j++) {
            results[j].position += results[j].fleePower;
            if(results[j].position >= track){
                winner = results[j].name;
                results[j].position = track;
                isExit = true;
                break;
            }
        }
        if(isExit){
            break;
        }
        jumps -= 1;
    }
    if(!isExit){
        var maxPosition = 0;
        results.forEach(function(elem){
            if(elem.position >= maxPosition){
                maxPosition = elem.position;
                winner = elem.name;
            }
        });

    }
    console.log(Array(track + 1).join('#'));
    console.log(Array(track + 1).join('#'));

    results.forEach(function(fl){
        var initial = fl.name.toUpperCase().substring(0,1);
        console.log(Array(fl.position).join('.') + initial + Array(track - fl.position + 1).join('.'))
    });

    console.log(Array(track + 1).join('#'));
    console.log(Array(track + 1).join('#'));
    console.log('Winner: ' + winner );

}
var arr = [ '2', '7', 'c, 1', 'P, 2', 'U, 2', 'B, 2' ];

solve(arr);
/*
 winner =  results.filter(function(elem){
 return elem.position == results.sort(function (a, b){
 return b.position - a.position;
 })[0].position
 })[0].name*/