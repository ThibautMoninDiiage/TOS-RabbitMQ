# TOS RabbitMQ

Ce TOS a pour objectif d'expliquer le fonctionnement basique de RabbitMQ.

Nous allons donc mettre en place un conteneur docker basé sur l'image de RabbitMQ et vérifier son bon fonctionnement.

Commande pour récupérer l'image RabbitMQ depuis DockerHub.

```bash
docker pull rabbitmq:management
```

> Le tag :management permet d'obtenir l'image docker qui permet de lancer le conteneur et d'avoir une interface graphique.

Commande pour créer le conteneur docker.

```bash
docker run -d -p 5672:5672 -p 15672:15672 --hostname rabbit-mq-tos --name rabbit-mq-container -e RABBITMQ_DEFAULT_USER=user -e RABBITMQ_DEFAULT_PASS=password rabbitmq:management
```

Une fois le conteneur créé, nous avons accès à l'interface RabbitMQ à l'adresse : `http://localhost:15672/`

![Alt text](./screenshots/rabbitmq.png)

Renseignez vos identifiants et accédez au dashboard.

Nous allons ensuite créer 2 applications console .NET afin de tester le serveur RabbitMQ.

![Alt text](./screenshots/dependencies.png)

Ici, j'ai créé 1 solution avec 2 projets console à l'intérieur, un publisher et un subscriber. J'ai également ajouté le package `RabbitMQ.Client` dans chacun des projets.

Vous pouvez ajouter le package grâce à la commande suivante : 
```bash
dotnet add package RabbitMQ.Client --version 6.6.0-beta.0
```
