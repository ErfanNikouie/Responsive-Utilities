using UnityEngine;

namespace Mosaic.Utilities.Responsive
{
	public enum ScaleMethod
	{
		MatchScreenSizeX,
		MatchScreenSizeY,
		MatchScreenSizeBoth,
		ExpandByRatio,
		ExpandByCompoundRatio,
	}

	[System.Serializable]
	public class ScaleOperation
	{
		[SerializeField] private ScaleMethod scaleMethod = ScaleMethod.ExpandByRatio;
		[SerializeField] private RatioXY relativeXY = new RatioXY(0.5f, 0.5f);

		public void Apply(RectTransform rectTransform)
		{
			switch (scaleMethod)
			{
				case ScaleMethod.MatchScreenSizeX:
					rectTransform?.ScaleToMatchScreenSize(relativeXY, useY: false);
					break;

				case ScaleMethod.MatchScreenSizeY:
					rectTransform?.ScaleToMatchScreenSize(relativeXY, useX: false);
					break;

				case ScaleMethod.MatchScreenSizeBoth:
					rectTransform?.ScaleToMatchScreenSize(relativeXY);
					break;

				case ScaleMethod.ExpandByRatio:
					rectTransform?.ScaleToExpandByRatio(relativeXY);
					break;

				case ScaleMethod.ExpandByCompoundRatio:
					rectTransform?.ScaleToExpandByCompoundRatio(relativeXY);
					break;

				default:
					break;
			}
		}
	}
}
