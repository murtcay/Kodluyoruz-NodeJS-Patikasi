## HW 3

* Create the **circle.js** file which includes circleArea and circleCircumference functions.
* Export the functions we created with the module.exports method.
* Access the functions from the **circle.js** file into the **index.js** file using "require and object destructuring". Then, call these functions with parameter value 5.

## Solution:

### circle.js

``` javascript
const circleArea = (radius) => {
    let r = Number(radius);
    if (!isNaN(r)) {
        if (r < 0)
            console.log(`Radius: ${r} and radius can't be negative.`);
        else
            console.log(`Radius: ${r} and circle area: ${Math.PI * r * r}.`);
    }
    else {
        console.log(`Radius: ${radius} is Not a Number`);
    }
}

const circleCircumference = (radius) => {
    let r = Number(radius);
    if (!isNaN(r)) {
        if (r < 0)
            console.log(`Radius: ${r} and radius can't be negative.`);
        else
            console.log(`Radius: ${r} and circle circumference: ${2 * Math.PI * r}.`);
    }
    else {
        console.log(`Radius: ${radius} is Not a Number`);
    }
}

module.exports = {circleArea, circleCircumference}

```

### index.js

``` javascript
const {circleArea, circleCircumference} = require('./circle');

circleArea(5);
circleCircumference(5);

```

### Example

``` console
[murtcay@murtcay NodeJS]$ node index.js
Radius: 5 and circle area: 78.53981633974483.
Radius: 5 and circle circumference: 31.41592653589793.
```