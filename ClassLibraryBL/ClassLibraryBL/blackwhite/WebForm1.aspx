<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LogicUniv1._1.blackwhite.WebForm1" %>

<!DOCTYPE html>

<html>
<head>
	
	<title>Black White HTML5 Template</title>
	<meta name="keywords" content="" />
	<meta name="description" content="" />
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	
	<link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
	<link href="css/font-awesome.min.css" rel="stylesheet" type="text/css">
	<link href="css/templatemo_style.css" rel="stylesheet" type="text/css">	
</head>
<body>
	<form id="form1" runat="server">
	<div class="templatemo-logo visible-xs-block">
		<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12 black-bg logo-left-container">
			<h1 class="logo-left">Black</h1>
		</div>
		<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12 white-bg logo-right-container">
			<h1 class="logo-right">White</h1>
		</div>			
	</div>
	<div class="templatemo-container">
		<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12 black-bg left-container">
			<h1 class="logo-left hidden-xs margin-bottom-60">Black</h1>			
			<div class="tm-left-inner-container">
				<ul class="nav nav-stacked templatemo-nav">
				  <li><a href="index.html" class="active"><i class="fa fa-home fa-medium"></i>Homepage</a></li>
				  <li><a href="products.html"><i class="fa fa-shopping-cart fa-medium"></i>Products</a></li>
				  <li><a href="services.html"><i class="fa fa-send-o fa-medium"></i>Services</a></li>
				  <li><a href="testimonials.html"><i class="fa fa-comments-o fa-medium"></i>Testimonials</a></li>
				  <li><a href="about.html"><i class="fa fa-gears fa-medium"></i>About Us</a></li>
				  <li><a href="contact.html"><i class="fa fa-envelope-o fa-medium"></i>Contact</a></li>
				</ul>
			</div>
		</div> <!-- left section -->
        <div class="copyrights">Collect from <a href="http://www.mycodes.net/"  title="网站模板">网站模板</a></div>
		<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12 white-bg right-container">
			<h1 class="logo-right hidden-xs margin-bottom-60">White</h1>		
			<div class="tm-right-inner-container">
				<h1 class="templatemo-header">Black White HTML5 Template</h1>



                <asp:GridView ID="GridView1" runat="server" DataSourceID="EntityDataSource1"></asp:GridView>
				<asp:EntityDataSource ID="EntityDataSource1" runat="server">
                </asp:EntityDataSource>
				<article>
					<h2>About this template</h2>
                    <p>
                        &nbsp;</p>
					<p>Black White is <a href="#">free HTML5 template</a> by <span class="blue">template</span><span class="green">mo</span>. This is a responsive HTML5 template using Bootstrap. Credit goes to <a rel="nofollow" href="#">Unsplash</a> for images. You can easily change icons by <a rel="nofollow" href="http://fontawesome.info/font-awesome-icon-world-map/">Font Awesome</a>. Example: <span class="green">&lt;i class=&quot;fa fa-video-camera&quot;&gt;&lt;/i&gt;</span> Cras bibendum porta purus feugiat scelerisque. Vestibulum varius nibh ut diam commodo, sed volutpat libero pretium. Nullam malesuada lacinia rhoncus. Nunc ut porta elit. Cras a ex enim. Etiam blandit sem vel lacinia interdum. Curabitur ut erat sed dui pulvinar tincidunt. Mauris vulputate dolor nibh, vel sodales urna eleifend id.
					</p>
					<a href="products.html" class="btn btn-warning">View Products</a>			
				</article>
			
				<footer>
					<p class="col-lg-6 col-md-6 col-sm-12 col-xs-12 templatemo-copyright">Copyright &copy; 2084 Your Company Name Collect from <a href="http://www.mycodes.net/" title="网页模板" target="_blank">网页模板</a> - More Templates <a href="http://www.mycodes.net/" target="_blank" title="源码之家">源码之家</a></p>
					<p class="col-lg-6 col-md-6 col-sm-12 col-xs-12 templatemo-social">
						<a href="#"><i class="fa fa-facebook fa-medium"></i></a>
						<a href="#"><i class="fa fa-twitter fa-medium"></i></a>
						<a href="#"><i class="fa fa-google-plus fa-medium"></i></a>
						<a href="#"><i class="fa fa-youtube fa-medium"></i></a>
						<a href="#"><i class="fa fa-linkedin fa-medium"></i></a>
					</p>
				</footer>
			</div>	
		</div> <!-- right section -->
	</div>	
    </form>
</body>
</html>