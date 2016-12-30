function solve(args) {
    let max = parseFloat(args[0]);

    for (let i = 1; i < args.length; i++) {
        if (max < parseFloat(args[i])) {
            max = parseFloat(args[i]);
        }
    }
    console.log(max);
}
