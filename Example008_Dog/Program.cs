int count = 0;
int distance = 1000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 1;
    }
    
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
}
Console.Write("Собака пробежала ");
Console.Write(count);
Console.Write(" раз");