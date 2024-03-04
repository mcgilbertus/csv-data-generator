using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataGenerator.Tests
{
	[TestClass]
	public class ColumnTypeTests
	{

		/*
		[TestMethod]
		public void StringColumn_ValidArgs_Construct()
		{
			var columnName = "test1";
			var maxValue = "A";
			var minValue = "zzzzz";
			var format = "";
			var stringColumn = new ColumnType(columnName, "string", format, minValue, maxValue);
			Assert.IsNotNull(stringColumn);
			Assert.AreEqual(columnName, stringColumn.Name);
			Assert.AreEqual(ColumnDataType.String, stringColumn.DataType);
			Assert.AreEqual(0, stringColumn.Range);
		}
		
		[TestMethod]
		public void ColumnType_InvalidType_ThrowsException()
		{
			var columnName = "test1";
			var maxValue = "A";
			var minValue = "zzzzz";
			var format = "";
			Assert.ThrowsException<NotSupportedException>(() => new ColumnType(columnName, "string2", format, minValue, maxValue));
		}
		
		[TestMethod]
		public void IntColumn_ValidPositiveArgs_Construct()
        {
			var columnName = "test1";
			var maxValue = "101";
			var minValue = "1";
			var format = "";
			var intColumn = new ColumnType(columnName, "int", format, minValue, maxValue);
			Assert.IsNotNull(intColumn);
			Assert.AreEqual(columnName, intColumn.Name);
			Assert.AreEqual(ColumnDataType.Integer, intColumn.DataType);
			Assert.AreEqual(100, intColumn.Range);
			Assert.AreEqual(false, intColumn.Negative);
			Assert.AreEqual(1, intColumn.NegativeMin);
        }

		[TestMethod]
		public void IntColumn_ValidNegativeMinArg_Construct()
		{
			var columnName = "test1";
			var maxValue = "15";
			var minValue = "-15";
			var format = "";
			var intColumn = new ColumnType(columnName, "int", format, minValue, maxValue);
			Assert.IsNotNull(intColumn);
			Assert.AreEqual(columnName, intColumn.Name);
			Assert.AreEqual(ColumnDataType.Integer, intColumn.DataType);
			Assert.AreEqual(30, intColumn.Range);
			Assert.AreEqual(true, intColumn.Negative);
			Assert.AreEqual(-15, intColumn.NegativeMin);
		}

		[TestMethod]
		public void IntColumn_ValidNegativeBothArgs_Construct()
		{
			var columnName = "test1";
			var maxValue = "-15";
			var minValue = "-150";
			var format = "";
			var intColumn = new ColumnType(columnName, "int", format, minValue, maxValue);
			Assert.IsNotNull(intColumn);
			Assert.AreEqual(columnName, intColumn.Name);
			Assert.AreEqual(ColumnDataType.Integer, intColumn.DataType);
			Assert.AreEqual(135, intColumn.Range);
			Assert.AreEqual(true, intColumn.Negative);
			Assert.AreEqual(-150, intColumn.NegativeMin);
		}
		*/
	}
}
