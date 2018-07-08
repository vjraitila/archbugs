namespace Arch.Bugs.FsharpCoreFunctions

open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Mvc

module HelloYou =

    let run (req: HttpRequest) =
        ContentResult(Content = "Hello", ContentType = "text/html")