pipeline {
    agent any

    stages {
        stage ('Clean workspace') {
  steps {
    cleanWs()
  }
}
        
        stage ('Git Checkout') {
  steps {
      git branch: 'master', credentialsId: 'Jenkins', url: 'https://github.com/guezi/JenkinsLibrary'
    }
  }
        stage('Restore packages') {
                   steps {
                           dotnetRestore project: 'JenkinsLibrary.sln'
                         }
                   }
        stage('Clean') {
                      steps {
                        dotnetClean configuration: 'Release', project: 'JenkinsLibrary.sln'
                      }
                    }

           stage('Build') {
                    steps {
                       
                       dotnetBuild configuration: 'Release', project: 'JenkinsLibrary.sln' 
                      
                    }
        }
            stage('test') {
                    steps {
                       bat returnStatus: true, script: "\"C:/Program Files/dotnet/dotnet.exe\" test \"JenkinsLibrary.sln\" --logger \"trx;LogFileName=result.xml\" "
                       //dotnetTest project: 'JenkinsLibrary.sln', resultsDirectory: 'FolderResult'       
                       //nunit testResultsPattern: 'JenkinsLibraryTest/TestResults/result.xml'
                    }
        }
        
         stage('Push') {
                    steps {
                       
                      dotnetPublish configuration: 'Release', project: 'JenkinsLibrary.sln', selfContained: false
                      dotnetPublish configuration: 'Release', outputDirectory: 'publish', project: 'JenkinsLibrary.sln', runtime: 'win-x64', selfContained: true, versionSuffix: '1.2.3'
                    }
        }
        
    }
}
