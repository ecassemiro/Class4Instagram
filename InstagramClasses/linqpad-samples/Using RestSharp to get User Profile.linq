<Query Kind="Statements">
  <Reference>Z:\SVN\UserDataForInstagram\UserDataForInstagram\InstagramClasses\bin\Debug\netstandard2.0\InstagramClasses.dll</Reference>
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <NuGetReference>RestSharp</NuGetReference>
  <NuGetReference>RestSharp.Newtonsoft.Json</NuGetReference>
  <Namespace>InstagramData</Namespace>
  <Namespace>LINQPad</Namespace>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Bson</Namespace>
  <Namespace>Newtonsoft.Json.Converters</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>Newtonsoft.Json.Schema</Namespace>
  <Namespace>Newtonsoft.Json.Serialization</Namespace>
  <Namespace>RestSharp</Namespace>
  <Namespace>RestSharp.Authenticators</Namespace>
  <Namespace>RestSharp.Authenticators.OAuth</Namespace>
  <Namespace>RestSharp.Deserializers</Namespace>
  <Namespace>RestSharp.Extensions</Namespace>
  <Namespace>RestSharp.Serialization</Namespace>
  <Namespace>RestSharp.Serialization.Json</Namespace>
  <Namespace>RestSharp.Serialization.Xml</Namespace>
  <Namespace>RestSharp.Serializers</Namespace>
  <Namespace>RestSharp.Serializers.Newtonsoft.Json</Namespace>
  <Namespace>RestSharp.Validation</Namespace>
  <Namespace>System.Windows.Forms.DataVisualization.Charting</Namespace>
  <IncludeLinqToSql>true</IncludeLinqToSql>
  <IncludeAspNet>true</IncludeAspNet>
</Query>


var client = new RestSharp.RestClient("https://www.instagram.com/");

var userRequest = new RestSharp.RestRequest("/instagram", Method.GET); // username

userRequest.AddQueryParameter("__a", "1"); //add the parameter to force JSON response


var response = client.Execute<InstagramData.InstagramData>(userRequest); //get the response
 
response.Data.graphql.user
.Dump("Username"); //dump response to LINQPad

 
