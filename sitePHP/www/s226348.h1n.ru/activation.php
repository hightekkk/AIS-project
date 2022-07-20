<?php
    require_once("header.php");
?>
<?php 
 
 
 
require_once("dbconnect.php");
 
 
 
if(isset($_GET['token']) && !empty($_GET['token'])){
 
    $token = $_GET['token'];
 
}else{
 
    exit("<p><strong>Ошибка!</strong> Отсутствует проверочный код.</p>");
 
}
 
 
 

if(isset($_GET['email']) && !empty($_GET['email'])){
 
    $email = $_GET['email'];
 
}else{
 
    exit("<p><strong>Ошибка!</strong> Отсутствует адрес электронной почты.</p>");
 
}

$query_delete_users = $mysqli->query("DELETE FROM `users` WHERE `email_status` = 0 AND `date_registration` < ( NOW() - INTERVAL 1 DAY )");
if(!$query_delete_users){
    exit("<p><strong>Ошибка!</strong> Сбой при удалении просроченного аккаунта. Код ошибки: ".$mysqli->errno."</p>");
}
 
 
$query_delete_confirm_users = $mysqli->query("DELETE FROM `confirm_users` WHERE `date_registration` < ( NOW() - INTERVAL 1 DAY)");
if(!$query_delete_confirm_users){
    exit("<p><strong>Ошибка!</strong> Сбой при удалении просроченного аккаунта(confirm). Код ошибки: ".$mysqli->errno."</p>");
}

$query_select_user = $mysqli->query("SELECT `token` FROM `confirm_users` WHERE `email` = '".$email."'");
 
if(($row = $query_select_user->fetch_assoc()) != false){
 
 
    if($query_select_user->num_rows == 1){
 
        if($token == $row['token']){
 
$query_update_user = $mysqli->query("UPDATE `users` SET `email_status` = 1 WHERE `email` = '".$email."'");
 
if(!$query_update_user){
 
    exit("<p><strong>Ошибка!</strong> Сбой при обновлении статуса пользователя. Код ошибки: ".$mysqli->errno."</p>");
 
}else{
 
    $query_delete = $mysqli->query("DELETE FROM `confirm_users` WHERE `email` = '".$email."'");
 
    if(!$query_delete){
 
        exit("<p><strong>Ошибка!</strong> Сбой при удалении данных пользователя из временной таблицы. Код ошибки: ".$mysqli->errno."</p>");
 
    }else{
 
        require_once("header.php");
 
            echo '<h1 class="success_message text_center">Почта успешно подтверждена!</h1>';
            echo '<p class="text_center">Теперь Вы можете войти в свой аккаунт.</p>';
 
        require_once("footer.php");
    }
 
    $query_delete->close();
}
 
$query_update_user->close();
 
        }else{
            exit("<p><strong>Ошибка!</strong> Неправильный проверочный код.</p>");
        }
 
    }else{
        exit("<p><strong>Ошибка!</strong> Такой пользователь не зарегистрирован </p>");
    }
 
}else{
   
    exit("<p><strong>Ошибка!</strong> Сбой при выборе пользователя из БД. </p>");
}
 
 
$query_select_user->close();
 
$mysqli->close();
 
?>
<?php
    require_once("footer.php");
?>