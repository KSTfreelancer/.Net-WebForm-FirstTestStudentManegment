<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Student_management.UI.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>StudentManegmrntSystem</title>
    <link rel="shortcut icon" href="/IMG/education.png" type="image/x-icon" />
    <style>
        * {
            margin: 0px;
            padding: 0px;
            box-sizing: border-box;
        }

        .box {
            width: 100%;
            height: 100vh;
            background-image: url(../IMG/pexels-max-fischer-5212326.jpg);
            background-size: cover;
            background-repeat: no-repeat;
            background-position: top;
            display: flex;
            align-items: center;
            justify-content: center;
        }

            .box .button {
                height: 45px;
                width: 150px;
                background-color: rgba(255,255,255,0.4);
                backdrop-filter: blur(10px);
                font-weight: 900;
                font-size: 22px;
                font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
                color: green;
                border: none;
                border-radius: 5px;
                box-shadow: 0 0 15px 0 rgba(0,0,0,0.8);
                display: flex;
                justify-content: center;
                align-items: center;
                cursor:pointer;
            }
                .box .button:active {
                    box-shadow: 2px 2px 5px #fc894d;
                }
        .inerBox {
            width: 35%;
            min-width: 420px;
            display: flex;
            justify-content: center;
            align-items: center;
            padding: 40px 0 60px 0;
            flex-direction: column;
            background-color: rgba(255,255,255,0.4);
            backdrop-filter: blur(10px);
            border-radius: 10px;
            box-shadow: 0 0 15px 0 rgba(0,0,0,0.8);
        }
            .inerBox input {
                display: block;
                height: 40px;
                width: 30%;
                margin: 0 0 20px 0;
                min-width: 300px;
                border-radius: 5px;
                border: none;
                box-shadow: 0 0 5px 0 rgba(0,0,0,0.8);
                padding:0 0 0 10px;
                
            }
                .inerBox input:focus {
                    background-color: lightblue;
                    outline: none;
                    font-size: 18px;
                    box-shadow: 0 0 15px 0 rgba(0,0,0,0.8);
                }
                
        .inerBox h1 {
            color: #6495ED;
        }
            .inerBox p {
                padding: 5px 0 40px 0;
                font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
                font-size: 18px;
                
            }
    </style>

</head>
<body>
    <form id="form1" runat="server">
            <div class="box">

            <div class="inerBox">
                <h1>Student Manegment System</h1>
                <p>Login Form</p>

                <asp:label runat="server" id="loginError" style="color:red"></asp:label>

                <input runat="server" id="loginnameTextBox" type="text" placeholder="Enter User Name" required="required" />
                <input runat="server" id="loginpasswordTextBox" type="text"  placeholder="Enter Password" required="required" />

                <asp:Button ID="login" runat="server" Class="button" Text="Loging" OnClick="login_Click" />

            </div>
        </div>
    </form>
</body>
</html>
