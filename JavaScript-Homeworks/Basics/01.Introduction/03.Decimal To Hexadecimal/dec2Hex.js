function calculateDec2Hex() {
    var result;
    var number = prompt("Please enter your number:");
    while(isNaN(number) || number <= 0){
        number = prompt("Please enter a positive Number!");
    }
    result = parseInt(number);
    alert("The Hexadecimal Number is: " + result.toString(16));
}
window.onload = calculateDec2Hex();