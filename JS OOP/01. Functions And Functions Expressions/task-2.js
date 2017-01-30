/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function solve() {
	return function findPrimeNumbers(start, end) {
			if (start === undefined || end === undefined) {
				throw 'Error';
			}
			if (isNaN(start) || isNaN(end)) {
				throw 'Error';
			}

			var primeNumbers = [], number, i;

			for (number = parseInt(start) ; number <= parseInt(end) ; number += 1) {
				if (number <= 1) {
					continue;
				}

				var maxDivider = Math.sqrt(number);
				var isPrime = true;

				for (i = 2; i <= maxDivider; i++) {
					if (number % i === 0) {
						isPrime = false;
						break;
					}
				}

				if (isPrime) {
					primeNumbers.push(number);
				}
			}

			return primeNumbers;
		}
}

module.exports = solve;
