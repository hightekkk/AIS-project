<?php
    require_once("header.php");
?>
<div class="block_for_messages">
    <?php
        if(isset($_SESSION["error_messages"]) && !empty($_SESSION["error_messages"])){
            echo $_SESSION["error_messages"];
            unset($_SESSION["error_messages"]);
        }
        if(isset($_SESSION["success_messages"]) && !empty($_SESSION["success_messages"])){
            echo $_SESSION["success_messages"];
             
            unset($_SESSION["success_messages"]);
        }
    ?>
</div>
<?php
    if((!isset($_SESSION["email"]) && !isset($_SESSION["password"]))) {
        if(!isset($_GET["hidden_form"])){
?>
 
 <h2 id="fr">Восстановление пароля</h2>
            <div class="center_block">
                 
                <p class="text_center mesage_error" id="valid_email_message"></p>
                <form action="send_link_reset_password.php" method="post" name="form_request_email" >
                    <table class="table auth">
                        <tr>
                            <td> Введите Ваш <br />E-mail: </td>
                            <td>
                                <input type="email" name="email" placeholder="" >
                            </td>
                        </tr>
                        <tr>
                            <td> Введите капчу: </td>
                            <td>
                                <p>
                                    <img src="captcha.php" alt="Капча" /> <br />
                                    <input type="text" name="captcha" placeholder="Проверочный код" />
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" class="text_center" id="butreg">
                                <input type="submit" name="send" value="Восстановить" class="btn">
                            </td>
                        </tr>
                    </table>
                </form>
            </div>
 
<?php
        }
 
    }else{
?>
        <div id="authorized">
            <h2>Вы уже авторизованы</h2>
        </div>
<?php
    }
 
    require_once("footer.php");
?>