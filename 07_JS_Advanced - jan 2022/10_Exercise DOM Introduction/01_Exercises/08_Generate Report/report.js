function generateReport() {
    let checkedBoxes = document.querySelectorAll('thead tr th input');
    let allTableData = document.querySelectorAll('tbody tr');
    let outputTextArea=document.getElementById('output');
    let output=[];
   

    for (let i = 0; i < allTableData.length; i++) {
        let objRow = {};
        let values = Array.from(allTableData[i].getElementsByTagName('td')).map(el => el.textContent);

        for (let y = 0; y < checkedBoxes.length; y++) {
            if(checkedBoxes[y].checked){
              objRow[checkedBoxes[y].name] = values[y];
              console.log(objRow);
            }
        }
        
        output.push(objRow);
    }
    
    outputTextArea.value = JSON.stringify(output, null, 2);
}