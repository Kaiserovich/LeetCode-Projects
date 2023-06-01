/*2703. Return Length of Arguments Passed*/
/*1*/
var argumentsLength = function (...args) {
    return args.length;
};
/*2*/
var argumentsLength = function (...args) {
    let count = 0;
    for (let i = 0; i < args.length; i++)
        count++
    return count;
};
/*2667. Create Hello World Function*/
var createHelloWorld = function () {
    return function () {
        return "Hello World"
    }
};

