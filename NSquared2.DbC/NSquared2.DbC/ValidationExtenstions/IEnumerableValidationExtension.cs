﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace NSquared2.DbC.ValidationExtenstions
{
    public static class IEnumerableValidationExtension
	{
		[DebuggerHidden]
		public static Validation<IEnumerable<T>> NotNullOrEmpty<T>(this Validation<IEnumerable<T>> items) where T : class
		{
			if (items.Value == null || !items.Value.Any())
				throw new ArgumentNullException(string.Format("InputParam '{0}' cannot be null or Empty", items.ParameterName));

			return items;
		}
	}
}