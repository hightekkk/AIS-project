<?php
require_once("header.php");
require_once("dbconnect.php");
session_start();
$mail = $_SESSION['email'];
//  $result = $mysqli->query("DELETE FROM ticket1 WHERE `id_ticket` like '".$_POST['id']."'");
//  mysqli_free_result($result);
$result = $mysqli->query("UPDATE ticket1 SET `status` = 1 WHERE `id_ticket` like '".$_POST['id']."'");
 mysqli_free_result($result);
 echo "<SCRIPT> 
    window.location.replace('http://s226348.h1n.ru/vivod.php');
</SCRIPT>";
$mysqli->close();
?>