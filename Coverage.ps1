$testProjectLocations = @('test/UnitTests', 'test/UnitTests.Streams')
$outputLocation = 'testResults'
iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/StephenCleary/BuildTools/86755979d99fed10421697f89317348ebec8edf4/Coverage.ps1'))
