/*******************************************************
 * Copyright (C) 2010-2011 FNSoftworks info@fnsoftworks.com
 * 
 * This file is part of UE4Server.
 * 
 * UE4Server can not be copied and/or distributed without the express
 * permission of FNSoftworks.
 *******************************************************/
<?php
$LocationList = "";
        $servername = "localhost";
        $username = "fullplug_msadmin";
        $password = "123Faru123*";
        $database = "fullplug_multiserver";

$con = new mysqli($servername, $username, $password, $database);

if ($mysqli->connect_error) 
{
    echo(json_encode(array('status'=>"Connection failed: " . $mysqli->connect_error)));
	die;
} 

$query = "SELECT Status FROM Object_Combine ORDER by ID desc limit 0, 1";  



//prepare the query statement
if ($stmt = mysqli_prepare($con,$query))
{

	//execute statment
	
	mysqli_stmt_execute($stmt);
	
	//bind the results of the query into variables
	
	mysqli_stmt_bind_result($stmt, $Status);
	
	//fetch the result values

        // here i am looping through the results as there is more than one row
	while (mysqli_stmt_fetch($stmt))
		
		{
				
                        // here i am creating an array to hold all the results of the query which is an array itself 
			$objectInformationArray[] =array('Status'=>$Status);
		
		}

                // finally we send the $serverStatusArray back to unreal and encode it as json
		echo json_encode(array('ObjectInfoQueryResults'=>$objectInformationArray));
}

  /* close the statement */
  mysqli_stmt_close($stmt);


  /* close the database connection */
  mysqli_close($con);
?>