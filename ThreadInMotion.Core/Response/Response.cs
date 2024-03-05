﻿namespace ThreadInMotion.Core
{
    public class Response<T>
    {
		public T Data { get; set; } = default!;
		public IList<T> Collection { get; set; } = null!;
		public bool IsValidationError { get; set; }
		public int Success { get; set; } = 0;
		public string Message { get; set; } = null!;
	}
}