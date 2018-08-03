using System;
using System.Diagnostics;

namespace GarFit {
	public enum LogType {
		Information,
		Warning,
		Error
	}
	
	/// <summary>
	/// Description of Utils.
	/// </summary>
	public static class Utils {
		private static log4net.ILog logger = log4net.LogManager.GetLogger("Log");
		
		/// <summary>
		/// Log the message
		/// </summary>
		/// <param name="logType"></param>
		/// <param name="message"></param>
		/// <param name="exception"></param>
		public static void LogMessage(LogType logType, string message, Exception exception) {
			if (logger == null)
				logger = log4net.LogManager.GetLogger("Log");
			
			if (!string.IsNullOrEmpty(message)) {
                //logger.Debug(message, exception);

				switch (logType) {
					case LogType.Information:
						logger.Info(message, exception);
						break;
					case LogType.Warning:
						logger.Warn(message, exception);
						break;
					case LogType.Error:
						logger.Error(message, exception);
						break;
				}
			} else {
                //logger.Debug(exception.Message, exception);

				switch (logType) {
					case LogType.Information:
						logger.Info(exception.Message, exception);
						break;
					case LogType.Warning:
						logger.Warn(exception.Message, exception);
						break;
					case LogType.Error:
						logger.Error(exception.Message, exception);
						break;
				}
			}
		}
		
		public static void LogMessage(LogType logType, string message) {
			LogMessage(logType, message, null);
		}
		
		public static int? ConvertTcxLatLongToFit(double value) {
			return (int?)(value * (2 ^ 31) / 180);
		}
	}
}
