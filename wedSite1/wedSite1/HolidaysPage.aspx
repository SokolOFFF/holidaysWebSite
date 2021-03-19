<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HolidaysPage.aspx.cs" Inherits="HolidaysPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Happy holidays!</title>
    <link rel ="stylesheet" href ="mystyle.css"/>
</head>
<body>
    <form id="form1" runat="server">
         <div align ="middle">
             <h1 class="greating">Hello! Today we have a lot of holidays as usual!</h1> <br />
             <%= ShowingDateToday()%> <br />
             <%= ShowingHolidays()%>
            <img src ="salad.jpg" />
         </div>
     </form>
</body>
</html>
