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
         $id = $_GET['id'];
         if($id) {
            $query = "DELETE FROM staff WHERE id = '$id'";
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
                        echo "<th class=" . $row['Field'] . ' ' .  " scope='col'>" . $row['Field'] . "</th>";
                    }
                    ?>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <?
                    foreach ($result as $staff){?>
                        <tr>
                            <td><?=$staff['id'] ?> </td>
                            <td><?=$staff['id сотрудника'] ?> </td>
                            <td><?=$staff['ф'] ?> </td>
                            <td><?=$staff['и'] ?> </td>
                            <td><?=$staff['о'] ?> </td>
                            <td><?=$staff['возраст'] ?> </td>
                            <td><?=$staff['пол'] ?> </td>
                            <td><?=$staff['адрес'] ?> </td>
                            <td><?=$staff['телефон'] ?> </td>
                            <td><?=$staff['паспортные данные'] ?> </td>
                            <td><?=$staff['id должности'] ?> </td>
                            <td>
                                <form>
                                    <button class="btn btn-danger">Delete</button>
                                    <input type="text" name="id" size=1 value=<?=$staff['id']?> style="display:none;">
                                </form>
                            </td>
                        </tr>
                    <?}?>
            </tbody>
            </table>
    </div>
    <script>

    </script>
</body>
</html>