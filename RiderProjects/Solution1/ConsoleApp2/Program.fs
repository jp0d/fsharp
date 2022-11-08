// For more information see https://aka.ms/fsharp-console-apps

// See https://aka.ms/new-console-template for more information

open System
open System.Net
open System.Windows

let webClient = new WebClient()
let fsharpOrg = webClient.DownloadString(Uri "http://fsharp.org")
let browser = new WebBrowser(ScriptErrorsSuppressed = true, Dock = DockStyle.Fill, DocumentText = fsharpOrg)
let form = new Form(Text = "Hello from F#!")
form.Controls.Add browser
form.Show()

