using Adita.PlexNet.Core.Hosting;
using System.Windows;
using System;

namespace Adita.PlexNet.Wpf.Hosting
{
    /// <summary>
    /// Provides an abstraction for Windows Presentation Foundation application that has services.
    /// </summary>
    public interface IWpfApplication : IApplication
    {
        #region Methods
        /// <summary>
        /// Starts a Windows Presentation Foundation application and opens the specified <paramref name="window"/>.
        /// </summary>
        /// <param name="window"></param>
        /// <returns>
        /// The <see cref="Int32"/> application exit code that is returned to the operating system when the application shuts down. By default, the exit code value is 0.
        /// </returns>
        int Run(Window window);
        #endregion Methods
    }
}
