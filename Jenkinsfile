pipeline {
    agent { label 'builder' }
    environment {
        VERSION_NUMBER = '0.6.0'
        IMAGE_VERSION = "${GIT_BRANCH == "main" ? VERSION_NUMBER : VERSION_NUMBER+"-"+GIT_BRANCH}"
        DOCKER_HUB = credentials("dockerhub-creds")
    }
    stages {
        stage('build and publish') { 
            steps { script { sh  """
                #!/bin/bash
                docker build -t nschultz/fantasy-baseball-common:${IMAGE_VERSION} .
                docker login -u ${DOCKER_HUB_USR} -p ${DOCKER_HUB_PSW}
                docker push nschultz/fantasy-baseball-common:${IMAGE_VERSION}
                docker logout
            """ } } 
        }
    }
}