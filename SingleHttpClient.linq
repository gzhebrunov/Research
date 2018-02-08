<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.Http.dll</Reference>
  <Namespace>System.Net.Http</Namespace>
</Query>

var stopwatch = new Stopwatch();
stopwatch.Start();

var client = new HttpClient();
for(var i = 0; i < 100; i++) {
	var res = client.GetAsync("https://twitter.com").Result;
	Console.WriteLine($"{i}");
}

client.Dispose();

stopwatch.Stop();
Console.WriteLine($"{stopwatch.ElapsedMilliseconds}");