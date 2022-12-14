namespace Feliz.ReactContentLoader

open Fable.Core
open Fable.Core.JsInterop

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkStyleProp (key: string) (value: obj) : IStyleProp = unbox (key, value)
    let inline mkReactContentLoaderProp (key: string) (value: obj) : IReactContentLoaderProp = unbox (key, value)
    let ReactContentLoader : obj = importDefault "react-content-loader"
    let Facebook : obj = import "Facebook" "react-content-loader"
    let Instagram : obj = import "Instagram" "react-content-loader"
    let Code : obj = import "Code" "react-content-loader"
    let List : obj = import "List" "react-content-loader"
    let BulletList : obj = import "BulletList" "react-content-loader"