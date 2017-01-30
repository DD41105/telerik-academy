/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function solve() {
	
	return function sum(arr) {
		if (arr === undefined) {
                throw 'Error';
            }
            if (!Array.isArray(arr)) {
                return null;
            }
            if (arr.length === 0) {
                return null;
            }

            var sum = 0, i, len = arr.length;

            for (i = 0; i < len; i+= 1) {
                if (isNaN(arr[i])) {
                    throw 'Error';
                }
                sum += parseFloat(arr[i]);
            }

            return sum;
	}
}

module.exports = solve;
