$testProjectLocation = 'test/UnitTests'
$outputLocation = 'testResults'
iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/StephenCleary/BuildTools/ebe8a86fd87b5e924d23fd50bf5175bf91272f88/Coverage.ps1'))
