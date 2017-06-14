# PersonalFinanceWeb

<h3>Description:</h3>
<br>A RESTful web service for a personal finance database built in ASP.NET Web Api 2

<h3>Technologies:</h3>
<ul>
	<li>ASP.NET Web Api 2</li>
	<li>Entity Framework</li>
	<li>.NET Framework 4.5.2</li>
	<li>ODBC</li>
</ul>

<h3>Endpoints (localhost:60057/api/...):</h3>
<ul>
	<li>Person</li>
	<ul>
		<li>Person/{id}</li>
		<li>People/</li>
	</ul>
	<li>Wage</li>
	<ul>
		<li>Wage/{personid}</li>
	</ul>
	<li>IncomeTax</li>
	<ul>
		<li>IncomeTax/{id}</li>
	</ul>
	<li>IncomeTaxBracket</li>
	<ul>
		<li>IncomeTaxBracket/{id}/{bracketLevel}
	</ul>
</ul>

<h3>Routes:</h3>
	<li>Person and IncomeTax use the default routes defined in WebApiConfig.cs.</li> 
	<li>Wage and IncomeTaxBracket use their own custom routes defined on the method level. The default onlyThey do not take in an {id}, they take in a {personid} and a {id}/{bracketLevel} (respectively).</li>
Connection:
	The Oracle connection string is defined at the bottom of the Web.config. The PFContext is an Entity framework connection (like EntityManager).


<h3>CRUD Methods Enabled:</h3>
<ul>
	<li>GET</li>
	<li>PUT</li>
	<li>POST</li>
	<li>DELETE</li>
</ul>
	
Followed <a href="https://docs.microsoft.com/en-us/aspnet/web-api/overview/getting-started-with-aspnet-web-api/action-results">Microsoft's standards</a> for Web API 2 
		
