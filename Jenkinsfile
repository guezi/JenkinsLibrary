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
                pwsh(script: Write-Output "Hello World")
                powershell 'Write-Output "Hello World"'
               
            }
        }
    }
}
