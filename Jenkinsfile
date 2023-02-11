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
      git branch: 'master', credentialsId: 'jenkins', url: 'https://github.com/guezi/JenkinsLibrary'
    }
  }
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
