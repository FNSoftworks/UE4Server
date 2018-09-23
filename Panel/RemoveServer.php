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
        
        $sql = "DELETE FROM Servers WHERE `IP` = '".$IP."' AND `PortNumber` = '".$PortNumber."'";
        
        
        $delquery = mysqli_query($con, $sql);
        
        if(delquery){
            $sql = "SELECT * FROM Object_Cloud";
            $result = mysqli_query($con, $sql);
                
                if(mysqli_num_rows($result) > 0)
                {
                        while($row = mysqli_fetch_assoc($result))
                        {			
                                $sql = "DELETE FROM Object_Cloud WHERE `ID` = '".$row['ID']."'";
                                mysqli_query($con, $sql);
                                $foo = True;
                        }                                          
                }
        }
        if(foo == TRUE){
            $sql = "SELECT * FROM Object_Combine";
                $result = mysqli_query($con, $sql);
                
                if(mysqli_num_rows($result) > 0)
                {
                        while($row = mysqli_fetch_assoc($result))
                        {			
                                $sql = "DELETE FROM Object_Combine WHERE `ID` = '".$row['ID']."'";
                                mysqli_query($con, $sql);                                
                        }                                          
                }
        }
	
?>