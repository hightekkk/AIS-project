<?php
    //Запускаем сессию
    session_start();
?>
 
<!DOCTYPE html>
<html>
    <head>
        <title>Междугородние пассажирские перевозки</title>
        <meta charset="utf-8">
        <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css" rel="stylesheet">
        <link rel="preconnect" href="https://fonts.googleapis.com">
        <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
        <link href="https://fonts.googleapis.com/css2?family=Source+Sans+Pro&display=swap" rel="stylesheet">
        <link rel="stylesheet" type="text/css" href="css/styles.css">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
        <script type="text/javascript">
    $(document).ready(function(){
        "use strict";
        //================ Проверка длины пароля ==================
        var password = $('input[name=password]');
         
        password.blur(function(){
            if(password.val() != ''){
 
                //Если длина введенного пароля меньше шести символов, то выводим сообщение об ошибке
                if(password.val().length < 6){
                    //Выводим сообщение об ошибке
                    $('#valid_password_message').text('Минимальная длина пароля 6 символов');
 
                    // Дезактивируем кнопку отправки
                    $('input[type=submit]').attr('disabled', true);
                     
                }else{
                    // Убираем сообщение об ошибке
                    $('#valid_password_message').text('');
 
                    //Активируем кнопку отправки
                    $('input[type=submit]').attr('disabled', false);
                }
            }else{
                $('#valid_password_message').text('Введите пароль');
            }
        });
    });
</script>
    </head>
    <body>
 
        <div id="header" class="header">
            <div class="menu">
                <ul>
                 <li><a href="/index1.php">Главная</a></li>
                 
                <?php
    //Проверяем авторизован ли пользователь
    if(!isset($_SESSION['email']) && !isset($_SESSION['password'])){
        // если нет, то выводим блок с ссылками на страницу регистрации и авторизации
?>
                 <li><a href="/form_register.php" id="link_register">Регистрация</a></li>
                 <li><a href="/form_auth.php" "link_auth">Авторизация</a></li>
<?php
    }else{
?>
                   <li><a href="/vivod.php">Мои билеты</a></li>
                   <li><a href="/logout.php" id="link_logout">Выход</a></li>
                </ul>
               
<?php
        //Если пользователь авторизован, то выводим ссылку Выход
    if (isset($_SESSION['email'])) {
?>
                <div class="avatar">
                <p>
                Привет, <strong>
<?php
echo $_SESSION['first_name'];}
?>
                </strong>
                </p>
                </div>
<?php
}
?>
            </div>
           <div id="auth_block">
</div>
</div>