using NUnit.Framework;

namespace VietnamNumber.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-55, "âm năm mươi lăm")]
        [TestCase(-1055, "âm một nghìn không trăm năm mươi lăm")]
        [TestCase(101002101000000000, "một trăm lẻ một triệu tỷ không trăm lẻ hai nghìn tỷ một trăm lẻ một tỷ")]
        [TestCase(100000000000, "một trăm tỷ")]
        [TestCase(1000000000000, "một nghìn tỷ")]
        [TestCase(1000000000000000, "một triệu tỷ")]
        [TestCase(1000000000000000000, "một tỷ tỷ")]
        [TestCase(1000000234000000000, "một tỷ tỷ hai trăm ba mươi tư tỷ")]
        [TestCase(1000000000222000000, "một tỷ tỷ hai trăm hai mươi hai triệu")]
        [TestCase(1009, "một nghìn không trăm lẻ chín")]
        [TestCase(9, "chín")]
        [TestCase(90, "chín mươi")]
        [TestCase(900, "chín trăm")]
        [TestCase(1000000, "một triệu")]
        [TestCase(1090000, "một triệu không trăm chín mươi nghìn")]
        [TestCase(1090010, "một triệu không trăm chín mươi nghìn không trăm mười")]
        [TestCase(1000010, "một triệu không trăm mười")]
        [TestCase(10, "mười")]
        [TestCase(100, "một trăm")]
        [TestCase(55, "năm mươi lăm")]
        [TestCase(20000, "hai mươi nghìn")]
        [TestCase(2000000, "hai triệu")]
        public void RunTestNormal(long num, string expected)
        {
            string result = num.ToVietnameseWords();
            Assert.AreEqual(result, expected);
        }

        [TestCase("0859132721", "không tám năm chín một ba hai bảy hai một")]
        public void RunTestSingle(string num, string expected)
        {
            string result = num.ToVietnameseSingleWords();
            Assert.AreEqual(result, expected);
        }
    }
}