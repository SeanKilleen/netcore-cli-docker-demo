# netcore-cli-docker-demo

A quick demo to show how to build a console app that runs in a docker container.

## Pre-requisites

* Docker
* If running on Windows, ensure docker is using Linux containers.

## How do I build the container image?

* `cd` into the repository's root directory
* Run `docker build . --tag "mycontainer:0.1"`.

This will create an image using the `DOCKERFILE` in this base folder. The image will be called `mycontainer` and give it a tag of `0.1`.

## How do I start the container image?

First, you need to create the container image by doing the following.

* Run `docker image list`. The `mycontainer` container should be listed.