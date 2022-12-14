module Router

open Feliz.Router

type Page =
    | FelizReactContentLoader
    | FelizReactContentLoaderInstallation
    | FelizReactContentLoaderExampleFlow

let defaultPage = FelizReactContentLoader

let parseUrl = function
    | [ "" ] -> FelizReactContentLoader
    | [ "installation" ] -> FelizReactContentLoaderInstallation
    | [ "exampleflow" ] -> FelizReactContentLoaderExampleFlow
    | _ -> defaultPage

let getHref = function
    | FelizReactContentLoader -> Router.format("")
    | FelizReactContentLoaderInstallation -> Router.format("installation")
    | FelizReactContentLoaderExampleFlow -> Router.format("exampleflow")
