# TOS RabbitMQ

Ce TOS a pour objectif d'expliquer le fonctionnement basique de RabbitMQ.

Nous allons donc mettre en place un conteneur docker basé sur l'image de RabbitMQ et vérifier son bon fonctionnement.

Récupérer l'image RabbitMQ depuis DockerHub.

```bash
docker pull rabbitmq:management
```

> Le tag :management permet d'obtenir l'image docker qui permet de lancer le conteneur et d'avoir une interface graphique.

Créer le conteneur docker.

```bash
docker run -d -p 5672:5672 -p 15672:15672 --hostname rabbit-mq-tos --name rabbit-mq-container -e RABBITMQ_DEFAULT_USER=user -e RABBITMQ_DEFAULT_PASS=password rabbitmq:management
```

Une fois le conteneur créé, nous avons accès à l'interface RabbitMQ à l'adresse : `http://localhost:15672/`

![Alt text](./screenshots/rabbitmq.png)
