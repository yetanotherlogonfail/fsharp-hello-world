module HelloWorld.Tests

open Xunit
open HelloWorld.Program

[<Fact>]
let ``sayHello returns correct message`` () =
    let result = sayHello ()
    Assert.Equal("Hello, World!", result)