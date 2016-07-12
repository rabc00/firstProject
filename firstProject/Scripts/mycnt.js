function lookMeUp()
{
   var data = document.getEleementById("search").value;
   data = data.toLowerCase();
   if(data == "brandon" || data == "john" || data == "martin" || data == "venkat" )
   {
       document.getElementById("outH").innerHTML = "<img href=../Images/>The Bear Says:";
       doument.getElementById("outC").innerHTML = data + " I will eat you <br/> Is a good idea to start running now";
   }
   else
   {
       document.getElementById("outH").innerHTML = "The Bear Says: ";
   }
}




function display_On()
{
    document.getElementById("mask").style.display = "block";
}