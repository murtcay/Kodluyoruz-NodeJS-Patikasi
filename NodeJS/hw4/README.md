## HW 4

We will make CRUD operations using Node.js **fs** module.

* Create **employees.json** file, and add the data  {"name": "Employee 1 Name", "salary": 2000} into this file. (CREATE)
* Read file. (READ)
* Update file. (UPDATE)
* Delete file. (DELETE)

## Solution:

### CREATE and Write

``` javascript
fs.writeFile('employees.json', '{"name": "Employee 1 Name", "salary": 2000}', 'utf8', (err, data) => {
    if(err) console.log(err);
    else console.log('File Successfully created and data is written.');
})
```

### READ
``` javascript
fs.readFile('employees.json', 'utf8', (err, data) => {
    if(err) console.log(err);
    else console.log(data);
})
```

### UPDATE
``` javascript
fs.appendFile('employees.json', '\n{"name": "Employee 2 Name", "salary": 4000}', 'utf8', (err, data) => {
    if(err) console.log(err);
    else console.log('File Successfully created and data is written.');
})
```

### DELETE
``` javascript
fs.unlink('employees.json', (err) => {
    if(err) console.log(err);
    else console.log('File Successfully deleted.');
})
```