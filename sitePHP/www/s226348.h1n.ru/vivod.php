<?php
require_once("header.php");
?>
<?php
session_start();
require_once("dbconnect.php");
$last_name = $SESSION['last_name'];
$mail = $_SESSION['email'];

  $result = $mysqli->query("SELECT ticket1.id_ticket, marshrut1.id_marsh, reis1.id_reisa, reis1.number, ticket1.id_mar, ticket1.mesto, ticket1.email, ticket1.status AS ticketstatus, marshrut1.status, marshrut1.description FROM ticket1, marshrut1, reis1 WHERE ticket1.id_mar = marshrut1.id_marsh AND marshrut1.id_reis = reis1.id_reisa AND ticket1.email like '%$mail%'");
  echo "<div class='tableup tablvivod'><table class='table' border='1'><tr><th>id</th><th>Рейс №</th><th>Место</th><th>Почта</th><th class='noneline1'>Статус</th><th class='noneline'></th></tr>";
     foreach($result as $row){
     echo "<tr>";
     echo "<td class='bor'>" . $row["id_ticket"] . "</td>";
     echo "<td class='bor'>" . $row["number"] . "</td>";
     echo "<td class='bor'>" . $row["mesto"] . "</td>";
     echo "<td class='bor'>" . $row["email"] . "</td>";
     
     if($row["status"] == 'Отменён'){
         echo "<td class='bor'> Отменён<br> Причина: " . $row["description"] . "</td>";
        //  echo "<td class='bor'>" . $row["description"] . "</td>";
     }
     elseif ($row["ticketstatus"] == 1){
         echo "<td class='bor'> Билет возвращен</td>";
     } else {
        echo "<td class='bor'> Куплено </td>";
        echo "<td><form action='delete.php' method='post'>
     <input type='hidden' name='id' value='" . $row["id_ticket"] . "' />
     <input type='submit' onClick=\"javascript: return confirm('Вы действительно хотите вернуть билет?');\" value='Вернуть' class='btn'>
     
     </form></td>";
     }
    //  echo "<td><form action='delete.php' method='post'>
    //  <input type='hidden' name='id' value='" . $row["id"] . "' />
    //  <input type='submit' onClick=\"javascript: return confirm('Вы действительно хотите вернуть билет?');\" value='Вернуть' class='btn'>
     
    //  </form></td>";
     echo "</tr>";
     }
     echo "</table></div>";
     mysqli_free_result($result);

  
?>


    
<?php
    //Подключение подвала
    require_once("footer.php");
?>