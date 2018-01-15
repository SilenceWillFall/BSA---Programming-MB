<html>
 <head>
  <title>My Test</title>
 </head>
 <body>
 
 <?php 
     $now = localtime(time(), true);
     if ($now[tm_hour] < 12)
     {
        echo '<p>Good Morning!</p>';
     }
     else
     {
        echo '<p>Good Afternoon!</p>';
     }
?> 
 
 </body>
</html>