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
	}
}
