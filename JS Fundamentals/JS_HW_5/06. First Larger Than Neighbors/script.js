function solve(args) {
    let numbers = args[1].split(' ').map(Number),
        counter = 0,
        len = numbers.length;

    for (let i = 1; i < len - 1; i += 1) {
        if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]) {
            return i;
        }
    }
    return -1;
}