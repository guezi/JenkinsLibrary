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
                
                mkdir deploy
               dotnetPublish project: 'JenkinsLibrary.sln', selfContained: false, workDirectory: 'deploy'
            }
        }
    }
}
