function solve(arr){
    var str = arr.join("");
    var pat = /<a.*?href\s*=\s*(["'])(.*?)\1[\S\s]*?>[\S\s]*?<\/a>/g;
    var match;

    while (match = pat.exec(str)) {

        console.log(match[2]);
    }

    //console.log(match);
}
var arr = ['<a href="http://softuni.bg" class="new"></a>'];
solve(arr);