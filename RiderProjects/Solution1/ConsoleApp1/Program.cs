// See https://aka.ms/new-console-template for more information

open System
open System.Net.WebClient
open System.Windows.Forms

let webClient = new WebClient()
let fsharpOrg = webClient.DownloadString(Uri "http://fsharp.org")
let browser = new WebBrowser(ScriptErrorsSuppressed = true, Dock = DockStyle.Fill, DocumentText = fsharpOrg)
let form = new Form(Text = "Hello from F#!")
form.Controls.Add browser
form.Show()

