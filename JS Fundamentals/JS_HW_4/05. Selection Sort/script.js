function solve(args) {
    var i,
        j,
        minNumber,
        input = args[0].split('\n'),
        n = +input[0],             // numbers.length
        numbers = input.slice(1);  // copy the array from the first element => the numbers

    for (i = 0; i < n - 1; i += 1) {
        minNumber = +numbers[i];
        for (j = i + 1; j < n; j += 1) {
            if (+numbers[j] < minNumber) {
                minNumber = numbers[j];
                numbers[j] = numbers[i];
                numbers[i] = minNumber;
            }
        }

    }

    console.log(numbers.join('\n'));
}