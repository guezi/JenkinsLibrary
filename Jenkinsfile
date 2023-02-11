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
           stage('Docker') {
            steps {
                
               dotnetBuild configuration: 'Release', project: 'JenkinsLibrary.sln'
               dotnetPublish project: 'JenkinsLibrary.sln', selfContained: false, workDirectory: 'deploy'
            }
        }
    }
}
