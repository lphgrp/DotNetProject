pipeline {
	agent any
	
	stages {
		stage ("--Code_Scan---") {
			steps {
			      withSonarQubeEnv('Sonar_Server') {
				  bat "D:\\InstallSoft\\SonarScanner.MSBuild.exe begin /k:Calculator /n:Calculator /d:sonar.verbose=true"
				  bat "MSBuild.exe /p:Configuration=Debug /p:Platform=\"Any CPU\" /t:Rebuild"
				  bat "D:\\InstallSoft\\SonarScanner.MSBuild.exe end"
				  }
			}
		}
		
	}
}