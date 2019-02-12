# unitTests-Setup-Comparison
This Project compares different ways of test initialization and cleanup used by xUnit/nUnit/MsTest/SpecFlow.
There's an example project set up for each framework with examples of all the initialization techniques.
Each Init() method uses the same dummy logic that prints info, when it's called and waits a second to simulate a long initialization.
Each Cleanup() method prints info to show how many times it was called (this one doesn"t wait additionally).

The project shows the gains of minimizing the repetition of test initialization.

By default, the test output goes to the stdout. To make it simpler to debug with visual studio, you can turn on the option "Redirect all Output Test to the Immediate Window".
After starting each project, you can see how each structure affects the number of times the Init() method was called.
