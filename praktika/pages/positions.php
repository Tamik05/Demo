<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>
<body>
    <?include('./header.php')?>
    <?
         $sql = 'SELECT * from positions';
         $result = mysqli_query($link,$sql);
         $sql = 'SHOW COLUMNS FROM positions';
         $fields = mysqli_query($link, $sql);
         $id = $_GET['id'];
         if($id) {
            $query = "DELETE FROM positions WHERE id = '$id'";
            mysqli_query($link, $query);
            window.location.reload();
        }
    ?>
    <div>  
        <table class="table">
            <thead>
                <tr>
                  <?
                    while($row = mysqli_fetch_array($fields))
                    {
                        echo "<th scope='col'>" . $row['Field'] . "</th>";
                    }
                    ?>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <?
                    foreach ($result as $positions){?>
                        <tr>
                            <td><?=$positions['id'] ?> </td>
                            <td><?=$positions['наименование должности'] ?> </td>
                            <td><?=$positions['оклад'] ?> </td>
                            <td><?=$positions['обязонасти'] ?> </td>
                            <td><?=$positions['требования'] ?> </td>
                            <td>
                                <form>
                                    <button class="btn btn-danger">Delete</button>
                                    <input type="text" name="id" size=1 value=<?=$positions['id']?> style="display:none;">
                                </form>
                            </td>
                        </tr>
                    <?}?>
            </tbody>
            </table>
    </div>
</body>
</html>