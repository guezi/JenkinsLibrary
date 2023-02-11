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
                
               dotnetTest configuration: 'Release', project: 'JenkinsLibrary.sln', resultsDirectory: 'test'
            }
        }
        
       
    }
}
