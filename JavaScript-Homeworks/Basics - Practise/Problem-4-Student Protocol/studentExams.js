function solve(arr) {
    var input = arr;
    var name,
        lang,
        score;
    var exams = {};
    var sortedExams = {};
    for (var i = 0; i < arr.length; i++) {
        var inputName = arr[i].split('-');
        var inputData = inputName[1].split(':');
        name = inputName[0].trim();
        lang = inputData[0].trim();
        score = Number(inputData[1].trim());
        if (score < 0 || score > 400) {
            continue;
        }

        if (!exams[lang]) {
            exams[lang] = [];
        }
        var newStudent = {name: name, result: score, makeUpExams: 0};
        var isStudent = exams[lang].filter(function (el) {
            return el.name == name
        })[0];
        if (!isStudent) {
            exams[lang].push(newStudent);
        } else {
            isStudent.result = isStudent.result > score ? isStudent.result : score;
            isStudent.makeUpExams += 1;
        }
    }
    Object.keys(exams).forEach(function (entry) {
        sortedExams[entry] = exams[entry].sort(function (a, b) {
            if (a.result == b.result) {
                if(a.makeUpExams== b.makeUpExams){
                    return a.name.localeCompare(b.name);
                }
                return a.makeUpExams - b.makeUpExams;
            }
            return b.result - a.result;
        })
    });
    console.log(JSON.stringify(sortedExams));
}

var arr = [
    'Peter Jackson - Java : 350',
    'Jane - JavaScript : 100',
    'Jane     -    JavaScript :     200',
    'Aimon Cowell - JavaScript : 100',
    'Aimon Cowell-JavaScript: 500',
    'Aimon Cowell - JavaScript : 200'];

solve(arr);