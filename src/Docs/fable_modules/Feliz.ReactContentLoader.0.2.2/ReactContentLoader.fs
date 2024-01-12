namespace Feliz.ReactContentLoader

open Fable.Core.JsInterop
open Fable.Core
open Feliz

[<Erase>]
type ReactContentLoader =
    /// Creates a new ReactContentLoader component.

    static member inline contentLoader (props: IReactContentLoaderProp seq) =
        Interop.reactApi.createElement (Interop.ReactContentLoader, createObj !!props)
    static member inline facebook (props: IReactContentLoaderProp seq) =
        Interop.reactApi.createElement (Interop.Facebook, createObj !!props)
    static member inline instagram (props: IReactContentLoaderProp seq) =
        Interop.reactApi.createElement (Interop.Instagram, createObj !!props)
    static member inline code (props: IReactContentLoaderProp seq) =
        Interop.reactApi.createElement (Interop.Code, createObj !!props)
    static member inline list (props: IReactContentLoaderProp seq) =
        Interop.reactApi.createElement (Interop.Instagram, createObj !!props)
    static member inline bulletList (props: IReactContentLoaderProp seq) =
        Interop.reactApi.createElement (Interop.BulletList, createObj !!props)

    // Basic Props

    static member inline style(style: string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "style" style

    static member inline className(className: string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "className" className

    static member inline children (children: ReactElement list) =
        unbox<IReactContentLoaderProp> (prop.children children)

    static member inline animate(animate : bool) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "animate" animate

    static member inline title(title : string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "title" title

    static member inline baseUrl(baseUrl : string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "baseUrl" baseUrl

    static member inline speed(speed: float) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "speed" speed

    static member inline interval(interval : float) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "interval" interval

    static member inline height(height : float) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "height" height

    static member inline width(width : float) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "width" width
    static member inline viewBox(viewBox: string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "viewBox" viewBox

    static member inline gradientRatio(gradientRatio : float) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "gradientRatio" gradientRatio

    static member inline gradientDirection(gradientDirection  : string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "gradientDirection" gradientDirection
    static member inline rtl(rtl  : bool) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "rtl" rtl

    static member inline backgroundColor(backgroundColor : string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "backgroundColor" backgroundColor
    static member inline foregroundColor(foregroundColor : string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "foregroundColor" foregroundColor
    static member inline backgroundOpacity(backgroundOpacity : float) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "backgroundOpacity" backgroundOpacity
    static member inline foreGroundOpacity(foreGroundOpacity : float) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "foreGroundOpacity" foreGroundOpacity
    static member inline uniqueKey(uniqueKey : string) : IReactContentLoaderProp =
        Interop.mkReactContentLoaderProp "uniqueKey" uniqueKey
