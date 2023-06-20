# Vending_machine

Приложение иммитирующее работу вендингового аппарата с напитками.

Приложение предназначено для демонстрации моих навыков перед потенциальным работодателем.

Демо приложение состоит технически из бэка на dotnet7 и фронта на angular, работает с БД на postgres.

По окончании MVP версии приложения планируется адаптация приложения под запуск в докере
одной командой docker-compose up или запуском говотого образа.

Приложение содержит 2 странички:
1. Страница пользователя
2. Страница администратора

На страничке пользователя покупатель может внести монеты кликая по соответствующим кнопкам, 
увидеть сумму внесённых им монет, выбрать товары для покупки и запросить сдачу. 
Автомат должен выдать товар и сдачу разными монетами исходя из того, какие есть в наличии.

На страничке администратора можно посмотреть баланс автомата,
остаток напитков, внести изменения, добавить типы продуктов или изменить их остаток.
А так же посмотреть список операций.

Демо приложение находится в процессе разработки в режиме "свободного художника",
поэтому функционал может дополняться или изменяться.

Тестовое задание
https://disk.yandex.ru/i/OLZe4NyxZSdEyw