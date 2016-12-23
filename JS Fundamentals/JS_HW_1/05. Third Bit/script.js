function solve(args) {
    let number = parseInt(args[0]);
    let p = 3;
    let mask = 1 << p;
    let result = number & mask;
    let bit = result >> p;
    console.log(bit);
}