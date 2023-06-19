<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>
<body>
    <? include('./header.php')?>
    <?
         $sql = 'SELECT * from currency';
         $result = mysqli_query($link,$sql);
         $sql = 'SHOW COLUMNS FROM currency';
         $fields = mysqli_query($link, $sql);
         
         $id = $_GET['id'];
         $name = $_GET['name'];
         $change = $_GET['change'];

         if($id) {
            $sql = "DELETE FROM currency WHERE id = '$id'";
            mysqli_query($link, $sql);
            window.location.reload();
         }
         if($name && $change ) {
            $sql = "INSERT INTO `currency` (`Наименование`, `Обмен курс`) VALUES ('$name', '$change')";
            mysqli_query($link, $sql);
            echo '<script>window.location.href="/pages/currency.php"</script>';
         }
    ?>
    <div>  
        <form>
            <input type="text" name="name" />
            <label for="name">Наименование</label>
            <input type="text" name="change" />
            <label for="change">Обмен курс</label>
            <button class="btn btn-success">Отправить</button>
        </form>
        <table class="table">
            <thead>
                <tr>
                  <?
                    while($row = mysqli_fetch_array($fields))
                    {
                        echo "<th scope='col'>" . $row['Field'] . "</th>";
                    }
                    ?>
                    <th>Delete</th>
                </tr>
            </thead>
            <tbody>
                <?
                    foreach ($result as $currency){?>
                    <tr>
                        <td><?=$currency['id'] ?> </td>
                        <td><?=$currency['Наименование'] ?></td>
                        <td><?=$currency['Обмен курс']?></td>
                        <td>
                            <form>
                                <button class="btn btn-danger">Delete</button>
                                <input type="text" name="id" size=1 value=<?=$currency['id']?> style="display:none;">
                            </form>
                        </td>
                    </tr>
                    <?}?>
            </tbody>
            </table>
    </div>
</body>
</html>