(function stringExtension() {

    String.prototype.ensureStart = function (str) {

        return !this.toString().startsWith(str) ? str + this.toString() : this.toString();
    }

    String.prototype.ensureEnd = function (str) {

        return !this.toString().endsWith(str) ? this.toString() + str : this.toString();
    }

    String.prototype.isEmpty = function () {

        return this.length === 0 ? true : false;
    }

    String.prototype.truncate = function (n) {
        if (Number(n) < 4) {
            return ".".repeat(Number(n));
        }

        if (Number(n) >= this.length) {
            return this.toString();
        }

        let lastWhitespace = this.toString().substring(0, n - 2).lastIndexOf(" ");

        return lastWhitespace !== -1
            ? `${this.toString().substring(0, lastWhitespace)}...`
            : `${this.toString().substring(0, n - 3)}...`;
    }

    String.format = function (string, ...params) {

        for (let i = 0; i < params.length; i++) {
            string = string.replace(`{${i}}`, params[i]);
        }

        return string;
    }
})();

let str = 'mystring';
str = str.ensureStart('my');
str = str.ensureStart('hello');
str = str.truncate(18);
str = str.truncate(12);
str = str.truncate(8);
str = str.truncate(4);
str = str.truncate(2);
str = String.format('The {0} {1} fox',
    'quick', 'brown');
str = String.format('jumps {0} {1}',
    'dog');