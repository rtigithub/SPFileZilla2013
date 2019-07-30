namespace BandR
{
     public class Enums
     {
          #region Public Classes

          public class IconImages
          {
               #region Public Fields

               public const int FILE = 1;
               public const int FOLDER = 0;
               public const int LIST = 3;
               public const int REFRESH = 2;

               #endregion Public Fields
          }

          public class TreeNodeActions
          {
               #region Public Fields

               public const string REFRESH = "0";
               public const string UP = "1";

               #endregion Public Fields
          }

          public class TreeNodeTypes
          {
               #region Public Fields

               public const int FILE = 1;
               public const int FOLDER = 0;
               public const int LIST = 2;
               public const int OTHER = -1;

               #endregion Public Fields
          }

          #endregion Public Classes
     }
}