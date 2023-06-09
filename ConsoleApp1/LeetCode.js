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

/*2621. Sleep*/
async function sleep(millis) {
    new Promise(resolve => setTimeout(resolve, millis));
}

/*2619. Array Prototype Last*/
/*1*/
Array.prototype.last = function () {
    if (this.length === 0) {
        return -1;
    }
    else {
        return this[this.length - 1];
    }
};
/*2*/
Array.prototype.last = function () {
    return this.length ? this[this.length - 1] : -1;
};
/*3*/
Array.prototype.last = function () {
    return this[this.length - 1] ?? -1;
};