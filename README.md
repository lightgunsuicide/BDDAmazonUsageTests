# BDDAmazonUsageTests
A demonstration of development and automated testing principles using the Amazon website

## Breakdown of Projects
The **Framework** project contains the page classes. These contain page objects, created with the factory object pattern from the PageObject factory object. 

The **BDDTests** project contains gherkin script files (**specflow** Feature files) and steps files with the code to run these tests. 

Specflow has been configured to use **xunit** to allow potential parallel running of tests. This is not a fundamental requirement but xunit and its running console were the best choices as they allow this functionality in the future. 

Since we are using a .net framework project rather than .netcore, in this project **ninject** was used to cover **dependency injection**. A directory called IoC (Inversion of Control) contains the classes that deal with binding to a container. This allows us to de-couple the implementation of page classes. In the case of this project this allows us, for example, to use several different classes to implement different homepages for amazon (such as for different regions or languages) and run the same tests. 

## Demonstrating Behaviour Driven Development and software engineering principles
Things I had hoped to demonstrate with this project:
* Ideal gherkin user/test case writing, with a minimum of sentences used to describe a large portion of functionality at the highest level at which it can be explained
* Factory object pattern for ease of implementing the page object pattern
* IoC and DI to de-couple hard implementations from this use in test cases

