<?php
    session_start();

    require_once("dbconnect.php");

    $_SESSION["error_messages"] = '';
     
    $_SESSION["success_messages"] = '';

    if(isset($_POST["btn_submit_auth"]) && !empty($_POST["btn_submit_auth"])){
    
        if(isset($_POST["captcha"])){
         
            $captcha = trim($_POST["captcha"]);
         
            if(!empty($captcha)){
         
                if(($_SESSION["rand"] != $captcha) && ($_SESSION["rand"] != "")){
                     
                    
         
                    $error_message = "<p class='mesage_error'><strong>Ошибка!</strong> Вы ввели неправильную капчу </p>";
         
                   
                    $_SESSION["error_messages"] = $error_message;
         
                    
                    header("HTTP/1.1 301 Moved Permanently");
                    header("Location: ".$address_site."/form_auth.php");
         
                
                    exit();
                }
         
            }else{
         
                $error_message = "<p class='mesage_error'><strong>Ошибка!</strong> Поле для ввода капчи не должна быть пустой. </p>";
         
            
                $_SESSION["error_messages"] = $error_message;
         
                
                header("HTTP/1.1 301 Moved Permanently");
                header("Location: ".$address_site."/form_auth.php");
         
                
                exit();
         
            }
         
         
            $email = trim($_POST["email"]);
            if(isset($_POST["email"])){
             
                if(!empty($email)){
                    $email = htmlspecialchars($email, ENT_QUOTES);
             
                   
                    $reg_email = "/^[a-z0-9][a-z0-9\._-]*[a-z0-9]*@([a-z0-9]+([a-z0-9-]*[a-z0-9]+)*\.)+[a-z]+/i";
             
                    
                    if( !preg_match($reg_email, $email)){
                      
                        $_SESSION["error_messages"] .= "<p class='mesage_error' >Вы ввели неправильный email</p>";
                         
                        
                        header("HTTP/1.1 301 Moved Permanently");
                        header("Location: ".$address_site."/form_auth.php");
             
                        
                        exit();
                    }
                }else{
                    
                    $_SESSION["error_messages"] .= "<p class='mesage_error' >Поле для ввода почтового адреса(email) не должна быть пустой.</p>";
                     
                 
                    header("HTTP/1.1 301 Moved Permanently");
                    header("Location: ".$address_site."/form_register.php");
             
                    exit();
                }
                 
             
            }
             
            if(isset($_POST["password"])){
 
                $password = trim($_POST["password"]);
             
                if(!empty($password)){
                    $password = htmlspecialchars($password, ENT_QUOTES);
             
                     
                }else{
                    $_SESSION["error_messages"] .= "<p class='mesage_error' >Укажите Ваш пароль</p>";
                     
                    header("HTTP/1.1 301 Moved Permanently");
                    header("Location: ".$address_site."/form_auth.php");
             
                    exit();
                }
                 
            }else{
                $_SESSION["error_messages"] .= "<p class='mesage_error' >Отсутствует поле для ввода пароля</p>";
                 
                header("HTTP/1.1 301 Moved Permanently");
                header("Location: ".$address_site."/form_auth.php");
             
                exit();
            }

            $query_delete_users = $mysqli->query("DELETE FROM `users` WHERE `email_status` = 0 AND `date_registration` < ( NOW() - INTERVAL 1 DAY )");
            if(!$query_delete_users){
             exit("<p><strong>Ошибка!</strong> Сбой при удалении просроченного аккаунта. Код ошибки: ".$mysqli->errno."</p>");
            }
 
 
            $query_delete_confirm_users = $mysqli->query("DELETE FROM `confirm_users` WHERE `date_registration` < ( NOW() - INTERVAL 1 DAY)");
            if(!$query_delete_confirm_users){
            exit("<p><strong>Ошибка!</strong> Сбой при удалении просроченного аккаунта(confirm). Код ошибки: ".$mysqli->errno."</p>");
            }

            $result_query_select = $mysqli->query("SELECT * FROM `users` WHERE email = '".$email."' AND password = '".$password."'");
             
            if(!$result_query_select){
                $_SESSION["error_messages"] .= "<p class='mesage_error' >Ошибка запроса на выборке пользователя из БД</p>";
                 
                header("HTTP/1.1 301 Moved Permanently");
                header("Location: ".$address_site."/form_auth.php");
             
                exit();
            }else{
             
                if($result_query_select->num_rows == 1){
                     
    while(($row = $result_query_select->fetch_assoc()) !=false){
         
        if((int)$row["email_status"] == 0){
 
            $_SESSION["error_messages"] = "<p class='mesage_error' >Вы зарегистрированы, но, Ваш почтовый адрес не подтверждён. Для подтверждения почты перейдите по ссылке из письма, которую получили после регистрации.</p>
                <p><strong>Внимание!</strong> Ссылка для подтверждения почты, действительна 24 часа с момента регистрации. Если Вы не подтвердите Ваш email в течении этого времени, то Ваш аккаунт будет удалён.</p>";
 
             
            header("HTTP/1.1 301 Moved Permanently");
            header("Location: ".$address_site."form_auth.php");
 
            exit();
 
        }else{
            $resultNames = $mysqli->query("SELECT last_name, first_name FROM users WHERE email = '".$email."'");
            foreach($resultNames as $row1){
                $_SESSION['last_name'] = $row['last_name'];
                $_SESSION['first_name'] = $row['first_name'];
            }
            $_SESSION['email'] = $email;
            $_SESSION['password'] = $password;
 
            header("HTTP/1.1 301 Moved Permanently");
            header("Location: ".$address_site."index1.php");
 
            exit();
        }
 
    }
                     
                    $resultNames = $mysqli->query("SELECT last_name, first_name FROM users WHERE email = '".$email."'");
                    foreach($resultNames as $row){
                        $_SESSION['last_name'] = $row['last_name'];
                        $_SESSION['first_name'] = $row['first_name'];
                    }
                    $_SESSION['email'] = $email;
                    $_SESSION['password'] = $password;
             
                    header("HTTP/1.1 301 Moved Permanently");
                    header("Location: ".$address_site."/index1.php");
             
                }else{
                     
                    $_SESSION["error_messages"] .= "<p class='mesage_error' >Неправильный логин и/или пароль</p>";
                     
                    header("HTTP/1.1 301 Moved Permanently");
                    header("Location: ".$address_site."/form_auth.php");
             
                    exit();
                }
            }
        }else{
            exit("<p><strong>Ошибка!</strong> Отсутствует проверочный код, то есть код капчи. Вы можете перейти на <a href=".$address_site."> главную страницу </a>.</p>");
        }

     
    }else{
        exit("<p><strong>Ошибка!</strong> Вы зашли на эту страницу напрямую, поэтому нет данных для обработки. Вы можете перейти на <a href=".$address_site."> главную страницу </a>.</p>");
    }