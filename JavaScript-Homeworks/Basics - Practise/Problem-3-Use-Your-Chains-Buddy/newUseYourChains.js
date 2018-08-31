function solve(arr) {
    var myRegexp = /<p>([\S\s]*?)<\/p>/g;
    var match = myRegexp.exec(arr[0]);
    var text = '';
    while (match != null) {
        // matched text: match[0]
        // match start: match.index
        text+= match[1];
        match = myRegexp.exec(arr[0]);
    }
    var result = text.replace(/[^a-z0-9]/g, ' ').replace(/\s+/g, ' ');
    var output = '';

    for (var i = 0; i < result.length; i++) {
        var symbol = result[i].charCodeAt(0);
        if (symbol >= 97 && symbol <= 109) {
            symbol += 13;
        }else if (symbol >= 110 && symbol <= 122){
            symbol -=13;
        }
        output+= String.fromCharCode(symbol);
    }
    console.log(output)
}

var arr = ['<html><head><title></title></head><body><h1>hello</h1><p>znahny!@#%&&&&****</p><div><button>dsad</button></div><p>grkg^^^^%%%)))([]12</p></body></html>'];

solve(arr);