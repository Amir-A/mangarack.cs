﻿// ======================================================================
// This source code form is subject to the terms of the Mozilla Public
// License, version 2.0. If a copy of the MPL was not distributed with 
// this file, you can obtain one at http://mozilla.org/MPL/2.0/.
// ======================================================================
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using MangaRack.Provider.Interfaces;

namespace MangaRack.Provider.MangaFox
{
    public class MangaFox : IProvider
    {
        private readonly IProvider _provider;

        #region Constructor

        public MangaFox()
        {
            _provider = new Provider();
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
            return _provider.Open(location);
        }

        public void Search(string input, Action<IEnumerable<ISeries>> done)
        {
            _provider.Search(input, done);
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