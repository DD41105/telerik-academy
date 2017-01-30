/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
    var library = (function () {
        var books = [];
        var categories = [];
        var filtered = [];

        //functions
        function listBooks() {
            var args = arguments[0];
            if (books.length === 0) {
                return [];
            }

            if (books.length === 1) {
                if (!args || books[0].category === args.category) {
                    return books;
                } else {
                    return [];
                }
            }

            if (args) {
                filtered = books.filter(function (b) {
                    return b.category === args.category;
                })
            } else {
                filtered = books;
            }

            return filtered.sort(function (a, b) {
                return a.ID - b.ID;
            });
        }

        function addBook(book) {
            if (book.title.length < 2 || book.title.length > 100) {
                throw Error('Invalid title length');
            }

            var bookSameTitle = books.filter(
               function (a) { return a.title === book.title }
               )[0];
            if (bookSameTitle) {
                throw Error('Already have a book with this title');
            }

            if (!book.author) {
                throw Error('Invalid author');
            }

            var sameISBN = books.filter(
                function (a) {return a.isbn === book.isbn}
                )[0];
            if (!validateISBN(book.isbn) || sameISBN) {
                throw Error('Invalid ISBN');
            }

            var newCategory = {
                category: book.category,
                ID: categories.length + 2
            }
            if (categories.length === 0) {
                categories.push(newCategory);
            }
            else if (categories && !categories.some(function (elem) {
					 return elem.category === newCategory.category;
            })) {
                categories.push(newCategory);
            }

            book.ID = books.length + 1;

            books.push(book);
            return book;
        }

        function listCategories() {
            categories.sort(function (a, b) {
                return a.id - b.id;
            });

            return categories.map(function (element) {
                return element.category;
            });
        }

        //helper functions
        function validateISBN(isbn) {
            var i, len = isbn.length;

            if (isbn.length !== 10 && isbn.length !== 13) {
                return false;
            }

            for (i = 0; i < len; i++) {
                if (!isNumeric(isbn[i])) {
                    return false;
                }
            }
            return true;
        }

        function isNumeric(obj) {
            return obj - parseFloat(obj) >= 0;
        }

        //the public interface of the module
        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
module.exports = solve;
