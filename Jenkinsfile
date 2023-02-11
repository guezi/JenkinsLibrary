pipeline {
    agent any

    stages {
        stage('Hello new') {
            steps {
                echo 'Hello World'
                echo "$GIT_BRANCH"
                powershell 'Write-Output "Hello World"'
               
            }
        }
           stage('Build') {
            steps {
                
               dotnetBuild configuration: 'Release', project: 'JenkinsLibrary.sln'
               
            }
        }
         stage('Deploy') {
            steps {               
                
               dotnetPublish project: 'JenkinsLibrary\JenkinsLibrary.csproj', selfContained: false, workDirectory: 'deploy'
            }
        }
    }
}
