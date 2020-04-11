pipeline {
	agent any
	environment {
        def sqScannerMsBuildHome = tool 'Sonar_Analysis'
    }
	stages {
		stage ("--Code_Scan---") {
			steps {
			      withSonarQubeEnv('Sonar_Server') {
				  bat "D:\\InstallSoft\\SonarQube.Scanner.MSBuild.exe begin /k:"Calculator" /n:"Calculator" /v:"1.0"
				  }
			}
		}
		stage ("--Clean Project and Build---") {
			steps {
				bat "MSBuild.exe /t:Rebuild"
			}
		}
	}
}