let regForExpression = /(^\-)?((\d+(\.\d+)?)\s*[+\-\/*])+(\d+(\.\d+)?)\s*\=$/gm;
let regForNumbers = /(^\-)?(\d+(\.\d+)?)/gm;
let regForOperations = /[+\-\/*]/gm;
function task2() {
    let str = getString();
    if (checkString(str)) {
        document.getElementById("result2").innerHTML="result: "+calcResult(getAllNumbers(str), getAllOperations(str)).toFixed(2);
    }
    else {
        document.getElementById("result2").innerHTML="wrong fomat, try again";
    }
};
function getString() {
    return document.getElementById("input-Task2").value;
}
function checkString(str) {
    let match = str.match(regForExpression);
    if(match ==null){
        return false;
    }
    else{
        return str.length ==match[0].length ?true:false;
    }
};
function getAllNumbers(str) {
    return str.match(regForNumbers);
};
function getAllOperations(str) {
    return str.match(regForOperations);
};
function calcResult(numbers, operations) {
    let result = parseFloat(numbers[0]);
    let j = 0;
    for (let i = 1; i < numbers.length; i++) {
        switch (operations[j]) {
            case "+":
                result += parseFloat(numbers[i]);
                break;
            case "-":
                result -= parseFloat(numbers[i]);
                break;
            case "*":
                result *= parseFloat(numbers[i]);
                break;
            case "\/":
                result /= parseFloat(numbers[i]);
                break;
            default:
                break;
        }
        j++;
    }
    return result;
}