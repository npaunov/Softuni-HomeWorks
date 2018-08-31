var inputData = [[38, 118, 'chocolate', 0.5], [20, 87, 'fruits', 2],
    [16, 102, 'nuts', 1.1]];

function calcSupply (age, maxAge, food, foodPerDay){
    var amount = (maxAge - age) * 365 * foodPerDay;
    return console.log(amount + 'kg of' + food + 'would be enough until I am ' + maxAge +' years old.');
}

for (var i = 0; i < inputData.length; i++){
    calcSupply(inputData[i][0], inputData[i][1], inputData[i][2], inputData[i][3]);
}