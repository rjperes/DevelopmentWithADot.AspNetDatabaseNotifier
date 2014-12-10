<%@ Page Language="C#" CodeBehind="Default.aspx.cs" Inherits="DevelopmentWithADot.AspNetDatabaseNotifier.Test.Default" %>
<%@ Register Assembly="DevelopmentWithADot.AspNetDatabaseNotifier" Namespace="DevelopmentWithADot.AspNetDatabaseNotifier" TagPrefix="web" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Dynamic Virtual Path Provider</title>
	<script type="text/javascript" src="Scripts/jquery-1.6.4.js"></script>
	<script type="text/javascript" src="Scripts/jquery.signalR-2.1.2.js"></script>
	<script type="text/javascript" src="signalr/hubs"></script>
	<script type="text/javascript">

		function onChange(info, source, type)
		{
			debugger;
		}

		window.addEventListener('load', function() {
			var notifier = $.connection.changeNotificationHub;
			notifier.client.onChange = onChange;
			$.connection.hub.start();
		});

	</script>
</head>
<body>
	<form runat="server">
	</form>
</body>
</html>
