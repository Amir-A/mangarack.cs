﻿// ======================================================================
// This source code form is subject to the terms of the Mozilla Public
// License, version 2.0. If a copy of the MPL was not distributed with 
// this file, you can obtain one at http://mozilla.org/MPL/2.0/.
// ======================================================================
using HtmlAgilityPack;

namespace MangaRack.Provider.KissManga.Extension {
    /// <summary>
    /// Represents the class providing extensions for the HtmlNode class.
    /// </summary>
    internal static class ExtensionForHtmlNode {
        #region Methods
        /// <summary>
        /// Retrieve the next element.
        /// </summary>
        /// <param name="node">The node.</param>
        public static HtmlNode NextElement(this HtmlNode node) {
            var sibling = null as HtmlNode;
            while ((sibling = sibling == null ? node.NextSibling : sibling.NextSibling) != null) {
                if (sibling.NodeType == HtmlNodeType.Element) {
                    return sibling;
                }
            }
            return node;
        }
        #endregion
    }
}