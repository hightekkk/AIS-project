<?php
    // Указываем кодировку
    header('Content-Type: text/html; charset=utf-8');
 
    
    // Подключение к базе данных через MySQLi
    $mysqli = new mysqli('localhost', 'hightekk', 'Aa9346936', 'aero');
 
    // Проверяем, успешность соединения. 
    if ($mysqli->connect_errno) { 
        die("<p><strong>Ошибка подключения к БД</strong></p><p><strong>Код ошибки: </strong> ". $mysqli->connect_errno ." </p><p><strong>Описание ошибки:</strong> ".$mysqli->connect_error."</p>"); 
    }
 
    // Устанавливаем кодировку подключения
    $mysqli->set_charset('utf8');
 
    //Для удобства, добавим здесь переменную, которая будет содержать адрес (URL) нашего сайта
    $address_site = "http://s226348.h1n.ru/";
    $email_admin = "admin@s226348.h1n.ru";
?>