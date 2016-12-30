function solve(args) {
    let a = parseFloat(args[0]);
    let b = parseFloat(args[1]);
    let c = parseFloat(args[2]);
    let d = b * b - 4 * a * c; // discriminant
    let x1;
    let x2;

    if (d < 0) {
        console.log('no real roots');
    }
    else {
        if (d === 0) {
            x1 = x2 = -b / (2 * a);
            console.log('x1=x2=' + x1.toFixed(2));
        }
        else {
            x1 = (-b - Math.sqrt(d)) / (2 * a);
            x2 = (-b + Math.sqrt(d)) / (2 * a);

            if (x1 < x2) {
                console.log('x1=' + x1.toFixed(2) + '; x2=' + x2.toFixed(2));
            }
            else {
                console.log('x1=' + x2.toFixed(2) + '; x2=' + x1.toFixed(2));
            }
        }
    }
}