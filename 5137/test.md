# Инструкция по работе с Git

### Основные команды для использования Git это:
**git commit**, **git add**, **git log**,**git status** и другие,разберем вышеуказанные

## **git commit**
Используется для создания коммитов(сохранений)

## **git add**
Используется для отслеживания файла.Например:
для последующего сохранения/коммита

## **git log**
Это команда показывает все ваши комиты/сохранения.Грубо говоря это журнал сохранений

## **git status**
Данная команда отображает текущий статус.Например: отлеживается файл или нет,сохранен ли файл и т.п.

# Работа с ветками

## Для работы с ветками используются команды:
### __git branch__,__git chekout__,__git merge__ и другие,но эти две основные.

# Разберем их:

## __git branch__:
### С помощью __git branch__ можно создавать,удалять,просматривать ветки,а также совершать и другие действия.

## __git chekout__:
### А с помощью __git chekout__ можно переходить на эти же ветки.

## __git merge__
### Служит для слияния веток

## Итак размотрим примеры:

## Это строка будет этображатся на всех ветках
А остальные лишь на своих ветках

## Здесь будет картинка

![Это картинка на ветке мастер](picture.jpg)

# Работа с удаленными репозиториями

## Для работы с удаленными репозиториями необходимо

* ### Зарегестрироваться/войти в GitHub 

* ### Создать репозиторий

* ### Воспользоватся командами которые GitHub дает внизу,а именно:

* ### **git remote add origin "URL-адрес вашего/другого человека репозитория".В некоторых случаях придется "подружить" ваш локальный репозиторий с удаленным,это значит что вам придется доказать что это и что репозиторий ваш

* ### Далее вводим команду **git branch -M main**-это создаст ветку _main_ и сразу перекинет вас на нее

* ### Далее используя команду **git push -u origin main** вы как бы "толкаете" свой проект в удаленный репозиторий

* ### И все,далее вы можете работать с другими удаленными репозиториями и т.п.
