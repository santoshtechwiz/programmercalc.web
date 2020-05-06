using Microsoft.AspNetCore.Http;

namespace programmercalc.web.Services
{
   public class HashInfo
  {
    //private static string FILEPATH = HttpContext.Server.MapPath("~/App_Data/HashingInfo.xml");

    // public static string InnerXml(XElement thiz)
    // {
    //   IEnumerable<XNode> xnodes = thiz.Nodes();
    //   string empty = string.Empty;
    //   // ISSUE: reference to a compiler-generated field
    //   if (HashInfo.CS\u0024\u003C\u003E9__CachedAnonymousMethodDelegate1 == null)
    //   {
    //     // ISSUE: reference to a compiler-generated field
    //     // ISSUE: method pointer
    //     HashInfo.CS\u0024\u003C\u003E9__CachedAnonymousMethodDelegate1 = new Func<string, XNode, string>((object) null, __methodptr(\u003CInnerXml\u003Eb__0));
    //   }
    //   // ISSUE: reference to a compiler-generated field
    //   Func<string, XNode, string> anonymousMethodDelegate1 = HashInfo.CS\u0024\u003C\u003E9__CachedAnonymousMethodDelegate1;
    //   return (string) Enumerable.Aggregate<XNode, string>((IEnumerable<M0>) xnodes, (M1) empty, (Func<M1, M0, M1>) anonymousMethodDelegate1);
    // }

    // public static string GetHashInfo(string type)
    // {
    //   // ISSUE: object of a compiler-generated type is created
    //   // ISSUE: method pointer
    //   IEnumerable<M0> m0s = Enumerable.Where<XElement>((IEnumerable<M0>) XDocument.Load(HashInfo.FILEPATH).Descendants((XName) "HashAlgo"), (Func<M0, bool>) new Func<XElement, bool>((object) new HashInfo.\u003C\u003Ec__DisplayClass5()
    //   {
    //     type = type
    //   }, __methodptr(\u003CGetHashInfo\u003Eb__2)));
    //   // ISSUE: reference to a compiler-generated field
    //   if (HashInfo.CS\u0024\u003C\u003E9__CachedAnonymousMethodDelegate4 == null)
    //   {
    //     // ISSUE: reference to a compiler-generated field
    //     // ISSUE: method pointer
    //     HashInfo.CS\u0024\u003C\u003E9__CachedAnonymousMethodDelegate4 = new Func<XElement, string>((object) null, __methodptr(\u003CGetHashInfo\u003Eb__3));
    //   }
    //   // ISSUE: reference to a compiler-generated field
    //   Func<XElement, string> anonymousMethodDelegate4 = HashInfo.CS\u0024\u003C\u003E9__CachedAnonymousMethodDelegate4;
    //   return ((IEnumerable<string>) Enumerable.Select<XElement, string>(m0s, (Func<M0, M1>) anonymousMethodDelegate4)).FirstOrDefault<string>();
    // }
  }
}