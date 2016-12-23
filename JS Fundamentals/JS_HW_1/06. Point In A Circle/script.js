function solve(args) {
    let X = parseFloat(args[0]);
    let Y = parseFloat(args[1]);
    let radius = 2;
    let hypotenuse = Math.sqrt(Math.pow(X, 2) + Math.pow(Y, 2));

    if (hypotenuse > 2) {
        console.log('no' + ' ' + hypotenuse.toFixed(2));
    }
    else {
        console.log('yes' + ' ' + hypotenuse.toFixed(2));
    }
}