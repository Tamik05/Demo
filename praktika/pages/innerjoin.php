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
         $sql = 'SELECT * from staff';
         $result = mysqli_query($link,$sql);
         $sql = 'SHOW COLUMNS FROM staff';
         $fields = mysqli_query($link, $sql);
         $sql = 'SELECT * FROM `staff` INNER JOIN `positions` ON `staff`.`id должности` = `positions`.`id` ';
         $result2 = mysqli_query($link, $sql);
    ?>
    <div>  
        <table class="table">
            <thead>
                <tr>
                  <th>id должности</th>
                  <th>id сотрудника</th>
                  <th>ФИО сотрудника</th>
                  <th>наименование должности</th>
                </tr>
            </thead>
            <tbody>
                <?
                    while ($row = mysqli_fetch_array($result2)) {?>
                        <tr>
                            <td><?=$row['id'] ?> </td>
                            <td><?=$row['id сотрудника'] ?> </td>
                            <td><?=$row['ф'] . ' ' . $row['и'] . ' ' . $row['о']?></td>
                            <td><?=$row['наименование должности'] ?> </td>
                        </tr>
                    <?}?>
            </tbody>
            </table>
    </div>
    <script>

    </script>
</body>
</html>