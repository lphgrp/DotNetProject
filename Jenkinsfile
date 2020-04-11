pipeline {
	agent any
	environment {
        def sqScannerMsBuildHome = tool 'MSbuild_Proj'
    }
	stages {
		stage ("--Code_Scan---") {
			steps {
			      withSonarQubeEnv('Sonar_Server') {
				  bat "D:\\InstallSoft\\SonarScanner.MSBuild.exe begin /k:Calculator /n:Calculator /v:1.0 /d:sonar.verbose=true"
				  bat 'C:/\"Program Files (x86)\"/MSBuild/14.0/Bin/MSBuild.exe /p:Configuration=Debug /p:Platform=\"Any CPU\" /t:Rebuild'
				  bat "D:\\InstallSoft\\SonarScanner.MSBuild.exe end"
				  }
			}
		}
		stage ("--Deploy---") {
			steps {
			       bat "copy D:\\InstallSoft\\Jenkins\\workspace\\DotNetPipeline\\Calculator\\bin\\Debug\\Calculator.exe D:\\"
				  }
			}
		}
	}

