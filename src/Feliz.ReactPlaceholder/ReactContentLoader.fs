namespace Feliz.ReactContentLoader

open Fable.Core.JsInterop
open Fable.Core
open Feliz

type Event = Browser.Types.Event

[<Erase>]
type style =
    static member inline background(background: string) = Interop.mkAttr "background" background
    static member inline color(color: string) = Interop.mkAttr "color" color
    static member inline border(border: string) = Interop.mkAttr "border" border
    static member inline width(width: int) = Interop.mkAttr "width" width
    static member inline height(heigth: int) = Interop.mkAttr "heigth" heigth
    static member inline stroke(stroke: string) = Interop.mkAttr "stroke" stroke

[<Erase>]
type labelStyle =
    static member inline fill(fill: string) = Interop.mkAttr "fill" fill
    static member inline fontWeight(fontWeight: int) = Interop.mkAttr "fontWeight" fontWeight

[<Erase>]
type Instance =
    abstract project: position -> position
    abstract fitView: {| padding: float ; includeHiddenNodes: bool |} -> unit
    abstract zoomIn: unit -> unit
    abstract zoomOut: unit -> unit
    abstract zoomTo: float -> unit
    abstract setTransform: {| x: int ;  y: int ; zoom: float |} -> unit
    abstract toObject: unit -> {| elements: Element list ; position: int * int ; zoom: float |}
    abstract getElements: unit -> Element list

[<Erase>]
type OnConnectParams =
    abstract source: ElementId
    abstract sourceHandle: Handle
    abstract target: ElementId
    abstract targetHandle: Handle

[<Erase>]
type OnConnectStartParams =
    abstract nodeId: string
    abstract handleType: HandleType

