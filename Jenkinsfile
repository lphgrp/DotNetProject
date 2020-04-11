pipeline {
	agent any
	environment {
        def sqScannerMsBuildHome = tool 'Sonar_Analysis'
    }
	stages {
		stage ("--Code_Scan---") {
			steps {
			      withSonarQubeEnv('Sonar_Server') {
				  bat "D:\\InstallSoft\\SonarScanner.MSBuild.exe begin /k:Calculator /n:Calculator /d:sonar.verbose=true"
				  }
			}
		}
		stage ("--Clean Project and Build---") {
			steps {
				bat "MSBuild.exe /p:Configuration=Debug /p:Platform=\"Any CPU\" /t:Rebuild"
				}
		}
	}
}