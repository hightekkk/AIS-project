<?php
    //Запускаем сессию
    session_start();
?>
<?php
    //Подключение шапки
    require_once("header.php");
?>
<!DOCTYPE html> 

    <!--<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>-->
    <!--<script src="https://api-maps.yandex.ru/2.1/?lang=ru_RU&amp;apikey=c331ce13-ab80-4716-9daf-482a4f61e1f5" type="text/javascript"></script>-->
    <!--<script src="https://yandex.st/jquery/2.2.3/jquery.min.js" type="text/javascript"></script>-->
    <!--<script src="mapJS.js" type="text/javascript"></script>-->
<section class="flexsearch">
<div class="search">
    <form name="search" method="post" class="fsearch">
 
   <div class="left zv">
      <input maxlength="30" type="text" name="otkuda" id="from"  placeholder="Откуда"required/>
      <button type="button" class="butt" onclick="function(); return false;">&nbsp;⇄&nbsp;</button>
      <input maxlength="30" type="text" name="kuda"  id="to" placeholder="Куда"required/>
 
      <input maxlength="30" type="text" name="email"  placeholder="Когда"/>
      
      
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


    

if($_POST['otkuda'])
  {
    require_once("dbconnect.php");

    $result = $mysqli->query("SELECT * FROM marshrut WHERE `otkuda` like '%$otkuda%' AND `kuda` like '%$kuda%'");
     $result2 = $mysqli->query("SELECT marshrut.id, reis.number as id_reis, marshrut.otkuda,marshrut.kuda,marshrut.dateotp,marshrut.dateprib,marshrut.price,marshrut.mestost,marshrut.avto 
     FROM marshrut
     INNER JOIN reis ON marshrut.id_reis = reis.id WHERE marshrut.otkuda like '%$otkuda%' AND `kuda` like '%$kuda%'");
     echo "<div class='tableup'><table class='table' border='1'><tr><th>id</th><th>рейс</th><th>Откуда</th><th>Куда</th><th>Дата отправления</th><th>Дата прибытия</th><th>Цена</th><th>Осталось мест</th><th class='avto'>Авто</th><th class='avto1'></th></tr>";
     
     foreach($result as $row){
     echo "<tr>";
     echo "<td>" . $row["id"] . "</td>";
     foreach($result2 as $row2){
         
     }
     echo "<td>" . $row2["id_reis"] . "</td>";
    //  echo "<td>" . $row["id_reis"] . "</td>";
     echo "<td>" . $row["otkuda"] . "</td>";
     echo "<td>" . $row["kuda"] . "</td>";
     echo "<td>" . $row["dateotp"] . "</td>";
     echo "<td>" . $row["dateprib"] . "</td>";
     echo "<td>" . $row["price"] . "</td>";
     
     if($row["mestost"] == ""){
        $counterAuto = $mysqli->query("SELECT mesta FROM avtobus WHERE `avt` = '".$row["avto"]."'");
        foreach($counterAuto as $row1){
            $mysqli->query("UPDATE marshrut SET `mestost` = ".$row1['mesta']." WHERE `id` = '".$row["id"]."'");
        }
        echo "<td>" . $row1['mesta'] . "</td>";
     }
     else {
        echo "<td>" . $row["mestost"] . "</td>";
     }
     
     echo "<td>" . $row["avto"] . "</td>";
     echo "<td><form action='buy.php' method='post'>
     <input type='hidden' name='id' value='" . $row["id"] . "' />
     <input type='hidden' name='id_reis' value='" . $row2["id_reis"] . "' />
     <input type='hidden' name='otkuda' value='" . $row["otkuda"] . "' />
     <input type='hidden' name='kuda' value='" . $row["kuda"] . "' />
     <input type='hidden' name='dateotp' value='" . $row["dateotp"] . "' />
     <input type='hidden' name='dateprib' value='" . $row["dateprib"] . "' />
     <input type='hidden' name='price' value='" . $row["price"] . "' />
     <input type='hidden' name='mestost' value='" . $row["mestost"] . "' />
     <input type='hidden' name='avto' value='" . $row["avto"] . "' />
     <input type='submit' value='Купить' class='btn'>
     </form></td>";
     echo "</tr>";
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