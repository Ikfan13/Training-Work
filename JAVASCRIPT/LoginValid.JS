function checkData()
{
    let uid=document.getElementById("userid").value;
    if(uid.trim()==="")
        {
            document.getElementById("iderror").innerHTML="user id is required";
            document.getElementById("iderror").style.color="red";
        }
     else if(!uid.trim().match('[a-zA-Z]{3,20}$'))
     {
        document.getElementById("iderror").innerHTML="user id in proper format"
        document.getElementById("iderror").style.color="red";
     }   
     else
     {
        document.getElementById("iderror").innerHTML="";
     }
     let upass=document.getElementById("pass").value;

     if(upass.trim()==="")
        {
            document.getElementById("pwerror").innerHTML="user password is required";
            document.getElementById("pwerror").style.color="red";
           
        }
    else if(!upass.trim().match('(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$"'))
        {
            document.getElementById("pwerror").innerHTML="user password in proper format"
            document.getElementById("pwerror").style.color="red";
         }   
     else
     {
        document.getElementById("pwerror").innerHTML="";
     }    

}