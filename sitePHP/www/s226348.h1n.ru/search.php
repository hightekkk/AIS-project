<?php
    //Запускаем сессию
    session_start();
    require_once("dbconnect.php");

?>
<?php
$otkuda = $_POST['otkuda'];
$kuda = $_POST['kuda'];
$result = $mysqli->query("SELECT * FROM marshrut WHERE `otkuda` like '%$otkuda%' AND WHERE `kuda` like '%$kuda%' like '%$kuda%'");
    echo "<table border='1'><tr><th>id</th><th>Откуда</th><th>Куда</th><th>Дата отправления</th><th>Дата прибытия</th><th>Цена</th><th>Осталось мест</th><th>Авто</th><th></th></tr>";
    foreach($result as $row){
        echo "<tr>";
            echo "<td>" . $row["id"] . "</td>";
            echo "<td>" . $row["otkuda"] . "</td>";
            echo "<td>" . $row["kuda"] . "</td>";
            echo "<td>" . $row["dateotp"] . "</td>";
            echo "<td>" . $row["dateprib"] . "</td>";
            echo "<td>" . $row["price"] . "</td>";
            echo "<td>" . $row["mestost"] . "</td>";
            echo "<td>" . $row["avto"] . "</td>";
            echo "<td><form action='delete.php' method='post'>
                        <input type='hidden' name='id' value='" . $row["id"] . "' />
                        <input type='submit' value='Купить'>
                   </form></td>";
        echo "</tr>";
    }
    echo "</table>";
mysqli_free_result($result);

?>