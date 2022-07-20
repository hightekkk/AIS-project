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
$query_select_user = $mysqli->query("SELECT reset_password_token FROM `users` WHERE `email` = '".$email."'");
if(($row = $query_select_user->fetch_assoc()) != false){
     
    if($query_select_user->num_rows == 1){
        if($token == $row['reset_password_token']){
 
            require_once("header.php");
?>
 
           
 
 <h2 id="fr">Установка нового пароля</h2>
 
            <div class="center_block" id="form_register">
                                     
                 
                
                <form action="update_password.php" method="post">
                    <table class="table auth">
                        <tr>
                            <td> Введите новый пароль: </td>
                            <td>
                                <input type="password" name="password" placeholder="минимум 6 символов" required="required" /><br />
                                <span id="valid_password_message" class="mesage_error"></span>
                            </td>
                        </tr>
                        <tr>
                            <td> Повторите пароль: </td>
                            <td>
                                <input type="password" name="confirm_password" placeholder="минимум 6 символов" required="required" /><br />
                                <span id="valid_confirm_password_message" class="mesage_error"></span>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" id="butreg">
                                <input type="hidden" name="token" value="<?=$token?>">
                                <input type="hidden" name="email" value="<?=$email?>">
                                <input type="submit" name="set_new_password" value="Изменить пароль" class="btn" />
                            </td>
                        </tr>
                    </table>
                </form>
            </div>
<?php
            
            require_once("footer.php");
 
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