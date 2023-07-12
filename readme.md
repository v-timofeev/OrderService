# OrderService
## Требования
- [net6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
## Запуск
1. Склонируйте репозиторий
   ```
   git clone https://github.com/v-timofeev/OrderService.git
   ```
2. Перейдите в директорию с проектом
   ```
   cd ./OrderService/OrderService.Api/
   ```
3. Восстановите зависимости
   ```
   dotnet restore
   ```
4. Запустите приложение
   ```
   dotnet run 
   ```
5. Откройте в браузере [Swagger UI](http://localhost:5173/swagger/index.html)
   ```
   http://localhost:5173/swagger/index.html
   ```
## Постановка задачи
> Разработать Web API (на базе .NET Core) для приема заказов на доставку со следующим фукционалом:
> - api метод создания заказа: guid CreateOrder(Order order)
> - api метод для просмотра заказа по номеру (guid)
> - api метод для просмотра всех созданных заказов
>
> Заказ (Order) должен содержать адрес / фио отправителя, адрес / фио получателя, вес груза, 
> помимо этих полей для заказа должен генерировать автоматически сгенерированный номер заказа (guid) и текущая дата 
>
> Хранилище заказов может быть любым (напр. текстовый файл, in memory и т.п.)