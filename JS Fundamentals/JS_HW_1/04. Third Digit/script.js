function solve(args) {
    let digit = (args[0] / 100) % 10 | 0;
    let check = digit == 7;
    if (check) {
        console.log(check);
    }
    else {
        console.log('false' + " " + digit);
    }
}