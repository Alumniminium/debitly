#!/usr/bin/env dotnet-script

using System.Net;

if (Args.Count == 0)
    Console.WriteLine("Usage: debitly https://bitly.is/2qkERYx");
var bitlyArg = Args[0];
var hash = bitlyArg.Substring(bitlyArg.LastIndexOf("/") + 1);
var bitlyUri = "http://bit.ly/" + hash;
var json = new System.Net.WebClient().DownloadString(@"https://api-ssl.bitly.com/v3/expand?access_token=828cf2aa154cdb8f31130992426314144471a6dc&shortUrl=" + bitlyUri);

var longUrl = json.Substring(json.IndexOf("\"long_url\":")).Split("\"")[3];

Console.WriteLine(longUrl);




