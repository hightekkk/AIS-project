<?php
    session_start();
 
    require_once("dbconnect.php");
 
    $_SESSION["error_messages"] = '';
 
    $_SESSION["success_messages"] = '';
 
    if(isset($_POST["send"])){
 
        if(isset($_POST["captcha"])){
             
$captcha = trim($_POST["captcha"]);
 
if(!empty($captcha)){
 
    if(($_SESSION["rand"] != $captcha) && ($_SESSION["rand"] != "")){
         

        $_SESSION["error_messages"] =  "<p class='mesage_error'><strong>Ошибка!</strong> Вы ввели неправильную капчу </p>";
         
        header("HTTP/1.1 301 Moved Permanently");
        header("Location: ".$address_site."reset_password.php");
        exit();
    }
}else{
 
    $_SESSION["error_messages"] = "<p class='mesage_error'><strong>Ошибка!</strong> Поле для ввода капчи не должна быть пустой. </p>";
 
    header("HTTP/1.1 301 Moved Permanently");
    header("Location: ".$address_site."reset_password.php");
    exit();
}
 
 
if(isset($_POST["email"])){
 
    $email = trim($_POST["email"]);
 
    if(!empty($email)){
 
        $email = htmlspecialchars($email, ENT_QUOTES);
 
        $reg_email = "/^[a-z0-9][a-z0-9\._-]*[a-z0-9]*@([a-z0-9]+([a-z0-9-]*[a-z0-9]+)*\.)+[a-z]+/i";
 
        if( !preg_match($reg_email, $email)){
 
            $_SESSION["error_messages"] = "<p class='mesage_error' >Вы ввели неправильный email</p>";
             
            header("HTTP/1.1 301 Moved Permanently");
            header("Location: ".$address_site."reset_password.php");
 
            exit();
        }
    }else{
        $_SESSION["error_messages"] = "<p class='mesage_error' > <strong>Ошибка!</strong> Поле для ввода почтового адреса(email) не должна быть пустой.</p>";
         
        header("HTTP/1.1 301 Moved Permanently");
        header("Location: ".$address_site."reset_password.php");
        exit();
    }
     
}else{
    $_SESSION["error_messages"] = "<p class='mesage_error' > <strong>Ошибка!</strong> Отсутствует поле для ввода Email</p>";
     
    header("HTTP/1.1 301 Moved Permanently");
    header("Location: ".$address_site."reset_password.php");
 
    exit();
}
 
$result_query_select = $mysqli->query("SELECT email_status FROM `users` WHERE email = '".$email."'");
 
if(!$result_query_select){
     
    $_SESSION["error_messages"] = "<p class='mesage_error' > Ошибка запроса на выборки пользователя из БД</p>";
     
    header("HTTP/1.1 301 Moved Permanently");
    header("Location: ".$address_site."reset_password.php");
 
    exit();
 
}else{
 
    if($result_query_select->num_rows == 1){
 
        while(($row = $result_query_select->fetch_assoc()) !=false){
 
if((int)$row["email_status"] === 0){
 
    $_SESSION["error_messages"] = "<p class='mesage_error' ><strong>Ошибка!</strong> Вы не можете восстановить свой пароль, потому что указанный адрес электронной почты ($email) не подтверждён. </p><p>Для подтверждения почты перейдите по ссылке из письма, которую получили после регистрации.</p><p><strong>Внимание!</strong> Ссылка для подтверждения почты, действительна 24 часа с момента регистрации. Если Вы не подтвердите Ваш email в течении этого времени, то Ваш аккаунт будет удалён.</p>";
     
    header("HTTP/1.1 301 Moved Permanently");
    header("Location: ".$address_site."reset_password.php");
 
    exit();
 
}else{
    $token=md5($email.time());
 
    $query_update_token = $mysqli->query("UPDATE users SET reset_password_token='$token' WHERE email='$email'");
 
    if(!$query_update_token){
 
        $_SESSION["error_messages"] = "<p class='mesage_error' >Ошибка сохранения токена</p><p><strong>Описание ошибки</strong>: ".$mysqli->error."</p>";
         
        header("HTTP/1.1 301 Moved Permanently");
        header("Location: ".$address_site."reset_password.php");
 
        exit();
 
    }else{
 
        $link_reset_password = $address_site."set_new_password.php?email=$email&token=$token";
 
         $subject = "Восстановление пароля от сайта ".$_SERVER['HTTP_HOST'];
 
         $subject = "=?utf-8?B?".base64_encode($subject)."?=";
 
         $message = 'Здравствуйте! <br/> <br/> Для восстановления пароля от сайта <a href="http://'.$_SERVER['HTTP_HOST'].'"> '.$_SERVER['HTTP_HOST'].' </a>, перейдите по этой <a href="'.$link_reset_password.'">ссылке</a>.';
          
         $headers = "FROM: $email_admin\r\nReply-to: $email_admin\r\nContent-type: text/html; charset=utf-8\r\n";
          
         if(mail($email, $subject, $message, $headers)){
 
             $_SESSION["success_messages"] = "<p class='success_message' >Ссылка на страницу установки нового пароля, была отправлена на указанный E-mail ($email) </p>";
 
             header("HTTP/1.1 301 Moved Permanently");
             header("Location: ".$address_site."reset_password.php?hidden_form=1");
 
             exit();
 
         }else{
             $_SESSION["error_messages"] = "<p class='mesage_error' >Ошибка при отправлении письма на почту ".$email.", с сылкой на страницу установки нового пароля. </p>";
 
             header("HTTP/1.1 301 Moved Permanently");
             header("Location: ".$address_site."reset_password.php");
              
             exit();
         }
     }
} 
 
        }
 
    }else{
         
        $_SESSION["error_messages"] = "<p class='mesage_error' ><strong>Ошибка!</strong> Такой пользователь не зарегистрирован</p>";
         
        header("HTTP/1.1 301 Moved Permanently");
        header("Location: ".$address_site."reset_password.php");
 
        //Останавливаем скрипт
        exit();
    }
}
 
        }else{ 
            exit("<p><strong>Ошибка!</strong> Отсутствует проверочный код, то есть код капчи. Вы можете перейти на <a href=".$address_site."> главную страницу </a>.</p>");
        }
 
    }else{ 
        exit("<p><strong>Ошибка!</strong> Вы зашли на эту страницу напрямую, поэтому нет данных для обработки. Вы можете перейти на <a href=".$address_site."> главную страницу </a>.</p>");
    }
?>