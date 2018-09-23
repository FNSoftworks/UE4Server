/*******************************************************
 * Copyright (C) 2010-2011 FNSoftworks info@fnsoftworks.com
 * 
 * This file is part of UE4Server.
 * 
 * UE4Server can not be copied and/or distributed without the express
 * permission of FNSoftworks.
 *******************************************************/
<?php
  $Server_Name = $_REQUEST['ServerName'];
  
        $servername = "localhost";
        $username = "fullplug_msadmin";
        $password = "123Faru123*";
        $database = "fullplug_multiserver";
        
        $con = new mysqli($servername, $username, $password, $database);

    if ($con->connect_errno) {
        echo("Connect Error");
        exit();
        $con->close();
    } 
    else{
        echo("Connect Success");
        
    $sql = "INSERT INTO `Servers_Information` (`Name`) VALUES ('$Server_Name')"; 

    if($con->query($sql) === TRUE){
        echo("Insert Success");
    }
    else{
        echo("Insert Error");
    }
}


?>