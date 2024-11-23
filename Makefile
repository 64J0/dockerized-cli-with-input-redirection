build-container:
	docker build -t add-cli:v1 --file Dockerfile.cli --target runtime .

build-container-chiseled:
	docker build -t add-cli:v1-chiseled --file Dockerfile.cli --target runtime-chiseled .

run: build-container
	docker container run -i add-cli:v1 < ./samples/example1.txt
	cat ./samples/example1.txt | docker container run -i add-cli:v1

run-chiseled: build-container-chiseled
	docker container run -i add-cli:v1-chiseled < ./samples/example1.txt
	cat ./samples/example1.txt | docker container run -i add-cli:v1-chiseled
