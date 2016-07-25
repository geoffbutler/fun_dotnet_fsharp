namespace FsFun.Tests

module ProgramShould = 
    open Program
    open Xunit


    [<Fact>]
    let return_false() = 
        
        let expected = false

        let result = Program.return_false

        Assert.StrictEqual(expected, result)


    [<Fact>]
    let return_true() = 
        
        let expected = true

        let result = Program.return_true

        Assert.StrictEqual(expected, result)