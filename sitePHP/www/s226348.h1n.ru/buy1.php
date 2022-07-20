<?php
    session_start();
    require_once("dbconnect.php");
    
$reis = $_POST['id_marsh'];
$reis1 = $_POST['id_reisa'];
$number = $_POST['number'];
$avto = $_POST['avto'];
$mesto = $_POST['mestost'];
$otkuda = $_POST['otkuda'];
$kuda = $_POST['kuda'];
$last_name = $_SESSION['last_name'];
$first_name = $_SESSION['first_name'];
$mail = $_SESSION['email'];
$mesta = 0;

$counterAuto = $mysqli->query("SELECT mesta FROM avtobus1 WHERE `id_avto` = '".$_POST["id_avto"]."'");
foreach($counterAuto as $row1){
    $mesta = $row1['mesta'];
}

$mysqli->query("UPDATE reis1 SET `mestost` = ".($mesto-1)." WHERE `id_reisa` = '".$_POST['id_reisa']."'");
$nomermesta = ($mesta - $mesto + 1);


$result = $mysqli->query("INSERT INTO `ticket1` (`id_mar`, `mesto`, `last_name`, `first_name`, `email`) VALUES ('".$reis."', '".$nomermesta."', '".$last_name."', '".$first_name."', '".$mail."')"); 
mysqli_free_result($result);
echo "<SCRIPT> 
    window.location.replace('http://s226348.h1n.ru/index1.php');
</SCRIPT>";
//Составляем заголовок письма
$to = $mail;
$subject = "Вы купили билет на сайте ".$_SERVER['HTTP_HOST'];
 
                 //Устанавливаем кодировку заголовка письма и кодируем его
$subject = "=?utf-8?B?".base64_encode($subject)."?=";
 
                //Составляем тело сообщения
$message = '
<html>
    <head>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title>Тема страницы</title>
    </head>
    <body>
        <p>Покупатель: '.$first_name.' '.$last_name.'</p>
        <p>Пункт отправления: '.$otkuda.'</p>
        <p>Пункт прибытия: '.$kuda.'</p>
        <p>Авто: '.$avto.'</p>
        <p>Место: '.$nomermesta.'</p>
        <p>Дата покупки билета: '.date("d.m.Y", time()).'</p>
        
    </body>
</html>';
    
                //Составляем дополнительные заголовки для почтового сервиса mail.ru
                //Переменная $email_admin, объявлена в файле dbconnect.php
$headers = "FROM: $email_admin\r\nReply-to: $email_admin\r\nContent-type: text/html; charset=utf-8\r\n";
mail($to, $subject, $message, $headers);   
                 //Отправляем сообщение с ссылкой для подтверждения регистрации на указанную почту и проверяем отправлена ли она успешно или нет. 

$mysqli->close();
?>