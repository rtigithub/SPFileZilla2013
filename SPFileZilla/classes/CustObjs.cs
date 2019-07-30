namespace BandR.CustObjs
{
     using System;

     public class ProfileDetail
     {
          #region Public Properties

          public string domain { get; set; }
          public bool isSpOnline { get; set; }
          public string password { get; set; }
          public string profileName { get; set; }
          public string siteUrl { get; set; }
          public string username { get; set; }

          #endregion Public Properties
     }

     public class SessionDetail
     {
          #region Public Constructors

          public SessionDetail()
          {
               localPath = "C:\\";
               winWidth = 0;
               winHeight = 0;

               editorFontSize = "9";
               editorColorIsWhite = "1";
               editorTextIsWrap = "0";

               spUrl = "";
               isSPOnline = false;
          }

          #endregion Public Constructors

          #region Public Properties

          public string editorColorIsWhite { get; set; }
          public string editorFontSize { get; set; }
          public string editorTextIsWrap { get; set; }
          public bool isSPOnline { get; set; }
          public string localPath { get; set; }
          public string spUrl { get; set; }
          public int winHeight { get; set; }
          public int winWidth { get; set; }

          #endregion Public Properties
     }

     public class SortingFSObject
     {
          #region Public Properties

          public DateTime? dtmodified { get; set; }
          public string name { get; set; }
          public string path { get; set; }
          public long? size { get; set; }

          #endregion Public Properties
     }

     public class SPTree_FolderFileObj
     {
          #region Public Properties

          public DateTime? dtModified { get; set; }

          // special
          public int folderLevel { get; set; }

          public int? length { get; set; }
          public string name { get; set; }
          public int treeNodeType { get; set; }

          public string url { get; set; }

          #endregion Public Properties
     }

     public class SPTree_ListObj
     {
          #region Public Properties

          public Guid Id { get; set; }
          public string Title { get; set; }

          #endregion Public Properties
     }
}