// The !! below is used to "unsafely" expose a prop into an IReactContentLoaderProp.
[<Erase>]
type ReactContentLoader =
    /// Creates a new ReactContentLoader component.

    static member inline flowChart (props: IReactContentLoaderProp seq) =
        Interop.reactApi.createElement (Interop.ReactContentLoader, createObj !!props)

    static member inline node (props: INodeProp seq): IElement =
        !!(createObj !!props)

    static member inline edge (props: IEdgeProp seq): IElement =
        !!(createObj !!props)

    static member inline handle (props: IHandleProp seq) =
        Interop.reactApi.createElement (Interop.handle, createObj !!props)

    static member inline background (props: IBackgroundProp seq) =
        Interop.reactApi.createElement (Interop.background, createObj !!props)

    static member inline miniMap (props: IMiniMapProp seq) =
        Interop.reactApi.createElement (Interop.miniMap, createObj !!props)

    static member inline controls (props: IControlsProp seq) =
        Interop.reactApi.createElement (Interop.controls, createObj !!props)

    // Basic Props

    static member inline elements(elements: IElement array) : IReactContentLoaderProp = !!("elements" ==> elements)

    static member inline style(style: string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "style" style

    static member inline className(className: string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "className" className

    static member inline children (children: ReactElement list) =
        unbox<IReactContentLoaderProp> (prop.children children)

    // Flow View

    static member inline minZoom(minZoom : float) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "minZoom" minZoom

    static member inline maxZoom(maxZoom : float) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "maxZoom" maxZoom

    static member inline defaultZoom(defaultZoom : float) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "defaultZoom" defaultZoom

    static member inline defaultPosition(x: int, y: int) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "defaultPosition" (x, y)

    static member inline snapToGrid(snapToGrid : bool) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "snapToGrid" snapToGrid

    static member inline snapGrid(x: int, y: int) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "snapGrid" (x, y)

    static member inline onlyRenderVisibleElements(onlyRenderVisibleElements : bool) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "onlyRenderVisibleElements" onlyRenderVisibleElements

    static member inline translateExtent(translateExtent : (string * string) * (string * string)) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "translateExtent" translateExtent

    static member inline nodeExtent(nodeExtent : (string * string) * (string * string)) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "nodeExtent" nodeExtent

    // Event Handlers

    // Because the event helpers are inlined, Fable uncurrying is not working
    // so we make the conversion to delegate (Func) explicitly
    static member inline onElementClick(handler: Event -> Element -> unit) : IReactContentLoaderProp =
        !!("onElementClick" ==> System.Func<_,_,_>handler)

    static member inline onElementsRemove(handler: Element[] -> unit) : IReactContentLoaderProp =
        !!("onElementsRemove" ==> handler)

    static member inline onNodeDragStart(handler: Event -> Node -> unit) : IReactContentLoaderProp =
        !!("onNodeDragStart" ==> System.Func<_,_,_>handler)

    static member inline onNodeDrag(handler: Event -> Node -> unit) : IReactContentLoaderProp =
        !!("onNodeDrag" ==> System.Func<_,_,_>handler)

    static member inline onNodeDragStop(handler: Event -> Node -> unit) : IReactContentLoaderProp =
        !!("onNodeDragStop" ==> System.Func<_,_,_>handler)

    static member inline onNodeMouseEnter(handler: Event -> Node -> unit) : IReactContentLoaderProp =
        !!("onNodeMouseEnter" ==> System.Func<_,_,_>handler)

    static member inline onNodeMouseMove(handler: Event -> Node -> unit) : IReactContentLoaderProp =
        !!("onNodeMouseMove" ==> System.Func<_,_,_>handler)

    static member inline onNodeMouseLeave(handler: Event -> Node -> unit) : IReactContentLoaderProp =
        !!("onNodeMouseLeave" ==> System.Func<_,_,_>handler)

    static member inline onNodeContextMenu(handler: Event -> Node -> unit) : IReactContentLoaderProp =
        !!("onNodeContextMenu" ==> System.Func<_,_,_>handler)

    static member inline onNodeDoubleClick(handler: Event -> Node -> unit) : IReactContentLoaderProp =
        !!("onNodeDoubleClick" ==> handler)

    static member inline onConnect(handler: OnConnectParams -> unit) : IReactContentLoaderProp =
        !!("onConnect" ==> handler)

    static member inline onConnectStart(handler: Event -> OnConnectStartParams -> unit) : IReactContentLoaderProp =
        !!("onConnectStart" ==> System.Func<_,_,_>handler)

    static member inline onConnectStop(handler: Event -> unit) : IReactContentLoaderProp =
        !!("onConnectStop" ==> handler)

    static member inline onConnectEnd(handler: Event -> unit) : IReactContentLoaderProp =
        !!("onConnectEnd" ==> handler)

    static member inline onEdgeUpdate(handler: Event -> Edge -> unit) : IReactContentLoaderProp =
        !!("onEdgeUpdate" ==> handler)

    static member inline onEdgeMouseEnter(handler: Event -> Edge -> unit) : IReactContentLoaderProp =
        !!("onEdgeMouseEnter" ==> handler)

    static member inline onEdgeMouseMove(handler: Event -> Edge -> unit) : IReactContentLoaderProp =
        !!("onEdgeMouseMove" ==> handler)

    static member inline onEdgeMouseLeave(handler: Event -> Edge -> unit) : IReactContentLoaderProp =
        !!("onEdgeMouseLeave" ==> handler)

    static member inline onEdgeContextMenu(handler: Event -> Edge -> unit) : IReactContentLoaderProp =
        !!("onEdgeContextMenu" ==> handler)

    //TODO: Test if that works

    static member inline onEdgeUpdateStart(handler: Event -> Edge -> unit) : IReactContentLoaderProp =
        !!("onEdgeUpdateStart" ==> handler)

    static member inline onEdgeUpdateEnd(handler: Event -> Edge -> unit) : IReactContentLoaderProp =
        !!("onEdgeUpdateEnd" ==> handler)

    static member inline onLoad(ReactContentLoaderInstance: Instance option -> unit) : IReactContentLoaderProp =
        !!("onLoad" ==> ReactContentLoaderInstance)

    static member inline onMove(flowTransform: unit) : IReactContentLoaderProp =
        !!("onMove" ==> flowTransform)

    static member inline onMoveStart(flowTransform: unit) : IReactContentLoaderProp =
        !!("onMoveStart" ==> flowTransform)

    static member inline onMoveEnd(flowTransform: unit) : IReactContentLoaderProp =
        !!("onMoveEnd" ==> flowTransform)

    static member inline onSelectionChange(handler: Element [] -> unit) : IReactContentLoaderProp =
        !!("onSelectionChange" ==> handler)

    static member inline onSelectionDragStart(handler: Event -> Node [] -> unit) : IReactContentLoaderProp =
        !!("onSelectionDragStart" ==> handler)

    static member inline onSelectionDrag(handler: Event -> Node [] -> unit) : IReactContentLoaderProp =
        !!("onSelectionDrag" ==> handler)

    static member inline onSelectionDragStop(handler: Event -> Node [] -> unit) : IReactContentLoaderProp =
        !!("onSelectionDragStop" ==> handler)

    static member inline onSelectionContextMenu(handler: Event -> Node [] -> unit) : IReactContentLoaderProp =
        !!("onSelectionContextMenu" ==> handler)

    static member inline onPaneClick(handler: Event -> unit) : IReactContentLoaderProp =
        !!("onPaneClick" ==> handler)

    static member inline onPaneContextMenu(handler: Event -> unit) : IReactContentLoaderProp =
        !!("onPaneContextMenu" ==> handler)

    static member inline onPaneScroll(handler: Event -> unit) : IReactContentLoaderProp =
        !!("onPaneScroll" ==> handler)

    // Interaction

    static member inline nodesDraggable(nodesDraggable : bool) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "nodesDraggable" nodesDraggable

    static member inline nodesConnectable(nodesConnectable : bool) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "nodesConnectable" nodesConnectable

    static member inline elementsSelectable(elementsSelectable : bool) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "elementsSelectable" elementsSelectable

    static member inline zoomOnScroll(zoomOnScroll : bool) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "zoomOnScroll" zoomOnScroll

    static member inline zoomOnPinch(zoomOnPinch : bool) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "zoomOnPinch" zoomOnPinch

    static member inline panOnScroll(panOnScroll : bool) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "panOnScroll" panOnScroll

    static member inline panOnScrollSpeed(panOnScrollSpeed : float) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "panOnScrollSpeed" panOnScrollSpeed

    static member inline panOnScrollMode(panOnScrollMode : ScrollMode) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "panOnScrollMode" panOnScrollMode

    static member inline zoomOnDoubleClick(zoomOnDoubleClick : bool) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "zoomOnDoubleClick" zoomOnDoubleClick

    static member inline selectNodesOnDrag(selectNodesOnDrag : bool) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "selectNodesOnDrag" selectNodesOnDrag

    static member inline paneMoveable(paneMoveable : bool) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "paneMoveable" paneMoveable

    static member inline connectionMode(connectionMode : ConnectionMode) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "connectionMode" connectionMode

    // Element customization

    static member inline nodeTypes(nodeTypes: obj) : IReactContentLoaderProp = !!("nodeTypes" ==> nodeTypes)

    static member inline edgeTypes(edgeTypes: obj) : IReactContentLoaderProp = !!("edgeTypes" ==> edgeTypes)

    static member inline arrowHeadColor(arrowHeadColor : string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "arrowHeadColor" arrowHeadColor

    static member inline markerEndId(markerEndId : string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "markerEndId" markerEndId

    // Connection Line Options

    static member inline connectionLineType(connectionLineType: ConnectionLineType) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "connectionLineType" connectionLineType

    // static member inline connectionLineStyle(connectionLineStyle: Fable.React.FragmentProps.SVGAttr []) : IReactContentLoaderProp =
    //     Interop.mkReactContentLoaderProp "connectionLineStyle" connectionLineStyle

    static member inline connectionLineComponent(connectionLineComponent: string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "connectionLineComponent" connectionLineComponent

    // Keys

    static member inline deleteKeyCode(deleteKeyCode: string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "deleteKeyCode" deleteKeyCode
    static member inline deleteKeyCode(deleteKeyCode: int) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "deleteKeyCode" deleteKeyCode

    static member inline selectionKeyCode(selectionKeyCode: string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "selectionKeyCode" selectionKeyCode
    static member inline selectionKeyCode(selectionKeyCode: int) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "selectionKeyCode" selectionKeyCode

    static member inline multiSelectionKeyCode(multiSelectionKeyCode: string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "multiSelectionKeyCode" multiSelectionKeyCode
    static member inline multiSelectionKeyCode(multiSelectionKeyCode: int) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "multiSelectionKeyCode" multiSelectionKeyCode
    static member inline zoomActivationKeyCode(zoomActivationKeyCode: string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "zoomActivationKeyCode" zoomActivationKeyCode
    static member inline zoomActivationKeyCode(zoomActivationKeyCode: int) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "zoomActivationKeyCode" zoomActivationKeyCode
