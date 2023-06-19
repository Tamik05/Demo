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
         $sql = 'SELECT * from deposits';
         $result = mysqli_query($link,$sql);
         $sql = 'SHOW COLUMNS FROM deposits';
         $fields = mysqli_query($link, $sql);
         $id = $_GET['id'];
         if($id) {
            $query = "DELETE FROM deposits WHERE id = '$id'";
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
                    foreach ($result as $deposits){?>
                        <tr>
                            <td><?=$deposits['id'] ?> </td>
                            <td><?=$deposits['наименование вклада'] ?></td>
                            <td><?=$deposits['минимальный срок вклада']?></td>
                            <td><?=$deposits['минимальная сумма вклада'] ?> </td>
                            <td><?=$deposits['процентная ставка'] ?> </td>
                            <td><?=$deposits['максимальная сумма вклада'] ?> </td>
                            <td>
                                <form>
                                    <button class="btn btn-danger">Delete</button>
                                    <input type="text" name="id" size=1 value=<?=$deposits['id']?> style="display:none;">
                                </form>
                            </td>
                        </tr>
                    <?}?>
            </tbody>
            </table>
    </div>
</body>
</html>