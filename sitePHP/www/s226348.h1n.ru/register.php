<?php
    session_start();

    require_once("dbconnect.php");

    $_SESSION["error_messages"] = '';

    $_SESSION["success_messages"] = '';


    if(isset($_POST["btn_submit_register"]) && !empty($_POST["btn_submit_register"])){


        $captcha = trim($_POST["captcha"]);

        if(isset($_POST["captcha"]) && !empty($captcha)){

            if(($_SESSION["rand"] != $captcha) && ($_SESSION["rand"] != "")){
                
                $error_message = "<p class='mesage_error'><strong>Ошибка!</strong> Вы ввели неправильную капчу </p>";

                $_SESSION["error_messages"] = $error_message;

                header("HTTP/1.1 301 Moved Permanently");
                header("Location: ".$address_site."/form_register.php");

                exit();
            }


            if(isset($_POST["first_name"])){
                
                $first_name = trim($_POST["first_name"]);

                if(!empty($first_name)){
                    $first_name = htmlspecialchars($first_name, ENT_QUOTES);
                }else{
                    $_SESSION["error_messages"] .= "<p class='mesage_error'>Укажите Ваше имя</p>";

                    header("HTTP/1.1 301 Moved Permanently");
                    header("Location: ".$address_site."/form_register.php");

                    exit();
                }

                
            }else{
                $_SESSION["error_messages"] .= "<p class='mesage_error'>Отсутствует поле с именем</p>";

                header("HTTP/1.1 301 Moved Permanently");
                header("Location: ".$address_site."/form_register.php");

                exit();
            }

            
            if(isset($_POST["last_name"])){

                $last_name = trim($_POST["last_name"]);

                if(!empty($last_name)){
                    $last_name = htmlspecialchars($last_name, ENT_QUOTES);
                }else{

                    $_SESSION["error_messages"] .= "<p class='mesage_error'>Укажите Вашу фамилию</p>";
                    
                    header("HTTP/1.1 301 Moved Permanently");
                    header("Location: ".$address_site."/form_register.php");

                    exit();
                }

                
            }else{

                $_SESSION["error_messages"] .= "<p class='mesage_error'>Отсутствует поле с фамилией</p>";
                
                header("HTTP/1.1 301 Moved Permanently");
                header("Location: ".$address_site."/form_register.php");

                exit();
            }

            
            if(isset($_POST["email"])){

                $email = trim($_POST["email"]);

                if(!empty($email)){


                    $email = htmlspecialchars($email, ENT_QUOTES);


                    $reg_email = "/^[a-z0-9][a-z0-9\._-]*[a-z0-9]*@([a-z0-9]+([a-z0-9-]*[a-z0-9]+)*\.)+[a-z]+/i";

                    if( !preg_match($reg_email, $email)){
                        $_SESSION["error_messages"] .= "<p class='mesage_error' >Вы ввели неправельный email</p>";
                        
                        header("HTTP/1.1 301 Moved Permanently");
                        header("Location: ".$address_site."/form_register.php");

                        exit();
                    }

                    $result_query = $mysqli->query("SELECT `email` FROM `users` WHERE `email`='".$email."'");
                    
                    if($result_query->num_rows == 1){

                        if(($row = $result_query->fetch_assoc()) != false){
                            
                                $_SESSION["error_messages"] .= "<p class='mesage_error' >Пользователь с таким почтовым адресом уже зарегистрирован</p>";
                                
                                header("HTTP/1.1 301 Moved Permanently");
                                header("Location: ".$address_site."/form_register.php");
                            
                        }else{
                            $_SESSION["error_messages"] .= "<p class='mesage_error' >Ошибка в запросе к БД</p>";
                            
                            header("HTTP/1.1 301 Moved Permanently");
                            header("Location: ".$address_site."/form_register.php");
                        }

                        $result_query->close();

                       
                        exit();
                    }

                    $result_query->close();
                }else{
                    $_SESSION["error_messages"] .= "<p class='mesage_error'>Укажите Ваш email</p>";
                    
                    header("HTTP/1.1 301 Moved Permanently");
                    header("Location: ".$address_site."/form_register.php");

                    exit();
                }

            }else{
                $_SESSION["error_messages"] .= "<p class='mesage_error'>Отсутствует поле для ввода Email</p>";
                
                header("HTTP/1.1 301 Moved Permanently");
                header("Location: ".$address_site."/form_register.php");

                exit();
            }

            
            if(isset($_POST["password"])){

                $password = trim($_POST["password"]);

                if(!empty($password)){
                    $password = htmlspecialchars($password, ENT_QUOTES);

                    
                }else{
                    $_SESSION["error_messages"] .= "<p class='mesage_error'>Укажите Ваш пароль</p>";
                    
                    header("HTTP/1.1 301 Moved Permanently");
                    header("Location: ".$address_site."/form_register.php");

                    exit();
                }

            }else{
                $_SESSION["error_messages"] .= "<p class='mesage_error'>Отсутствует поле для ввода пароля</p>";
                
                header("HTTP/1.1 301 Moved Permanently");
                header("Location: ".$address_site."/form_register.php");

                exit();
            }
            

            if(isset($_POST["mobile"])){

                $mobile = trim($_POST["mobile"]);

                if(!empty($mobile)){
                    $mobile = htmlspecialchars($mobile, ENT_QUOTES);
                }else{

                    $_SESSION["error_messages"] .= "<p class='mesage_error'>Укажите Ваш телефон</p>";
                    
                    header("HTTP/1.1 301 Moved Permanently");
                    header("Location: ".$address_site."/form_register.php");

                    exit();
                }

                
            }else{

                $_SESSION["error_messages"] .= "<p class='mesage_error'>Отсутствует поле с телефоном</p>";
                
                header("HTTP/1.1 301 Moved Permanently");
                header("Location: ".$address_site."/form_register.php");

                exit();
            }
            $query_delete_users = $mysqli->query("DELETE FROM `users` WHERE `email_status` = 0 AND `date_registration` < ( NOW() - INTERVAL 1 DAY )");
            if(!$query_delete_users){
             exit("<p><strong>Ошибка!</strong> Сбой при удалении просроченного аккаунта. Код ошибки: ".$mysqli->errno."</p>");
            }
            $result_query_insert = $mysqli->query("INSERT INTO `users` (first_name, last_name, email, password, mobile, date_registration) VALUES ('".$first_name."', '".$last_name."', '".$email."', '".$password."', '".$mobile."', NOW())");

            if(!$result_query_insert){
                $_SESSION["error_messages"] .= "<p class='mesage_error' >Ошибка запроса на добавления пользователя в БД</p>";
                
                header("HTTP/1.1 301 Moved Permanently");
                header("Location: ".$address_site."/form_register.php");

                exit();
            }else{
            $query_delete_confirm_users = $mysqli->query("DELETE FROM `confirm_users` WHERE `date_registration` < ( NOW() - INTERVAL 1 DAY)");
            if(!$query_delete_confirm_users){
             exit("<p><strong>Ошибка!</strong> Сбой при удалении просроченного аккаунта(confirm). Код ошибки: ".$mysqli->errno."</p>");
            }
                $token=md5($email.time());
 
                $query_insert_confirm = $mysqli->query("INSERT INTO `confirm_users` (email, token, date_registration) VALUES ('".$email."', '".$token."', NOW()) ");
 
                if(!$query_insert_confirm){
                $_SESSION["error_messages"] .= "<p class='mesage_error' >Ошибка запроса на добавления пользователя в БД (confirm)</p>";
     
                 header("HTTP/1.1 301 Moved Permanently");
                 header("Location: ".$address_site."form_register.php");
 
                 exit();
            }else{
 
                $subject = "Подтверждение почты на сайте ".$_SERVER['HTTP_HOST'];
 
                 $subject = "=?utf-8?B?".base64_encode($subject)."?=";
 
                 $message = 'Здравствуйте! <br/> <br/> Сегодня '.date("d.m.Y", time()).', неким пользователем была произведена регистрация на сайте <a href="'.$address_site.'">'.$_SERVER['HTTP_HOST'].'</a> используя Ваш email. Если это были Вы, то, пожалуйста, подтвердите адрес вашей электронной почты, перейдя по этой ссылке: <a href="'.$address_site.'activation.php?token='.$token.'&email='.$email.'">'.$address_site.'activation/'.$token.'</a> <br/> <br/> В противном случае, если это были не Вы, то, просто игнорируйте это письмо. <br/> <br/> <strong>Внимание!</strong> Ссылка действительна 24 часа. После чего Ваш аккаунт будет удален из базы.';
     
                $headers = "FROM: $email_admin\r\nReply-to: $email_admin\r\nContent-type: text/html; charset=utf-8\r\n";
     
                if(mail($email, $subject, $message, $headers)){
                 $_SESSION["success_messages"] = "<h4 class='success_message'><strong>Регистрация прошла успешно!!!</strong></h4><p class='success_message'> Теперь необходимо подтвердить введенный адрес электронной почты. Для этого, перейдите по ссылке указанную в сообщение, которую получили на почту ".$email." </p>";
 
                header("HTTP/1.1 301 Moved Permanently");
                header("Location: ".$address_site."form_register.php?hidden_form=1");
                exit();
 
            }else{
                $_SESSION["error_messages"] .= "<p class='mesage_error' >Ошибка при отправлении письма с сылкой подтверждения, на почту ".$email." </p>";
                 }
 
    $result_query_insert->close();
 
    $query_insert_confirm->close();
}
            }

            $mysqli->close();
 
            header("HTTP/1.1 301 Moved Permanently");
            header("Location: ".$address_site."form_register.php?hidden_form=1");
            exit();
            
        }else{
            exit("<p><strong>Ошибка!</strong> Отсутствует проверечный код, то есть код капчи. Вы можете перейти на <a href=".$address_site."> главную страницу </a>.</p>");
        }

    }else{

        exit("<p><strong>Ошибка!</strong> Вы зашли на эту страницу напрямую, поэтому нет данных для обработки. Вы можете перейти на <a href=".$address_site."> главную страницу </a>.</p>");
    }
?>