function solve(args) {
    let number = parseInt(args[0]);
    let check = true;
    for(let i = 2; i <= Math.sqrt(Math.floor(number)); i+=1)
    {
        if (number % i === 0) {
            check = false;
            break;
        }
    }
    if (number <= 1) {
        check = false;
    }

    console.log(check);
}