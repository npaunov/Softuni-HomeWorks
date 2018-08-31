function solve(arr) {
    var totalCoins = 0;
    arr.forEach(function (index) {
        var data = index.split(' ');
        if (data[0].toLowerCase() === 'coin') {
            var testCoin = Number(data[1]);
            if (!(isNaN(testCoin) || (testCoin % 1 !== 0) || (testCoin < 0))) {
                totalCoins += testCoin;
            }
        }
    });
    var gold = parseInt(totalCoins / 100);
    var silver = parseInt((totalCoins % 100) / 10);
    var bronze = parseInt(totalCoins % 10);
    console.log('gold : ' + gold);
    console.log('silver : ' + silver);
    console.log('bronze : ' + bronze);

}
var arr = [ 'Coin 1',
    'coin 2',
    'coin 5',
    'coin 10',
    'coin 20',
    'coin 50',
    'coin 100',
    'coin 200',
    'coin 500',
    'cigars 1' ];

solve(arr);