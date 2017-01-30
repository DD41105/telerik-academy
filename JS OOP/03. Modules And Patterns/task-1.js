/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
    var TITLE_PATTERN = /^(?!.*\s{2}|.*\s$|^\s).+$/;
    var STUDENT_NAME_PATTERN = /^[A-Z][a-z]* [A-Z][a-z]*$/;
    var STUDENTS_MIN_COUNT = 1;
    var HOMEWORKS_MIN_COUNT = 1;

    var Course = {
        init: function (title, presentations) {
            validateTitle(title);
            validatePresentations(presentations);

            this._title = title;
            this._presentations = presentations;
            this._students = [];

            return this;
        },

        addStudent: function (name) {
            var id, names;
            validateStudentName(name);
            names = name.split(' ');

            id = this._students.length + 1;
            this._students.push({
                firstname: names[0],
                lastname: names[1],
                ID: id,
                homeworks: [],
                examResult: 0,
                totalScore: 0
            });

            return id;
        },

        getAllStudents: function () {
            var students;
            students = this._students.map(
                function (student) {
                    var studentInfo = {
                        firstname: student.firstname,
                        lastname: student.lastname,
                        id: student.ID
                    };
                    return studentInfo;
                }
            );

            return students;
        },

        submitHomework: function (studentID, homeworkID) {
            var student, course = this;

            validateHomeworkID(course, homeworkID);
            validateStudentID(course, studentID);

            student = this._students[studentID - 1];
            student['homeworks'].push(homeworkID);

            return this;
        },

        pushExamResults: function (results) {
            var students, student, course = this;

            validateExamResults(course, results);

            students = this._students;
            results.forEach(
                function (result) {
                    student = students[(result.StudentID - 1)];
                    student.examResults = result.score;
                });

            return this;
        },

        getTopStudents: function () {
            var topStudents, course = this;

            calculateTotalScore(course);

            topStudents = this._students.slice().sort(
                function (currentStudent, nextStudent) {
                    return currentStudent.totalScore < nextStudent.totalScore;
                }).slice(0, 9);

            return topStudents;
        }
    }

    function isNumber(num) {
        return !isNaN(parseFloat(num)) && Number.isFinite(num);
    }

    function isInteger(num) {
        return !isNaN(parseInt(num)) && num === parseInt(num);
    }

    function isString(value) {
        return typeof value === 'string';
    }

    function validateStringPattern(value, pattern, errorMsg) {
        errorMsg = errorMsg || 'Error.';
        if (!isString(value)) {
            throw new Error(errorMsg + ' Must be a string');
        }
        if (!pattern.test(value)) {
            throw new Error(errorMsg + ' Invalid format!');
        }
    }

    function validateTitle(title) {
        validateStringPattern(title, TITLE_PATTERN, 'Invalid title!');
    }

    function validatePresentations(presentations) {
        if (!Array.isArray(presentations)) {
            throw new Error('Presentations must be array');
        }
        if (presentations.length === 0) {
            throw new Error('No presentations provided. Empty array.');
        }

        presentations.forEach(function (title) {
            validateTitle(title);
        });
    }

    function validateStudentName(name) {
        validateStringPattern(name, STUDENT_NAME_PATTERN, 'Invalid student name.');
    }

    function isInRange(ID, rangeMin, rangeMax) {
        if (!(isInteger(ID) && isInteger(rangeMax) && isInteger(rangeMin))) {
            return false;
        }
        if (ID < rangeMin || ID > rangeMax) {
            return false;
        }

        return true;
    }

    function validateHomeworkID(course, homeworkID) {
        if (!isInRange(homeworkID, HOMEWORKS_MIN_COUNT, course._presentations.length)) {
            throw new Error('Invalid homework ID. No such student. Out of possible id range.');
        }
    }

    function validateStudentID(course, studentID) {
        if (!isInRange(studentID, STUDENTS_MIN_COUNT, course._students.length)) {
            throw new Error('Invalid student ID. No such stuent. Out of possible id range.');
        }
    }

    function validateExamResults(course, results) {
        var processedIDs = [];

        if (!Array.isArray(results)) {
            throw new Error('Results must be array');
        }

        results.forEach(function (result) {
            var isFoundDuplicateID;
            validateStudentID(course, result.StudentID);
            if (!isNumber(result.score)) {
                throw new Error('Score must be number!');
            }

            isFoundDuplicateID = processedIDs.some(
                function (id) {
                    return id == result.StudentID;
                });
            if (isFoundDuplicateID) {
                throw new Error('One student cannot submit exam results twice!');
            }

            processedIDs.push(result.StudentID);
        });
    }

    function calculateTotalScore(course) {
        var students = course._students,
            presentationsCount = course._presentations.length;

        students.forEach(function (student) {
            var homeworkResult = student.homeworks.length / presentationsCount;
            students.totalScore = (student.examResult * 0.75) + (homeworkResult * 0.25);
        });
    }

    return Course;
}


module.exports = solve;
