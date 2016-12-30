function solve(args) {
    let firstNum = parseFloat(args[0]);
    let secondNum = parseFloat(args[1]);
    let thirdNum = parseFloat(args[2]);

    if (firstNum > secondNum && firstNum > thirdNum) {
        console.log(firstNum);
    }
    else if (secondNum > firstNum && secondNum > thirdNum) {
        console.log(secondNum);
    }
    else {
        console.log(thirdNum);
    }
}