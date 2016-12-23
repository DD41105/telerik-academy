function solve(args) {
    let inputNum = +args[0];
    let canBeDivided;

    if (inputNum % 5 === 0 && inputNum % 7 === 0) {
        canBeDivided = true;
    }
    else {
        canBeDivided = false;
    }

    if (canBeDivided === true) {
        console.log(`true ${inputNum}`);
    }
    else {
        console.log(`false ${inputNum}`);
    }
}