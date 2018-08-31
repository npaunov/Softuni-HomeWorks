function solve(arr) {
    var output = {};
    arr.forEach(function (element) {
        var data = element.split(/\.*\*\.*/);
        var name = data[0];
        var type = data[1];
        var isFood = data[2] == 'true';
        var isDrink = data[3] == 'true';
        var isFragile = data[4] == 'true';
        var weight = Number(data[5]);
        var transport = data[6];

    });

    console.log(arr);
}
var arr = ['Yana Slavcheva.*.clothes.*.false.*.false.*.false.*.2.2.*.backpack',
    'Kiko.*.socks.*.false.*.false.*.false.*.0.2.*.backpack',
    'Kiko.*.banana.*.true.*.false.*.false.*.3.2.*.backpack',
    'Kiko.*.sticks.*.false.*.false.*.false.*.1.6.*.ATV',
    'Kiko.*.glasses.*.false.*.false.*.true.*.3.*.ATV',
    'Manov.*.socks.*.false.*.false.*.false.*.0.3.*.ATV',
    'strict'];
solve(arr);