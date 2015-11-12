<%@ Page Language="C#" Inherits="RockPaperScissorsWeb.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Rock Paper Scissors</title>
</head>
<body>
	<form id="form1" runat="server" defaulturl="Default.aspx">
		<div>
                <asp:RadioButton id="rockButton" Text="Rock" Value="rock" GroupName="PlayerChoice" runat="server"></asp:RadioButton>
                <asp:RadioButton id="paperButton" Text="Paper" Value="paper" GroupName="PlayerChoice" runat="server"></asp:RadioButton>
                <asp:RadioButton id="scissorsButton" Text="Scissors" Value="scissors" GroupName="PlayerChoice" runat="server"></asp:RadioButton>          
        </div>
		<asp:Button id="button1" runat="server" Text="Play!" OnClick="play" />

		<p></p>
		<asp:Label id="paragraph" runat="server"></asp:Label>
		<asp:Label id="computerChoiceLabel" runat="server"></asp:Label>

		<p></p>
		<asp:Label id="gameOutcome" runat="server"></asp:Label>
	</form>
</body>
</html>