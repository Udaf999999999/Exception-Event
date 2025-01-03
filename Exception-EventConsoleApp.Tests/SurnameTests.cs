using System.Reflection;
using Xunit;

namespace Exception_EventConsoleApp
{
    public class SurnameTests
    {
        [Fact]
        public void ArgumentLessThenFive()
        {
            // Arrange
            string[] strings = { "Orlov", "Sidorov", "Dragunov" };


            // Act
            var exception = Assert.Throws<ArgumentException>(() => new SurnameSort(strings));

            // Assert
            Assert.Equal("String count must be five.", exception.Message);
        }
		[Fact]
		public void ArgumentMoreThenFive()
		{
			// Arrange
			string[] strings = { "Orlov", "Sidorov", "Dragunov", "Smirnov", "Gavrilov", "Zaicev" };


			// Act
			var exception = Assert.Throws<ArgumentException>(() => new SurnameSort(strings));

			// Assert
			Assert.Equal("String count must be five.", exception.Message);
		}
		[Fact]
		public void ArgumentNull()
		{
			// Arrange
			string[] strings = null;


			// Act
			var exception = Assert.Throws<ArgumentException>(() => new SurnameSort(strings));

			// Assert
			Assert.Equal("String count must be five.", exception.Message);
		}
		[Fact]
		public void ArgumentSurnameNull()
		{
			// Arrange
			string[] strings = { "Orlov", "Sidorov", "Dragunov", null, "Gavrilov" };


			// Act
			var exception = Assert.Throws<ArgumentException>(() => new SurnameSort(strings));

			// Assert
			Assert.Equal("Surname can't be empty!", exception.Message);
		}
		[Fact]
		public void ArgumentSurnameEmpty()
		{
			// Arrange
			string[] strings = { "Orlov", "Sidorov", "Dragunov", "", "Gavrilov" };


			// Act
			var exception = Assert.Throws<ArgumentException>(() => new SurnameSort(strings));

			// Assert
			Assert.Equal("Surname can't be empty!", exception.Message);
		}
		[Fact]
		public void ChooseSortWrongNumber()
		{
			// Arrange
			string[] strings = { "Orlov", "Sidorov", "Dragunov", "Smirnov", "Gavrilov" };
			SurnameSort surnameSort = new SurnameSort(strings);

			// Act
			var exception = Assert.Throws<WrongInputSortWayException>(() => surnameSort.Sort("3"));

			// Assert
			Assert.Equal("Value must be 1 or 2!", exception.Message);
		}
		[Fact]
		public void CurrectAscendSort()
		{
			// Arrange
			string[] strings = { "Orlov", "Sidorov", "Dragunov", "Smirnov", "Gavrilov" };
			SurnameSort surnameSort = new SurnameSort(strings);

			// Act
			surnameSort.Sort("1");

			// Assert
			Assert.Equal("Dragunov", surnameSort.surnames[0]);
			Assert.Equal("Gavrilov", surnameSort.surnames[1]);
			Assert.Equal("Orlov", surnameSort.surnames[2]);
			Assert.Equal("Sidorov", surnameSort.surnames[3]);
			Assert.Equal("Smirnov", surnameSort.surnames[4]);
		}
		[Fact]
		public void CurrectDescendSort()
		{
			// Arrange
			string[] strings = { "Orlov", "Sidorov", "Dragunov", "Smirnov", "Gavrilov" };
			SurnameSort surnameSort = new SurnameSort(strings);

			// Act
			surnameSort.Sort("2");

			// Assert

			Assert.Equal("Smirnov", surnameSort.surnames[0]);
			Assert.Equal("Sidorov", surnameSort.surnames[1]);
			Assert.Equal("Orlov", surnameSort.surnames[2]);
			Assert.Equal("Gavrilov", surnameSort.surnames[3]);
			Assert.Equal("Dragunov", surnameSort.surnames[4]);
		}
	}
}
