function solve(args) {
    let circleX = parseFloat(args[0] - 1); // -1 because the center of the circle is not (0,0) but (1,1)
    let circleY = parseFloat(args[1] - 1); // same as above
    let rectX = parseFloat(args[0]);
    let rectY = parseFloat(args[1]);
    let radiusOfCircle = 1.5;
    let hypotenuse = Math.sqrt(Math.pow(circleX, 2) + Math.pow(circleY, 2));
    let insideCircle;
    let insideRect;

    if (hypotenuse <= radiusOfCircle) {
        insideCircle = 'inside circle';
    }
    else {
        insideCircle = 'outside circle';
    }

    if (rectX <= 5 && rectX >= -1 && rectY <= 1 && rectY >= -1) {
        insideRect = 'inside rectangle';
    }
    else {
        insideRect = 'outside rectangle';
    }

    console.log(insideCircle + ' ' + insideRect);
}