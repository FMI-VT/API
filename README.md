# Изграждане на API

## Задание за курсов проект
<br>
Да се разработи софтуер за обработване на изображения. Разработката на проекта протичва в две фази:

- Фаза 1: Изграждане на споделена библиотека, която да предоставя основните функционалности при обработването на изображенията. Тип на проекта (във Visual Studio): Class Library
- Фаза 2: Разработване на допълнителни приложения, които консумират споделената библиотека от Фаза 1. Самите приложения, не трябва да съдържат код за обработване на изображения. Тип на проекта (във Visual Studio): ASP.NET Web Application (за предпочитане), Console Application, Windows Application (по желание)

## Задание за Фаза 1
<br>
Споделената библиотека трябва да предоставя функционалности за следните операции с изображения:

- Конвертиране на изображения 
- Преоразмеряване на изображения

### Изисквания към програмния код

- Библиотеката трябва да реализира два публични метода **Convert** (за конвертиране) и **Resize** (за проразмеряване)
- Останалата част от програмния код не трябва да бъде видима за консуматора (консуматорите)
- Входни параметри за метод **Convert**:
    - sourceFile - път до оригиналното изображение
    - destinationFile - път до резултата (конвертираното изображение)
    - type - тип на конвертираното изображение. Поддържани формати: GIF, PNG и JP(E)G. Да се планира възможност за добавяне на нови формати
- Входни параметри за метод **Resize**:
    - sourceFile - път до оригиналното изображение
    - destinationFile - път до резултата (преоразмереното изображение)
    - type - стратегия за преоразмеряване. Поддържани стратегии: Skew (грешката в името е умишлена) - преоразмеряване до зададени размери без допълнителни ограничения; KeepAspect - преоразмеряване до зададени размери, чрез запазване на пропорциите; Crop - преоразмеряване до зададени размери, чрез изрязване на част от оригиналното изображение
    - width - широчина на преоразмереното изображение в пиксели
    - height - височина на преоразмереното изображение в пиксели
    - startX - X координата на началната точка за изрязване (само за стратегия Crop)
    - startY - Y координата на началната точка за изрязване (само за стратегия Crop)
- Обработка на грешки и валидация 
    - За валидиране на входните данни използвайте подходящо подбрани стратегии за валидиране
    - За обработка на грешките трябва да имплементирате собствени изключения
    - Няма ограничения във вида и метода за валидиране и обработване на грешките

### Допълнителни указания
- За резлизиране на програмния код трябва да използвате C#
- За реализиране на програмния код може да използвате следните шаблони за дизайн:
    - Strategy
    - Dependency Injrection
    - Factory
    - и/или други, които смятате за подходящи
- Резултата от изпълнението на проекта трябва да бъде compiled assembly, т.е. - .dll файл
- Няма допълнителни ограничения и/или изисквания към програмния код, освен гореописаните

## Задание за фаза 2
<br>
При реализиране на приложенията, които използват споделената библиотека (консуматори) трябва да:

- не имплементирате програмен код, който касае обработване на изображения
- имплементирате адекватни стратегии за обработване на грешките по време на изпълнение
- спазвате приоритета за имплементиране на консуматорите (ако е възможно), както следва:
    - Web Application
    - Windows Application
    - Console Application

<br>
<br>
**Важно** 
<br>Няма конкретни ограничения и/или изисквания към консуматорите

