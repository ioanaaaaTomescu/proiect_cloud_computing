<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="proiect_cloud_ioana_tomescu.WebForm1" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Afla cum o sa fie vremea in orasul tau!</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 400px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }
        h1 {
            text-align: center;
            margin-bottom: 20px;
        }
        label {
            display: block;
            margin-bottom: 10px;
        }
        input[type="text"] {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
            margin-bottom: 20px;
        }
        button {
            width: 100%;
            padding: 10px;
            background-color: #007bff;
            color: #fff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        button:hover {
            background-color: #0056b3;
        }
        .weather-data {
            margin-top: 20px;
            padding: 10px;
            background-color: #f9f9f9;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
    .weather-data-label {
        font-size: 18px;
        font-weight: bold;
        color: #333;
        margin-bottom: 10px;
        align-items: center;

    }


    .temperature-label {
        font-size: 16px;
        color: #666;
    }

    </style>
</head>
<body>
     <form id="weatherForm" runat="server">
        <div class="container">
            <h1>Afla cum o sa fie vremea in orasul tau!</h1>
             <asp:TextBox ID="txtCity" runat="server" CssClass="form-control" placeholder="Alege un oras dar scrie in engleza!" Required="true"></asp:TextBox>
             <asp:Button ID="btnSubmit" runat="server" Text="Afla vremea" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
            <br />
            <div>
              <asp:Label id="lblWeatherCity" runat="server" CssClass="weather-data-label" ></asp:Label>
            </div> 
            <div>
                <asp:Label id="Label1" runat="server" CssClass="weather-data-label"></asp:Label>
            </div> 
            <div>
                <asp:Label id="lblTemperature" runat="server" CssClass="temperature-label"></asp:Label>
            </div>
            <div>
                <asp:Label id="lblTempMax" runat="server" CssClass="temperature-label"></asp:Label>
            </div>
            <div>
                <asp:Label id="lblTempMin" runat="server" CssClass="temperature-label"></asp:Label>
            </div>           
            <div>
                <asp:Label id="lblHumidity" runat="server" CssClass="temperature-label"></asp:Label>
            </div>

        </div>
    </form>
</body>
</html>
