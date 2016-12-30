function solve(args) {
    var N = parseInt(args[0]);

    process.stdout.write('1');
    for (var i = 2; i <= N; i+=1) {
        process.stdout.write(' ' + i);
    }
}