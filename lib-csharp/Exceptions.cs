using System;

namespace UtopiaLib
{
	public class ApiErrorException : ApplicationException {
		public ApiErrorException() {}
		public ApiErrorException(string message) : base(message) { }
		public ApiErrorException(string message, Exception inner) : base(message, inner) { }
	}
}
