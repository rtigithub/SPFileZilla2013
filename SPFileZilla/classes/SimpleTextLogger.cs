namespace BandR
{
     using System;

     public static class SimpleTextLogger
     {
          #region Private Fields

          private const bool USE_LOG = true;

          #endregion Private Fields

          // #changeme should be false

          #region Public Methods

          /// <summary>
          /// </summary>
          public static void Write(string msg)
          {
               try
               {
                    if (System.Environment.MachineName == "PERSEUS" || USE_LOG)
                    {
                         System.IO.File.AppendAllText("c:\\temp\\spfilezilla.log.txt", DateTime.Now.ToString("o") + ": " + msg + Environment.NewLine);
                    }
               }
               catch (Exception)
               {
                    // do nothing
               }
          }

          #endregion Public Methods
     }
}