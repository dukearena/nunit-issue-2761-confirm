# nunit-issue-2761-confirm
This project should be used to replicate the NUnit issue 2761: https://github.com/nunit/nunit/issues/2761


# How to run
  - Open the solution file (NUnitHangIssue.sln)
  - Restore all the Nuget packages
  - Do a full build
  - Run the following command using nunit-console v3.8 (you can find it it the downloaded packages, under the folder `packages\NUnit.ConsoleRunner.3.8.0\tools`)


```sh
// DEBUG build
$ cd project_folder
$ nunit3-console.exe NUnitHangIssue.Tests\bin\Debug\NUnitHangIssue.Tests.dll --workers=8

// RELEASE build
$ cd project_folder
$ nunit3-console.exe NUnitHangIssue.Tests\bin\Release\NUnitHangIssue.Tests.dll --workers=8
```

The runner should execute 8 tests per time; everytime a worker executes a test contained in `LongRunningTearDownTests.cs`, after 5 second a ThreadAbortException is thrown by the TimeoutAttribute and the worker is turned off.
