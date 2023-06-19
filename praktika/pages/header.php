<?
    $link = mysqli_connect("localhost", "root", "",'test');
?>
<script src="../script.js"></script>
<nav class="navbar navbar-expand-lg navbar-light bg-light">
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <span style="background: black; color: white; cursor:pointer" class="changeBackground">
    Change background
  </span>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
      <li class="nav-item active">
        <a class="nav-link" href="./contributors.php">Contributors</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="./currency.php">Currency</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="./deposits.php">Deposits</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="./positions.php">Positions</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="./staff.php">Staff</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="./innerjoin.php">Inner Join staff & positions</a>
      </li>
    </ul>
  </div>
</nav>