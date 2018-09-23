/*******************************************************
 * Copyright (C) 2010-2011 FNSoftworks info@fnsoftworks.com
 * 
 * This file is part of UE4Server.
 * 
 * UE4Server can not be copied and/or distributed without the express
 * permission of FNSoftworks.
 *******************************************************/
<?php       

function get_client_ip() {
        $_SERVER = '';
        if (getenv('HTTP_CLIENT_IP'))
            $_SERVER = getenv('HTTP_CLIENT_IP');
        else if(getenv('HTTP_X_FORWARDED_FOR'))
            $_SERVER = getenv('HTTP_X_FORWARDED_FOR');
        else if(getenv('HTTP_X_FORWARDED'))
            $_SERVER = getenv('HTTP_X_FORWARDED');
        else if(getenv('HTTP_FORWARDED_FOR'))
            $_SERVER = getenv('HTTP_FORWARDED_FOR');
        else if(getenv('HTTP_FORWARDED'))
            $_SERVER = getenv('HTTP_FORWARDED');
        else if(getenv('REMOTE_ADDR'))
            $_SERVER = getenv('REMOTE_ADDR');
        else
            $_SERVER = 'UNKNOWN';
     
        return $_SERVER;
    }

        $Server = $_SERVER['REMOTE_ADDR'];           
        
        echo "{Content: \"".$Server."\"}";

?>