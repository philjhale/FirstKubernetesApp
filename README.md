# First Kubernetes App

A repository that will remind me how to create a .NET Core app, build a Docker image from it and deploy that image to Kubernetes.

## Prerequisites

All
 * .NET Core SDK 2.1

Mac
  
  * Download and install [Docker for Mac](https://docs.docker.com/docker-for-mac/install/)
  * Preferences -> Kubernetes -> Enable Kubernetes

Windows
 * You're on your own. Probably Docker and Minikube

## Steps

Build a docker image.

```docker build -t k8sfirstapp .```

Run the image. This maps port 80 in the container to 8080.

```docker run -p 8080:80 k8sfirstapp```

Check it works by viewing in the browser. [http://localhost:8080/api/random](http://localhost:8080/api/random) 

Create the Kubernetes [deployment](https://kubernetes.io/docs/concepts/workloads/controllers/deployment/).

```kubectl create -f deployment.yaml```

[Expose](https://kubernetes.io/docs/reference/generated/kubectl/kubectl-commands#expose) the app using a LoadBalancer [service](https://kubernetes.io/docs/concepts/services-networking/service/).

```kubectl create -f service.yaml```

The API should be accessible in the browser. Fingers crossed. [http://localhost:4000/api/random](http://localhost:4000/api/random) 