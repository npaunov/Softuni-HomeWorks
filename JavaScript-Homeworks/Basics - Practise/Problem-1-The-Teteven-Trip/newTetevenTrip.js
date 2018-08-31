function solve(arr) {
    arr.forEach(function (elem) {
        var data = elem.split(' ');
        var car = data[0];
        var fuelType = data[1];
        var route = data[2];
        var luggage = Number(data[3]);
        var fuel = 10;
        var normalRoute = 0;
        var snowRoute = 0;

        if (fuelType == 'gas') {
            fuel *= 1.2;
        } else if (fuelType == 'diesel') {
            fuel *= 0.8;
        }
        fuel += luggage * 0.01;
        if (route == '1') {
            normalRoute = 110 * (fuel / 100);
            snowRoute = 10 * ((0.3 * fuel) / 100);
            fuel = Math.round(normalRoute + snowRoute);
        } else {
            normalRoute = 95 * (fuel / 100);
            snowRoute = 30 * ((0.3 * fuel) / 100);
            fuel = Math.round(normalRoute + snowRoute);
        }

        console.log(car + ' ' + fuelType + ' ' + route + ' ' + fuel);
    });
}

var arr = ['BMW petrol 1 320.5',
    'Golf petrol 2 150.75',
    'Lada gas 1 202',
    'Mercedes diesel 2 312.54'];
solve(arr);