var readline = require('readline');
var rl = readline.createInterface(process.stdin, process.stdout);

function calcKnots(kmPerHour){
    if (isNaN(kmPerHour)){
        return ("Invalid parameter")
    }

    var result = kmPerHour * 0.539956803455724;
    return result.toFixed(2) + ' knot(s)';
}

process.stdout.write('\nTo exit type [exit] \n\r\n\r');

rl.setPrompt('Enter speed [km/h] > ');
rl.prompt();
rl.on('line', function(line) {
    if (line === "exit") rl.close();
    console.log(calcKnots(Number(line)));
    rl.prompt();

}).on('close',function(){
    process.exit(0);
});