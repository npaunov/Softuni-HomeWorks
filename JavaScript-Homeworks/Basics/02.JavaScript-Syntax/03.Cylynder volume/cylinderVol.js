var first = [2, 4];
var second = [5, 8];
var third = [12, 3];
var result;

function calcCylinderVol(arr){
    result = Math.PI * arr[0] * arr[0] * arr[1];
    return result.toFixed(3);
}

console.log(calcCylinderVol(first));
console.log(calcCylinderVol(second));
console.log(calcCylinderVol(third));