function solve(arr) {
    var first = arr[0].toLowerCase();
    var firstArr = first.match(/[A-z]+/g);
    var result = [];

    firstArr.forEach(function (elem) {
        if (firstArr.filter(function (x) {
                return x == elem
            }).length > 2) {
            if (result.indexOf(elem) == -1) {
                result.push(elem)
            }
        }
    });
    if (result.length == 0){
        console.log("No words");
        return;
    }
    var second = arr[1].match(/[^\.!\?]+[\.!\?]+/g);
    if(arr.length == 1){
        console.log("No sentences");
    }
    var secondLower = [];
    second.forEach(function (elem) {
        secondLower.push(elem.toLocaleLowerCase());
    });
    var count = 0;
    var checkSentence =  false;

    for (var i = 0; i < secondLower.length; i++) {
        count = 0;
        var collection = secondLower[i].match(/[A-z]+/g);
        for (var j = 0; j < result.length; j++) {
            if (collection.indexOf(result[j]) !== -1){
                count++;
            }
        }
        if (count > 1){
            console.log(second[i].trim());
            checkSentence = true;
        }
    }
    if(checkSentence){
        return;
    }else {}
    console.log("No sentences");

}

var arr = ["JavaScript is a nice programming language. Some say it is shitty others are like: This is the best I have ever seen! You can do everything you want with it.",
    "JS is the best! This's a mock test to see if you made it."];

solve(arr);