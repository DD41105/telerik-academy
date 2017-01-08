function solve(args) {
    let arr = [...args].map(Number),
        count = 0,
        maxcount = 0;


    for (let i = 0; i < arr.length - 1; i += 1) {
        if (arr[i] < arr[i + 1]) {
            count += 1;
        }
        else{
            maxcount = Math.max(count, maxcount);
            count = 1;
        }
    }
    console.log(maxcount);
}