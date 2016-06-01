let emptyStringValidator writer message = 
    if System.String.IsNullOrWhiteSpace message then
        printfn "Validation error"
    else
        writer message

let consoleWriter message =
    printfn "Console writer -> %s" message

let loggingWriter logger writer message =
    logger message
    writer message

let consoleLogger message =
    printfn "Console logger -> %s" message
    
let loggingWithConsoleLoggerAndConsoleWritter = loggingWriter consoleLogger consoleWriter
let validatorWithLogging = emptyStringValidator loggingWithConsoleLoggerAndConsoleWritter

validatorWithLogging "" |> ignore

let decoratedWriter = emptyStringValidator (loggingWriter consoleLogger consoleWriter)
decoratedWriter "" |> ignore