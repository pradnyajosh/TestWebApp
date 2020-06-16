pipeline {
  environment {
    registry = "pradnyajosh/docker-test"
    registryCredential = 'dockerhub'
    dockerImage = ''
	containerid=''
  }
  agent any
  stages {
    stage('Cloning Git') {
      steps {
        git 'https://github.com/pradnyajosh/TestWebApp.git'
      }
    }
    stage('Building image') {
      steps{
        script {
          dockerImage = docker.build registry + ":$BUILD_NUMBER"
        }
      }
    }
    stage('Deploy Image') {
      steps{
        script {
          docker.withRegistry( '', registryCredential ) {
            dockerImage.push()
          }
        }
      }
    }
    stage('Remove Unused docker image') {
      steps{
        bat "docker rmi $registry:$BUILD_NUMBER"
      }
    }
    
   }
}
