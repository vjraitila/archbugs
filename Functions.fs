namespace Arch.Bugs.FsharpCoreFunctions

open Microsoft.Azure.WebJobs
open Microsoft.AspNetCore.Http

module Functions =

    [<FunctionName("HelloYou")>]
    let helloYou
        ([<HttpTrigger(Extensions.Http.AuthorizationLevel.Anonymous, "get", Route = "hello")>]
        req: HttpRequest) =
            HelloYou.run req