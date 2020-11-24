<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Опрос</title>
    <link rel="stylesheet" href="Styles.css" />
</head>
<body>
    <form id="rsvpform" runat="server">
        <div>
            <h1>Новый год у Татьяны!</h1>
            <p>Мы устроим классную вечеринку и вы приглашены!</p>
        </div>
        <div>
            <label>Ваше имя:</label><input type="text" id="name" /></div>
        <div>
            <label>Ваш email:</label><input type="text" id="email" /></div>
        <div>
            <label>Ваш телефон:</label><input type="text" id="phone" /></div>
        <div>
            <label>Вы придете?</label>
            <select id="willattend" runat="server">
                <option value="">Выберите один из вариантов</option>
                <option value="true">Да</option>
                <option value="false">Нет</option>
            </select>
        </div>
        <div>
            <button type="submit">Отправить приглашение RSVP</button>
        </div>
    </form>
</body>
</html>