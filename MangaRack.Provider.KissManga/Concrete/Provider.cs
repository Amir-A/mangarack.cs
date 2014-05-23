﻿// ======================================================================
// This source code form is subject to the terms of the Mozilla Public
// License, version 2.0. If a copy of the MPL was not distributed with 
// this file, you can obtain one at http://mozilla.org/MPL/2.0/.
// ======================================================================
using System.Text.RegularExpressions;

namespace MangaRack.Provider.KissManga {
	/// <summary>
	/// Represents a KissManga provider.
	/// </summary>
	sealed class Provider : IProvider {
		#region Properties
		/// <summary>
		/// Contains the domain.
		/// </summary>
		public static string Domain {
			get {
				// Return the value.
				return "http://kissmanga.com";
			}
		}
		#endregion

		#region IProvider:Methods
		/// <summary>
		/// Open a series.
		/// </summary>
		/// <param name="uniqueIdentifier">The unique identifier.</param>
		public ISeries Open(string uniqueIdentifier) {
			// Check if the unique identifier can be handled.
			if (Regex.Match(uniqueIdentifier, @"^http://kissmanga\.com/Manga/(.*)$", RegexOptions.IgnoreCase).Success) {
				// Initialize a new instance of the Series class.
				return new Series(uniqueIdentifier);
			}
			// Return null.
			return null;
		}

		/// <summary>
		/// Search series.
		/// </summary>
		/// <param name="input">The input.</param>
		public ISearch Search(string input) {
			// Initialize a new instance of the Search class.
			return new Search(input);
		}
		#endregion

		#region IProvider:Properties
		/// <summary>
		/// Contains the unique identifier.
		/// </summary>
		public string UniqueIdentifier {
			get {
				// Return the unique identifier.
				return "KissManga";
			}
		}
		#endregion
	}
}