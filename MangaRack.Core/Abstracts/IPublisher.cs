﻿// ======================================================================
using System.Collections.Generic;
using MangaRack.Core.Serializers;

namespace MangaRack.Core.Abstracts {
	/// <summary>
	/// Represents a publisher.
	/// </summary>
	public interface IPublisher {
		#region Methods
		/// <summary>
		/// Publish an image.
		/// </summary>
		/// <param name="image">The image.</param>
		/// <param name="previewImage">Indicates whether this is a preview image.</param>
		/// <param name="number">The number, when not a preview image.</param>
		ComicInfoPage Publish(byte[] image, bool previewImage, int number);

		/// <summary>
		/// Publish comic information.
		/// </summary>
		/// <param name="comicInfo">The comic information.</param>
		void Publish(ComicInfo comicInfo);

		/// <summary>
		/// Publish broken page information.
		/// </summary>
		/// <param name="brokenPages">Each broken page.</param>
		void Publish(IEnumerable<string> brokenPages);
		#endregion
	}
}