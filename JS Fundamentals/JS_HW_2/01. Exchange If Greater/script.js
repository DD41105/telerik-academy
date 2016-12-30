function solve(args) {
    let firstNum = parseFloat(args[0]);
    let secondNum = parseFloat(args[1]);
    let tempNum;

    if (firstNum > secondNum) {
        tempNum = firstNum;
        firstNum = secondNum;
        secondNum = tempNum;
    }

    console.log(firstNum + ' ' + secondNum);
}