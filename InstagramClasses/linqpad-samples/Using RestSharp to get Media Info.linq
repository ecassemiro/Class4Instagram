<Query Kind="Statements">
  <NuGetReference>RestSharp</NuGetReference>
  <Namespace>InstagramData</Namespace>
  <Namespace>LINQPad</Namespace>
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
  <IncludeLinqToSql>true</IncludeLinqToSql>
  <IncludeAspNet>true</IncludeAspNet>
</Query>



var client = new RestSharp.RestClient("https://www.instagram.com/");

var userRequest = new RestSharp.RestRequest("/p/B9zr4tWAzwm/", Method.GET); // username

userRequest.AddQueryParameter("__a", "1"); //add the parameter to force JSON response


var response = client.Execute<InstagramData.InstagramData>(userRequest); //get the response
 
response.Data.graphql.shortcode_media
.Dump("Media"); //dump response to LINQPad

 
