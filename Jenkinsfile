pipeline {
    agent any

    stages {
        stage('Hello new') {
            steps {
                echo 'Hello World'
                pwsh(script: 'Write-Output "Hello World"’)
            }
        }
    }
}
