function demo(input) {

    let array = JSON.parse(input);

    let outputArr = ["<table>"];
    outputArr.push(makeKeyRow(array));
    array.forEach((obj) => outputArr.push(makeValueRow(obj)));
    outputArr.push("</table>");

    function makeKeyRow(arr) {
        let line = '    <tr>';
        for (const [key, value] of Object.entries(arr[0])) {
            line += `<th>${escapeHtml(key)}</th>`;
        }
        line += '</tr>';
        return line;
    }
    function makeValueRow(obj) {
        let line = '    <tr>';
        for (const [key, value] of Object.entries(obj)) {
            line += `<td>${escapeHtml(value)}</td>`;
        }
        line += '</tr>'
        return line;
    };

    function escapeHtml(value) {
        return value
            .toString()
            .replace(/&/g, "&amp;")
            .replace(/</g, "&lt;")
            .replace(/>/g, "&gt;")
            .replace(/"/g, "&quot;")
            .replace(/'/g, "&#39;");
    };

    console.log(outputArr.join('\n'));
}

demo(`[{"Name":"Stamat",
"Score":5.5},
{"Name":"Rumen",
"Score":6}]`);