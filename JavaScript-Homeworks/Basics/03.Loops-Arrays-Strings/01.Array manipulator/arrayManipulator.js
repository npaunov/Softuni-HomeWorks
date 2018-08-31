var arr = ["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0,
    "Penka", {bunniesCount: 10}, [10, 20, 30, 40]];
var string = "";

function getArray(){
    for (var str in arr){
        string += str + ", ";
    }
    return string;
}

function filterNumbers(arr) {
    return arr.filter(function(number){return !isNaN(number)});
}

console.log(getArray());
//console.log(arr);
//console.log(filterNumbers(arr));

//console.log(filterNumbers(arr));