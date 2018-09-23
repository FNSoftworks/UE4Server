/*******************************************************
 * Copyright (C) 2010-2011 FNSoftworks info@fnsoftworks.com
 * 
 * This file is part of UE4Server.
 * 
 * UE4Server can not be copied and/or distributed without the express
 * permission of FNSoftworks.
 *******************************************************/
<?php
	
        $servername = "localhost";
        $username = "fullplug_msadmin";
        $password = "123Faru123*";
        $database = "fullplug_multiserver";
        
        $con = new mysqli($servername, $username, $password, $database);

        if ($con->connect_errno) {
            echo("Connection ERROsR");
            exit();
            $con->close();
        } 
        else
        {
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
                else
                {
                        echo "";                
                }
        }
	
?>