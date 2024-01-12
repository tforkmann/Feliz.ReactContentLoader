import { createElement } from "react";
import React from "react";
import * as react from "react";
import { Interop_reactApi } from "../fable_modules/Feliz.2.7.0/Interop.fs.js";
import { createObj } from "../fable_modules/fable-library.4.9.0/Util.js";
import { singleton, ofArray } from "../fable_modules/fable-library.4.9.0/List.js";

export function InstallView() {
    let elm_2, children, elems_2, elm_6, children_3, elems_6;
    const xs_8 = [createElement("div", {
        className: "description",
        children: Interop_reactApi.Children.toArray(["Using NuGet package command"]),
    }), (elm_2 = singleton((children = singleton(createElement("pre", createObj(ofArray([["data-prefix", "$"], (elems_2 = [createElement("code", {
        children: ["Install-Package Feliz.ReactContentLoader"],
    })], ["children", Interop_reactApi.Children.toArray(Array.from(elems_2))])])))), createElement("div", {
        className: "mockup-code",
        children: Interop_reactApi.Children.toArray(Array.from(children)),
    }))), createElement("div", {
        className: "max-w-xl",
        children: Interop_reactApi.Children.toArray(Array.from(elm_2)),
    })), createElement("div", {
        className: "description",
        children: Interop_reactApi.Children.toArray(["or Paket"]),
    }), (elm_6 = singleton((children_3 = singleton(createElement("pre", createObj(ofArray([["data-prefix", "$"], (elems_6 = [createElement("code", {
        children: ["paket add Feliz.ReactContentLoader"],
    })], ["children", Interop_reactApi.Children.toArray(Array.from(elems_6))])])))), createElement("div", {
        className: "mockup-code",
        children: Interop_reactApi.Children.toArray(Array.from(children_3)),
    }))), createElement("div", {
        className: "max-w-xl",
        children: Interop_reactApi.Children.toArray(Array.from(elm_6)),
    }))];
    return react.createElement(react.Fragment, {}, ...xs_8);
}

