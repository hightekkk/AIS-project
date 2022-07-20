<?php
    session_start();
    require_once("dbconnect.php");
    
$reis = $_POST['id_reis'];
$avto = $_POST['avto'];
$mesto = $_POST['mestost'];
$otkuda = $_POST['otkuda'];
$kuda = $_POST['kuda'];
$date1 = $_POST['dateotp'];
$date2 = $_POST['dateprib'];
$last_name = $_SESSION['last_name'];
$first_name = $_SESSION['first_name'];
$mail = $_SESSION['email'];


$mysqli->query("UPDATE marshrut SET `mestost` = ".($mesto-1)." WHERE `id` = '".$_POST['id']."'");



$result = $mysqli->query("INSERT INTO `ticket` (`reis`, `avto`, `mesto`, `otkuda`, `kuda`, `last_name`, `first_name`, `mail`) VALUES ('".$reis."', '".$avto."', '".$mesto."', '".$otkuda."', '".$kuda."', '".$last_name."', '".$first_name."', '".$mail."')"); 
mysqli_free_result($result);


$to = $mail;
$subject = "Вы купили билет на сайте ".$_SERVER['HTTP_HOST'];
 
                 
$subject = "=?utf-8?B?".base64_encode($subject)."?=";
 
                
$message = '
<html>
    <head>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title>Тема страницы</title>
    </head>
    <body>
        <p>Рейс №: '.$reis.'</p>
        <p>Покупатель: '.$first_name.' '.$last_name.'</p>
        <p>Пункт отправления: '.$otkuda.' '.$date1.'</p>
        <p>Пункт прибытия: '.$kuda.' '.$date2.'</p>
        <p>Авто: '.$avto.'</p>
        <p>Место: '.$mesto.'</p>
        <p>Дата покупки билета: '.date("d.m.Y", time()).'</p>
        
    </body>
</html>';
    
                
$headers = "FROM: $email_admin\r\nReply-to: $email_admin\r\nContent-type: text/html; charset=utf-8\r\n";
mail($to, $subject, $message, $headers);   
                
echo "<SCRIPT>
    alert('Спасибо за покупку. Билет отправлен на вашу электронную почту ".$_SESSION['email']."');
    window.location.replace('http://s226348.h1n.ru/index.php');
</SCRIPT>";
$mysqli->close();
?>