module HelloWorld.Program

let sayHello () = "Hello, World!"

[<EntryPoint>]
let main argv =
    printfn "%s" (sayHello ())
    0