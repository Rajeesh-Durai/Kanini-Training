var heightInp = document.querySelector(".height");
var weightInp = document.querySelector(".weight");
var calcBtn = document.querySelector(".calculate");
var result = document.querySelector(".result");
var statement = document.querySelector(".result-statement");
var BMI, height, weight;

calcBtn.addEventListener("click", ()=>{
    height = heightInp.value;
    weight = weightInp.value;
    BMI = weight/(height**2); 
    result.innerHTML = BMI;
    if(BMI < 18.5){
        statement.innerHTML = "Your BMI falls within the underweight range";    
    }else if((BMI > 18.5) && (BMI <= 24.9)){
        statement.innerHTML = "Your BMI falls within the normal or healthy weight range";
    }else if((BMI >= 25) && (BMI <= 29.9 )){
        statement.innerHTML = "Your BMI falls within the overweight range";
    }else{
        statement.innerHTML = "Your BMI falls within the obese range";
    }
});