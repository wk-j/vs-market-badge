// Learn more about F# at http://fsharp.org

open System

let template name =
    let template =
        """
        [![Version](https://vsmarketplacebadge.apphb.com/version/{name}.svg)](https://marketplace.visualstudio.com/items?itemName={name}) [![Installs](https://vsmarketplacebadge.apphb.com/installs-short/{name}.svg)](https://marketplace.visualstudio.com/items?itemName={name})
        """
    template.Replace("{name}", name).Trim()

[<EntryPoint>]
let main argv =
    match argv with
    | [| name |] ->
        printfn "%s" (template name)
    | _ ->
        printfn "use 'wk-vs-market-badge <name>'"
    0 // return an integer exit code
