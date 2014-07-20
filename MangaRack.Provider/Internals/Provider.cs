﻿// ======================================================================
// This source code form is subject to the terms of the Mozilla Public
// License, version 2.0. If a copy of the MPL was not distributed with 
// this file, you can obtain one at http://mozilla.org/MPL/2.0/.
// ======================================================================
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using MangaRack.Provider.Interfaces;

namespace MangaRack.Provider.Internals
{
    internal class Provider : IProvider
    {
        private readonly IProvider _provider;

        #region Constructor

        public Provider(IProvider provider)
        {
            Contract.Requires<ArgumentNullException>(provider != null);
            _provider = provider;
        }

        #endregion

        #region Contract

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_provider != null);
        }

        #endregion

        #region Implementation of IProvider:Methods

        public ISeries Open(string location)
        {
            var series = _provider.Open(location);
            return series == null ? null : new Series(series);
        }

        public void Search(string input, Action<IEnumerable<ISeries>> done)
        {
            _provider.Search(input, series => done(series.Select(x => new Series(x))));
        }

        #endregion

        #region Implementation of IProvider:Properties

        public string Location
        {
            get { return _provider.Location; }
        }

        #endregion
    }
}