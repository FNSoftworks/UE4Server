/*******************************************************
 * Copyright (C) 2010-2011 FNSoftworks info@fnsoftworks.com
 * 
 * This file is part of UE4Server.
 * 
 * UE4Server can not be copied and/or distributed without the express
 * permission of FNSoftworks.
 *******************************************************/
<?php

        $IsHosted = $_REQUEST["IsHosted"];
	$MapName = $_REQUEST["MapName"];
        $ServerList = "";
	
	    $servername = "localhost";
        $username = "fullplug_msadmin";
        $password = "123Faru123*";
        $database = "fullplug_multiserver";
        
        $con = new mysqli($servername, $username, $password, $database);
	
	$sql = "SELECT * FROM Servers";
	$result = mysqli_query($con, $sql);
	if(mysqli_num_rows($result) > 0)
	{
		while($row = mysqli_fetch_assoc($result))
		{				
                        if($IsHosted == "0")
                        {
				if($row['MNP'] > $row['CNP'] && $row['MapName'] == $MapName)
				{
                                        $ServerList = $ServerList.$row['IP'].":".$row['PortNumber'].";";                                        
				}

                        }
                        else
                        {
                                if($row['CNP'] == "0" && $row['MNP'] != $row['CNP'] && $row['MapName'] == $MapName)
				{
                                        $ServerList = $ServerList.$row['IP'].":".$row['PortNumber'].";"; 
				}
                        }
		}
                echo "{Content: \"".$ServerList."\"}";
	}            
	else
	{
                 echo "{Content: \"No Server Found\"}";
	}

?>