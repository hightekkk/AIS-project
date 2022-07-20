<?php
    //Запускаем сессию
    session_start();
?>
<?php
    //Подключение шапки
    require_once("header.php");
?>
<!DOCTYPE html> 

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="https://api-maps.yandex.ru/2.1/?lang=ru_RU&amp;apikey=c331ce13-ab80-4716-9daf-482a4f61e1f5" type="text/javascript"></script>
    <script src="https://yandex.st/jquery/2.2.3/jquery.min.js" type="text/javascript"></script>
    <script src="mapJS.js" type="text/javascript"></script>



<section class="flexsearch">
<div class="search">
    <form name="search" method="post" class="fsearch">
 
   <div class="left zv">
      <input maxlength="30" type="text" name="otkuda" id="from"  placeholder="Откуда"required/>
      <button type="button" class="butt" onclick="function(); return false;">&nbsp;⇄&nbsp;</button>
      <input maxlength="30" type="text" name="kuda"  id="to" placeholder="Куда"required/>
 
      <input maxlength="30" type="date" name="dateotp"  placeholder="Когда"/>
      
      
      <input type="submit"  value="Найти" id="findRoute" class="btnsear"/>
   </div>
</form>

</div>
</section>

</body>
<script>
document.onclick = function() {
var elem = window.event.srcElement;

if (elem.className == "butt") {
	var n1 = document.getElementById('from').value,
	    n2 = document.getElementById('to').value;

	document.getElementById('from').value = n2;
	document.getElementById('to').value = n1;
}
};
</script>

<?php

$otkuda = $_POST['otkuda'];
$kuda = $_POST['kuda'];
$date = $_POST['dateotp'];


    

if($_POST['otkuda'])
  {
    require_once("dbconnect.php");

    $result = $mysqli->query("SELECT marshrut1.id_marsh, marshrut1.id_reis, marshrut1.status, marshrut1.id_avt, marshrut1.id_vod,
    reis1.id_reisa, reis1.number, reis1.otkuda, reis1.kuda, reis1.dateotp, reis1.timeotp, reis1.dateprib, reis1.timeprib, reis1.mestost, reis1.price,
    avtobus1.id_avto, avtobus1.avto, voditeli1.id, voditeli1.lastname
    FROM marshrut1, reis1, avtobus1, voditeli1
    WHERE marshrut1.id_reis = reis1.id_reisa AND marshrut1.id_avt = avtobus1.id_avto AND marshrut1.id_vod = voditeli1.id AND reis1.otkuda like '%$otkuda%' AND reis1.kuda like '%$kuda%' AND reis1.dateotp like '%$date%'");
     echo "<div class='tableup'><table class='table' border='1'><tr><th>Рейс №</th><th>Пункт отправления</th><th>Пункт прибытия</th><th>Дата отправления</th><th>Дата прибытия</th><th>Цена</th><th>Авто</th><th class='noneline1'>Осталось мест</th><th class='noneline'></th></tr>";
     
     foreach($result as $row){
         echo "<td> <input type='hidden' name='status' value='" . $row["status"] . "' /></td>";
     echo "<tr>";
     echo "<td>" . $row["number"] . "</td>";
     echo "<td>" . $row["otkuda"] . "</td>";
     echo "<td>" . $row["kuda"] . "</td>";
     echo "<td>" . $row["dateotp"] ."  ". $row["timeotp"]. "</td>";
     echo "<td>" . $row["dateprib"] ."  ". $row["timeprib"]. "</td>";
     echo "<td>" . $row["price"] . "</td>";
     echo "<td>" . $row["avto"] . "</td>";
     
     
    //  echo "<td>" . $row["id_reis"] . "</td>";
    //  echo "<td>" . $row["otkuda"] . "</td>";
    //  echo "<td>" . $row["kuda"] . "</td>";
    //  echo "<td>" . $row["dateotp"] . "</td>";
    //  echo "<td>" . $row["dateprib"] . "</td>";
    //  echo "<td>" . $row["price"] . "</td>";
     
     if($row["mestost"] == 0){
        $counterAuto = $mysqli->query("SELECT mesta FROM avtobus1 WHERE `avto` = '".$row["avto"]."'");
        foreach($counterAuto as $row1){
            $mysqli->query("UPDATE reis1 SET `mestost` = ".$row1['mesta']." WHERE `id_reisa` = '".$row["id_reisa"]."'");
        }
        echo "<td>" . $row1['mesta'] . "</td>";
     }
     else {
        echo "<td>" . $row["mestost"] . "</td>";
     }
     
    if((!isset($_SESSION["email"]) && !isset($_SESSION["password"])) || ($row["status"] == "Отменён")){
        
        echo "<td>" . $row["status"] . "&nbsp;&nbsp;&nbsp;&nbsp;</td>";
        
    }
    else{
     echo "<td><form action='buy1.php' method='post'>
     <input type='hidden' name='id_reisa' value='" . $row["id_reisa"] . "' />
     <input type='hidden' name='id_marsh' value='" . $row["id_marsh"] . "' />
     <input type='hidden' name='number' value='" . $row["number"] . "' />
     <input type='hidden' name='otkuda' value='" . $row["otkuda"] . "' />
     <input type='hidden' name='kuda' value='" . $row["kuda"] . "' />
     <input type='hidden' name='dateotp' value='" . $row["dateotp"] . "' />
     <input type='hidden' name='timeotp' value='" . $row["timeotp"] . "' />
     <input type='hidden' name='dateprib' value='" . $row["dateprib"] . "' />
     <input type='hidden' name='timeprib' value='" . $row["timeprib"] . "' />
     <input type='hidden' name='price' value='" . $row["price"] . "' />
     <input type='hidden' name='mestost' value='" . $row["mestost"] . "' />
     <input type='hidden' name='mesta' value='" . $row1["mesta"] . "' />
     <input type='hidden' name='avto' value='" . $row["avto"] . "' />
     <input type='hidden' name='id_avto' value='" . $row["id_avto"] . "' />
     <input type='submit' value='Купить' class='btn'>
     </form></td>";
     echo "</tr>";
    }
     }
     echo "</table></div>";
     mysqli_free_result($result);

}
?>
 <div id="map"></div>
 
<?php
    //Подключение подвала
    require_once("footer.php");
?>