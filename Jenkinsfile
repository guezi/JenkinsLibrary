pipeline {
    agent any

    stages {
        stage('Hello new') {
            steps {
                echo 'Hello World'
                echo "$GIT_BRANCH"
                pwsh(script: 'Write-Output "Hello World"')
            }
        }
    }
}
