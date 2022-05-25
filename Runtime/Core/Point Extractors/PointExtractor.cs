using System;
using UnityEngine;

namespace Engine.Tools.LinesCurvesSplines {
	public abstract class PointExtractor<T> {
		public abstract ExtractionData Extract(T polynomial, int numOfDivisions);

		public void EnableLogging()
			=> _loggingEnabled = true;

		public void DisableLogging()
			=> _loggingEnabled = false;

		protected abstract void SetDivisionsPerCurve(T spline, int numberOfDivisions);

		protected void ResizeArray(int size) {
			if (size < 1)
				return;

			Array.Resize(ref _cachedExtractedPointsArray, size);
		}

		protected void SetPoint(Vector2 point, int index) {
			if (index > _cachedExtractedPointsArray.Length - 1)
				return;

			_cachedExtractedPointsArray[index] = point;
		}

		protected void SetStep()
			=> _step = (float)1 / _divisionsPerCurve;

		protected void Log(string message) {
			if (_loggingEnabled)
				Utility.Log.Message(message);
		}

		protected void ResetProgress()
			=> _progress = 0f;

		protected Vector2[] ExtractedPoints
			=> _cachedExtractedPointsArray;

		protected bool GuardAgainstExtraction(int value)
			=> value < 2;

		protected float VerifyProgress(float progress) {
			if (progress > 1)
				return 1;

			return progress;
		}

		protected int _divisionsPerCurve;

		protected float _step;

		protected float _progress;

		Vector2[] _cachedExtractedPointsArray;

		bool _loggingEnabled;

		protected PointExtractor()
			=> _cachedExtractedPointsArray = new Vector2[0];
	}

	public interface IPointExtractor {
		ExtractionData Extract<U>(U polynomial, int numOfDivisions);
	}
}