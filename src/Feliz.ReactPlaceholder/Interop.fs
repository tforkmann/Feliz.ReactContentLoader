namespace Feliz.ReactContentLoader

open Fable.Core
open Fable.Core.JsInterop

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkHandleProp (key: string) (value: obj) : IHandleProp = unbox (key, value)
    let inline mkEdgeProp (key: string) (value: obj) : IEdgeProp = unbox (key, value)
    let inline mkNodeProp (key: string) (value: obj) : INodeProp = unbox (key, value)
    let inline mkStyleProp (key: string) (value: obj) : IStyleProp = unbox (key, value)
    let inline mkLabelStyleProp (key: string) (value: obj) : ILabelStyleProp = unbox (key, value)
    let inline mkReactContentLoaderProp (key: string) (value: obj) : IReactContentLoaderProp = unbox (key, value)
    let inline mkBackgroundProp (key: string) (value: obj) : IBackgroundProp = unbox (key, value)
    let inline mkMiniMapProp (key: string) (value: obj) : IMiniMapProp = unbox (key, value)
    let inline mkControlsProp (key: string) (value: obj) : IControlsProp = unbox (key, value)

    let ReactContentLoader : obj = importDefault "ReactContentLoader"
    let handle : obj = import "Handle" "ReactContentLoader"
    let background : obj = import "Background" "ReactContentLoader"
    let miniMap : obj = import "MiniMap" "ReactContentLoader"
    let controls : obj = import "Controls" "ReactContentLoader"

[<Erase; RequireQualifiedAccess>]
module Helpers =
    let isEdge : Element -> bool = import "isEdge" "ReactContentLoader"
    let isNode : Element -> bool = import "isNode" "ReactContentLoader"

    // TODO
    // let removeElements : obj = import "removeElements" "react-flow-renderer"
    // let addEdge : obj = import "addEdge" "react-flow-renderer"
    // let updateEdge : obj = import "updateEdge" "react-flow-renderer"
    // let getOutgoers : obj = import "getOutgoers" "react-flow-renderer"
    // let getIncomers : obj = import "getIncomers" "react-flow-renderer"
    // let getConnectedEdges : obj = import "getConnectedEdges" "react-flow-renderer"
