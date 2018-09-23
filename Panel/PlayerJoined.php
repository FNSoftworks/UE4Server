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
	
	    $servername = "localhost";
        $username = "fullplug_msadmin";
        $password = "123Faru123*";
        $database = "fullplug_multiserver";
        
        $con = new mysqli($servername, $username, $password, $database);
        
	$sql = "SELECT CNP FROM Servers WHERE `IP` = '".$IP."' AND `PortNumber` = '".$PortNumber."'";
	$result = mysqli_query($con, $sql);
	if(mysqli_num_rows($result) > 0)
        {
		$row = mysqli_fetch_assoc($result);
		
                $Sum = $row['CNP'] + 1;
                
                $sql = "UPDATE `Servers` SET `CNP` = '".$Sum."' WHERE `IP` = '".$IP."' AND `PortNumber` = '".$PortNumber."'";
                $result = mysqli_query($con, $sql);
                
                echo "{Content: \"Player Added\"}";
        }        

?>