Console.Clear();

int distance = 10000,
firstFriendSpeed = 1,
secondFriendSpeed = 2,
dogSpeed = 5,
friend = 2,
count = 0,
time = 0;

while(distance > 5)
{   
    if(friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed); // Высчитываем время, за которое собака пробежит расстояние от второго друга к первому
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed); // Вычисляем время, за которое собака пробежит расстояние от первого друга ко второму
        friend = 1;
    }

    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time; // Вычисляем расстояние, пройденное обоими друзьями за время, пока собака пробежала от 2 к 1, и от 1 ко 2 обратно

    count += 1; // Счетчик количества перебежек собаки от одного друга ко второму
}

Console.WriteLine("Собака перебежит от одного друга к другому " + count + " раз");