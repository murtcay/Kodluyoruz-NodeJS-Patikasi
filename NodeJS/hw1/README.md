## HW 1

As we all know from Mathematics lessons, Area of ​​a Circle = π x r2. In the Node.JS Javascript runtime, we will try to find the area by entering the radius value from the console as a parameter. The console output should be: Radius: (Radius) and circle area: (Area).

## Solution:

``` javascript
const arguments = process.argv.slice(2);

function calcCircleArea(radius) {
    let r = Number(radius);
    if(!isNaN(r))
    {
        if(r < 0)
            console.log(`Radius: ${r} and radius can't be negative.`);
        else
            console.log(`Radius: ${r} and circle area: ${Math.PI*r*r}.`);
    }
    else
    {
        console.log(`Radius: ${radius} is Not a Number`);
    }
}

calcCircleArea(arguments[0]);
```

## Example Usage:
Run [circle-area.js](circle-area.js) file witth node.
``` shell
    [murtcay@murtcay NodeJS]$ node node circle-area.js 4
    Radius: 4 and circle area: 50.26548245743669.
```