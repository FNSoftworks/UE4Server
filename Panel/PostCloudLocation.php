/*******************************************************
 * Copyright (C) 2010-2011 FNSoftworks info@fnsoftworks.com
 * 
 * This file is part of UE4Server.
 * 
 * UE4Server can not be copied and/or distributed without the express
 * permission of FNSoftworks.
 *******************************************************/
<?php
  $CloudAR_Pin = $_REQUEST['CloudARPin'];
  $Location_X = $_REQUEST['LocationX'];
  $Location_Y = $_REQUEST['LocationY'];
  $Location_Z = $_REQUEST['LocationZ'];
  $Rotation_Roll = $_REQUEST['RotationRoll'];
  $Rotation_Pitch = $_REQUEST['RotationPitch'];
  $Rotation_Yaw = $_REQUEST['RotationYaw'];
  $Scale_X = $_REQUEST['ScaleX'];
  $Scale_Y = $_REQUEST['ScaleY'];
  $Scale_Z = $_REQUEST['ScaleZ'];
  
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
        
    $sql = "INSERT INTO `Object_Cloud` (`CloudAR_Pin`,`Location_X`,`Location_Y`,`Location_Z`,`Rotation_Roll`,`Rotation_Pitch`,`Rotation_Yaw`,`Scale_X`,`Scale_Y`,`Scale_Z`) VALUES ('$CloudAR_Pin','$Location_X', '$Location_Y', '$Location_Z', '$Rotation_Roll', '$Rotation_Pitch', '$Rotation_Yaw', '$Scale_X','$Scale_Y','$Scale_Z')"; 

    if($con->query($sql) === TRUE){
        echo("Insert Success");
    }
    else{
        echo("Insert Error");
    }
}


?>