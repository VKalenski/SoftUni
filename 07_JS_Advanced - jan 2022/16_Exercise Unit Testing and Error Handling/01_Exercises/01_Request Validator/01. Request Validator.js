function solve(obj) {
    let validMethods = ['GET', 'POST', 'DELETE', 'CONNECT'];
    let uriRegexPattern = /^([a-zA-Z0-9\.]+|\*)$/gm;
    let validVersion = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];
    let messageRegexPattern = /^[^<>\\&'"]*$/gm;

    if (!obj.method || !validMethods.includes(obj.method)) {
        throw new Error('Invalid request header: Invalid Method');
    }

    if (!(uriRegexPattern.test(obj.uri)) || obj.uri == undefined) {

        throw new Error('Invalid request header: Invalid URI');
    }

    if (!obj.version || !validVersion.includes(obj.version)) {
        throw new Error('Invalid request header: Invalid Version');
    }

    if (!(messageRegexPattern.test(obj.message)) || obj.message === undefined) {
        throw new Error('Invalid request header: Invalid Message');
    }

    return obj;
}

console.log(solve(
    {
        method: 'GET',
        uri: 'svn.public.catalog',
        version: 'HTTP/1.0',
        message: ''
    }
));

console.log(solve(
    {
        method: 'OPTIONS',
        uri: 'git.master',
        version: 'HTTP/1.1',
        message: '-recursive'
    }
));

console.log(solve(
    {
        method: 'POST',
        uri: 'home.bash',
        message: 'rm -rf /*'
    }

));