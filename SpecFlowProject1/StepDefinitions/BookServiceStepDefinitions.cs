using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class BookServiceStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly BookService _bookService = new BookService();
        private Book? _foundbook;
        public BookServiceStepDefinitions(ScenarioContext scenarioContext) {
            _scenarioContext = scenarioContext;
        }
        [Given("there is a book called (.*)")]
        public void GivenThereIsABookCalled(string bookname)
        {
            var book = new Book(bookname);
            _bookService.AddBook(book);
        }
        [When("I search for a book called (.*)")]
        public void WhenISearchForABookCalled(string bookname)
        {
            var result = _bookService.GetBook(bookname);
            _foundbook = result;
        }
        [Then("the name of the book returned should be (.*)")]
        public void ThenTheNameOfTheBookShouldBe(string bookname)
        {
            _foundbook?.Name.Should().Be(bookname);
        }
    }
}
