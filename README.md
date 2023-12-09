# Игра "Ходьба по карте"

 <p align="center">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
  <img alt="License" src="https://img.shields.io/github/license/RimuruDev/WalkingGame?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/RimuruDev/WalkingGame?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/RimuruDev/WalkingGame?logo=VirtualBox">
  </a>
  <a>
    <img alt="Downloads" src="https://img.shields.io/github/downloads/RimuruDev/WalkingGame/total?color=brightgreen">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/RimuruDev/WalkingGame?include_prereleases&logo=Dropbox&color=yellow">
  </a>
  <a>
    <img alt="GitHub stars" <a href="/AlexScience/walkingGame/stargazers" data-view-component="true" class="Link Link--muted">
      <svg aria-hidden="true" height="16" viewBox="0 0 16 16" version="1.1" width="16" data-view-component="true" class="octicon octicon-star mr-2">
    <path d="M8 .25a.75.75 0 0 1 .673.418l1.882 3.815 4.21.612a.75.75 0 0 1 .416 1.279l-3.046 2.97.719 4.192a.751.751 0 0 1-1.088.791L8 12.347l-3.766 1.98a.75.75 0 0 1-1.088-.79l.72-4.194L.818 6.374a.75.75 0 0 1 .416-1.28l4.21-.611L7.327.668A.75.75 0 0 1 8 .25Zm0 2.445L6.615 5.5a.75.75 0 0 1-.564.41l-3.097.45 2.24 2.184a.75.75 0 0 1 .216.664l-.528 3.084 2.769-1.456a.75.75 0 0 1 .698 0l2.77 1.456-.53-3.084a.75.75 0 0 1 .216-.664l2.24-2.183-3.096-.45a.75.75 0 0 1-.564-.41L8 2.694Z"></path>
</svg>
      <strong>1</strong>
      star
</a>
  <a>
    <img alt="GitHub user stars" src="https://img.shields.io/github/stars/RimuruDevaffiliations=OWNER&branch=main&label=User%20Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="" src="https://img.shields.io/github/watchers/RimuruDev/WalkingGame?style=flat">
  </a>
</p>

## Описание

Игра "Ходьба по карте" — это консольная игра, написанная на C# с использованием .NET 7. В игре участвуют несколько игроков, которые по очереди бросают кости и перемещаются по карте. Если игрок наступает на ловушку, он отступает назад, если нет — продвигается вперед. Цель игры — достичь конца карты. Побеждает игрок, который первым достигает финиша.

## Начало работы

Для запуска игры клонируйте репозиторий и выполните следующие команды:

```bash
dotnet restore
dotnet build
dotnet run
```
## Правила игры
- Каждый игрок по очереди бросает кости, чтобы определить количество шагов.
- Шаги игрока могут быть от 1 до 6.
- На карте расположены ловушки. При попадании в ловушку игрок отступает на определенное количество шагов.
- Побеждает игрок, который первым достигнет конца карты размером 50 клеток.

## Настройка игры
Игра предоставляет возможность настройки через класс GameSettings, где вы можете задать:

- Количество игроков (PlayersCount).
- Размер карты (MaxMapSize).
- Количество ловушек (TrapsCount).
- Диапазон штрафных шагов (PunishmentRange).
- Диапазон шагов игрока (PlayerStepsRange).

## Структура проекта
- Bootstrapper: Точка входа в игру, инициализирует настройки и запускает игру.
- Game: Основной класс игры, управляет игровым процессом.
- Player: Класс, представляющий игрока, его позицию и движение по карте.
- Trap: Класс, представляющий ловушку на карте.
- GameSettings: Класс настроек игры, используется для конфигурации параметров игры.
- Vector2Int: Вспомогательный класс для работы с парой целых чисел.

## Контрибьюторы
- [RimuruDev](https://github.com/RimuruDev) - Рефакторинг и улучшение игры.
- [AlexScience](https://github.com/AlexScience) - Оригинальная концепция и разработка игры.
