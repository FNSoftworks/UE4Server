/*******************************************************
 * Copyright (C) 2010-2011 FNSoftworks info@fnsoftworks.com
 * 
 * This file is part of UE4Server.
 * 
 * UE4Server can not be copied and/or distributed without the express
 * permission of FNSoftworks.
 *******************************************************/
<?php

        $IP = $_REQUEST["IP"];
        $PortNumber = $_REQUEST["PortNumber"];  
        $MapName = $_REQUEST["MapName"]; 
        $MNP = $_REQUEST["MNP"]; 
		
        $servername = "localhost";
        $username = "fullplug_msadmin";
        $password = "123Faru123*";
        $database = "fullplug_multiserver";
        
        $con = new mysqli($servername, $username, $password, $database);
         
        $sql = "SELECT * FROM Servers WHERE `IP` = '".$IP."' AND `PortNumber` = '".$PortNumber."'";
        $result = mysqli_query($con, $sql);
        if(mysqli_num_rows($result) > 0)
        {
                $row = mysqli_fetch_assoc($result);
                
                echo "{Content: \"Server Exist\"}";
        }
        else
        {

			$sql = "INSERT INTO `Servers` (`ID`, `IP`, `PortNumber`, `MapName`, `CNP`, `MNP`) 
					 VALUES (NULL, '$IP', '$PortNumber', '$MapName', '0', '$MNP')";
			mysqli_query($con, $sql);
			
			echo "{Content: \"Server Created\"}";
                              
        }        

?>