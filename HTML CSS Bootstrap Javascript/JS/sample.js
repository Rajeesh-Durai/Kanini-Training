function f1(x,y)
           {
           // document.getElementById("para1").innerHTML="Welcome";
           //document.write("welcome");
          //window.alert("Welcome")
         //alert("Welcome");
           // document.getElementById("para1").innerHTML=x+y;
           var ans=x+y;
           return ans;
           
           /* {
                document.getElementById("para2").innerHTML=x-y;
            }*/
           }
function f2(){
const stud={rno:100, name:'AAA', address:'17,sfijnvf'}         
document.getElementById("para1").innerHTML=stud.rno+' '+stud.name+' '+stud.address;
stud.rno=200;
document.getElementById("para1").innerHTML=stud.rno+' '+stud.name+' '+stud.address;
stud={e1:112}
document.getElementById("para1").innerHTML=stud.e1;
}  
function f3(){
  num=[1,2,3];
 // alert(num[2]);
  num[2]=123;
  alert(num[2]);
}
function regex(){
  let pattern="visit w3school";
  let input="5";
  if(input.match(pattern)==-1)
  {
    document.getElementById("para").style.display="block";
    //document.getElementById("para1").innerHTML="pattern doesn't match!!";
  }
  else
  alert(pattern.search(input)); 
}