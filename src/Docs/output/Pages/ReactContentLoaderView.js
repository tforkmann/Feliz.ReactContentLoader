import { createElement } from "react";
import React from "react";
import { singleton, ofArray } from "../fable_modules/fable-library.4.9.0/List.js";
import { Interop_reactApi } from "../fable_modules/Feliz.2.7.0/Interop.fs.js";
import { Interop_reactApi as Interop_reactApi_1 } from "../fable_modules/Feliz.2.7.0/Interop.fs.js";
import { ReactContentLoader as ReactContentLoader_1 } from "../fable_modules/Feliz.ReactContentLoader.0.2.2/Interop.fs.js";
import { createObj } from "../fable_modules/fable-library.4.9.0/Util.js";
import { fixDocsView, codedView } from "../SharedView.js";

export function ReactContentLoader() {
    let children;
    const props_3 = [["speed", 3], ["title", "Test"], ["interval", 0.9], (children = ofArray([createElement("rect", {
        x: 0,
        y: 0,
        rx: 5,
        ry: 5,
        width: 70,
        height: 70,
    }), createElement("rect", {
        x: 80,
        y: 17,
        rx: 4,
        ry: 4,
        width: 300,
        height: 13,
    }), createElement("rect", {
        x: 80,
        y: 40,
        rx: 3,
        ry: 3,
        width: 250,
        height: 10,
    })]), ["children", Interop_reactApi.Children.toArray(Array.from(children))])];
    return Interop_reactApi_1.createElement(ReactContentLoader_1, createObj(props_3));
}

export const ReactContentLoaderExample = createElement("div", createObj(ofArray([["style", {
    height: 800,
}], (() => {
    const elems = [createElement(ReactContentLoader, null)];
    return ["children", Interop_reactApi.Children.toArray(Array.from(elems))];
})()])));

export const code = "\n    ReactContentLoader.contentLoader [\n        ReactContentLoader.speed 3.\n        ReactContentLoader.title \"Test\"\n        ReactContentLoader.interval 0.9\n        ReactContentLoader.children [\n            Svg.rect [\n                svg.x 0.\n                svg.y 0.\n                svg.rx 5.\n                svg.ry 5.\n                svg.width 70\n                svg.height 70\n            ]\n            Svg.rect [\n                svg.x 80.\n                svg.y 17.\n                svg.rx 4.\n                svg.ry 4.\n                svg.width 300\n                svg.height 13\n            ]\n            Svg.rect [\n                svg.x 80.\n                svg.y 40.\n                svg.rx 3.\n                svg.ry 3.\n                svg.width 250\n                svg.height 10\n            ]\n        ]\n    ]\n    ";

export const title = "QR Code";

export function ReactContentLoaderView() {
    let elms;
    const children_1 = ofArray([(elms = singleton(codedView(title, code, ReactContentLoaderExample)), createElement("div", {
        className: "content",
        children: Interop_reactApi.Children.toArray(Array.from(elms)),
    })), fixDocsView("ReactContentLoader", false)]);
    return createElement("div", {
        children: Interop_reactApi.Children.toArray(Array.from(children_1)),
    });
}

