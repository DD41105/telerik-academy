function solve(args) {
    let firstNum = parseFloat(args[0]);
    let secondNum = parseFloat(args[1]);
    let thirdNum = parseFloat(args[2]);

    if (firstNum === 0 || secondNum === 0 || thirdNum === 0) {
        console.log('0');
    }

    else if (firstNum < 0 && secondNum < 0 && thirdNum > 0) {
        console.log('+');
    }

    else if (secondNum < 0 && thirdNum < 0 && firstNum > 0) {
        console.log('+');
    }

    else if (firstNum < 0 && thirdNum < 0 && secondNum > 0) {
        console.log('+');
    }

    else if (firstNum > 0 && secondNum > 0 && thirdNum > 0) {
        console.log('+');
    }

    else if (firstNum < 0 && secondNum < 0 && thirdNum < 0) {
        console.log('-');
    }

    else if (firstNum < 0 && secondNum > 0 && thirdNum > 0) {
        console.log('-');
    }

    else if (firstNum > 0 && secondNum < 0 && thirdNum > 0) {
        console.log('-');
    }

    else if (firstNum > 0 && secondNum > 0 && thirdNum < 0) {
        console.log('-');
    }
}