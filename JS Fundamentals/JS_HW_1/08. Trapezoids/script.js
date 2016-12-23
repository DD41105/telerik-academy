function solve(args) {
    let a = parseFloat(args[0]);
    let b = parseFloat(args[1]);
    let h = parseFloat(args[2]);
    let area = h * ((a + b) / 2);
    console.log(area.toFixed(7));
}