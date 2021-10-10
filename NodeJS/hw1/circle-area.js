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