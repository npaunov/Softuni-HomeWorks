function solve(arr) {
    var gold = 0,
        silver = 0,
        diamonds = 0,
        inputOre,
        ore,
        oreCount = 0;
    for (var i = 0; i < arr.length; i++) {
        if (arr[i].indexOf('-') === -1 || arr[i].indexOf(':') === -1) {
            continue;
        }
        var input = arr[i].split(':');
        inputOre = input[input.length - 2].split('-');
        ore = inputOre[inputOre.length - 1].trim();
        oreCount = Number(input[input.length - 1].trim());

        if (ore === 'gold') {
            gold += oreCount;
        } else if (ore === 'silver') {
            silver += oreCount;
        } else if (ore === 'diamonds') {
            diamonds += oreCount;
        }
    }
    console.log('*' + 'Silver: ' + silver);
    console.log('*' + 'Gold: ' + gold);
    console.log('*' + 'Diamonds: ' + diamonds);

}


var arr = [
    'mine bobovdol - gold : 10',
    'mine - diamonds : 5',
    'mine colas - wood : 10',
    'mine myMine - silver :  14',
    'mine silver:14 - silver : 14'];

solve(arr);