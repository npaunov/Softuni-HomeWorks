function Person(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.toString = function () {
        return this.firstName + ' ' + this.lastName + '(' + 'age ' + this.age + ')'
    };
}

function groupBy(criteria) {
    var input = people.slice(0);
    var output = [];
    var temp = [];
    input.sort(function (a, b) {
        return a[criteria] - b[criteria];
    });

    for (var i = 0; i < input.length; i++) {
        var current = input[i][criteria];
        var next = i + 1 < input.length ? input[i + 1][criteria] : undefined;
        if (current != next) {
            temp.push(input[i]);
            output.push(temp);
            temp = [];
        } else {
            temp.push(input[i])
        }
    }

    output.forEach(function (entry) {
        var groupId = entry[0][criteria];
        console.log('Group ' + groupId + ' : ' + '[' + entry.join(', ') + ']')
    });

}
var people = [
    new Person("Scott", "Guthrie", 38),
    new Person("Scott", "Johns", 36),
    new Person("Scott", "Hanselman", 39),
    new Person("Jesse", "Liberty", 57),
    new Person("Jon", "Skeet", 38)

];
groupBy('firstName');
console.log();
groupBy('age');
console.log();
groupBy('lastName');
console.log();