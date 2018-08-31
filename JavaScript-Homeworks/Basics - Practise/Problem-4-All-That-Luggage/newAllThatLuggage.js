function solve(arr) {
    var input;
    var ownerName,
        luggageName,
        isFood,
        isDrink,
        isFragile,
        type,
        weight = 0,
        transfer;
    var people = {};
    var sortedPeople = {};
    var criteria = arr[arr.length - 1];
    for (var i = 0; i < arr.length - 1; i++) {
        input = arr[i].split(/[\.]*\*[\.]*/g);
        ownerName = input[0];
        luggageName = input[1];
        isFood = input[2] === 'true';
        isDrink = input[3] === 'true';
        isFragile = input[4] === 'true';
        weight = Number(input[5]);
        transfer = input[6];
        if (isFood) {
            type = 'food';
        } else if (isDrink) {
            type = 'drink';
        } else {
            type = 'other';
        }

        if (!people[ownerName]) {
            people[ownerName] = {}
        }
        if (!people[ownerName][luggageName]) {
            people[ownerName][luggageName] = {};
        }
        people[ownerName][luggageName] = {kg: weight, fragile: isFragile, type: type, transferredWith: transfer};
    }
    if (criteria == 'luggage name') {
        Object.keys(people).forEach(function (entry) {
            sortedPeople[entry] = {};
            var sortedInnerKeys = Object.keys(people[entry]).sort();

            sortedInnerKeys.forEach(function (key) {
                sortedPeople[entry][key] = people[entry][key];
            });
        });
        return console.log(JSON.stringify(sortedPeople));

    }
    if (criteria == 'weight') {
        Object.keys(people).forEach(function (entry) {
            sortedPeople[entry] = {};
            var sortedInnerKeys = Object.keys(people[entry]).sort(function (a,b){
                return people[entry][a].kg- people[entry][b].kg;
            });

            sortedInnerKeys.forEach(function (key) {
                sortedPeople[entry][key] = people[entry][key];
            });
        })
        return console.log(JSON.stringify(sortedPeople));
    }
    console.log(JSON.stringify(people));
}

var arr = ['Yana Slavcheva.*.clothes.*.false.*.false.*.false.*.2.2.*.backpack',
    'Kiko.*.socks.*.false.*.false.*.false.*.0.2.*.backpack',
    'Kiko.*.banana.*.true.*.false.*.false.*.3.2.*.backpack',
    'Kiko.*.sticks.*.false.*.false.*.false.*.1.6.*.ATV',
    'Kiko.*.glasses.*.false.*.false.*.true.*.3.*.ATV',
    'Manov.*.socks.*.false.*.false.*.false.*.0.3.*.ATV',
    'weight'];

solve(arr);