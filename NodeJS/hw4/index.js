const fs = require('fs');

// Create file
fs.writeFile('employees.json', '{"name": "Employee 1 Name", "salary": 2000}', 'utf8', (err, data) => {
    if(err) console.log(err);
    else console.log('File Successfully created and data is written.');
})

// Read file
fs.readFile('employees.json', 'utf8', (err, data) => {
    if(err) console.log(err);
    else console.log(data);
})

// Update file
fs.appendFile('employees.json', '\n{"name": "Employee 2 Name", "salary": 4000}', 'utf8', (err, data) => {
    if(err) console.log(err);
    else console.log('File Successfully created and data is written.');
})

// Delete file
fs.unlink('employees.json', (err) => {
    if(err) console.log(err);
    else console.log('File Successfully deleted.');
})