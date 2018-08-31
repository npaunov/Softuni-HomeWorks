function solve(arr) {
    var output = {};

    arr.forEach(function (element) {
        var data = element.split('-');
        var secondData = data[1].split(':');
        var exam = secondData[0].trim();
        var name = data[0].trim();
        var result = Number(secondData[1].trim());
        var makeUpExams = 0;
        if (result >= 0 && result <= 400) {
            var newStudent = {name: name, result: result, makeUpExams: makeUpExams};
            if (!output[exam]) {
                output[exam] = [];
                output[exam].push(newStudent);
            } else {
                var currentStudent = output[exam].filter(function (el) {
                    return el.name == name
                })[0];
                if (!currentStudent) {
                    output[exam].push(newStudent);
                } else {
                    currentStudent.result = currentStudent.result > result ? currentStudent.result : result;
                    currentStudent.makeUpExams += 1;
                }
            }


        }

    });

    var sortedExams = {};
    Object.keys(output).forEach(function (entry) {
            sortedExams[entry] = output[entry].sort(function (a, b) {
                if (a.result !== b.result) {
                    return b.result - a.result;
                }
                if (a.makeUpExams !== b.makeUpExams) {
                    return a.makeUpExams - b.makeUpExams;
                }
                return a.name.localeCompare(b.name);
            })
        }
    );


    console.log(JSON.stringify(sortedExams));
}

var arr = ['Peter Jackson - Java : 350',
    'Jane - JavaScript : 200',
    'Jane     -    JavaScript :     300',
    'Jane P    -    JavaScript :     400',
    'Simon Cowell - PHP : 100',
    'Simon Cowell-PHP: 500',
    'Simon Cowell - PHP : 200'];

solve(arr);