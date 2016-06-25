$testProjectLocations = @('test/UnitTests', 'test/UnitTests.Streams')
$outputLocation = 'testResults'
iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/StephenCleary/BuildTools/f312df7d0ea343b7b867c8f44d8e4df52bb77d1a/Coverage.ps1'))
