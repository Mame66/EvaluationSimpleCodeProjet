using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode;
using System.Collections.Generic;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        [TestMethod]
        public void GetBoldFormat_WithContent_ShouldReturnBoldHtml()
        {
            var helper = new HtmlFormatHelper();

            var result = helper.GetBoldFormat("Hello");

            Assert.AreEqual("<b>Hello</b>", result);
        }

        [TestMethod]
        public void GetItalicFormat_WithContent_ShouldReturnItalicHtml()
        {
            var helper = new HtmlFormatHelper();

            var result = helper.GetItalicFormat("Hello");

            Assert.AreEqual("<i>Hello</i>", result);
        }

     

        [TestMethod]
        public void GetFormattedListElements_WithEmptyList_ShouldReturnEmptyUl()
        {
            var helper = new HtmlFormatHelper();
            var contents = new List<string>();

            var result = helper.GetFormattedListElements(contents);

            Assert.AreEqual("<ul></ul>", result);
        }
    }
}
