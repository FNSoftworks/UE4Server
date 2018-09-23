/*******************************************************
 * Copyright (C) 2010-2011 FNSoftworks info@fnsoftworks.com
 * 
 * This file is part of UE4Server.
 * 
 * UE4Server can not be copied and/or distributed without the express
 * permission of FNSoftworks.
 *******************************************************/
<?php
       
        $MapName = $_REQUEST["MapName"];

        $servername = "localhost";
        $username = "fullplug_msadmin";
        $password = "123Faru123*";
        $database = "fullplug_multiserver";
        
        $con = new mysqli($servername, $username, $password, $database);
        
        $sql = "INSERT INTO `DS_CreationRequest` (`RequestIndex`, `MapName`) VALUES (NULL, '$MapName')";
        mysqli_query($con, $sql);        

	echo "{Content: \"Game Posted\"}";

?>