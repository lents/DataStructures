// Create a HashSet of integers
// Simulated data: user IDs and their friend connections
Dictionary<int, HashSet<int>> userConnections = new Dictionary<int, HashSet<int>>
        {
            { 1, new HashSet<int> { 2, 3, 4 } },
            { 2, new HashSet<int> { 1, 3 } },
            { 3, new HashSet<int> { 1, 2, 4 } },
            { 4, new HashSet<int> { 1, 3 } }
        };

// Simulated user requesting friend recommendations
int userId = 1;

// Get the user's friends
HashSet<int> userFriends = userConnections[userId];

// Find friends of friends (excluding the user's direct friends)
HashSet<int> friendRecommendations = new HashSet<int>();
foreach (int friendId in userFriends)
{
    HashSet<int> friendsOfFriend = userConnections[friendId];
    foreach (int friendOfFriendId in friendsOfFriend)
    {
        if (friendOfFriendId != userId && !userFriends.Contains(friendOfFriendId))
        {
            friendRecommendations.Add(friendOfFriendId);
        }
    }
}

// Print friend recommendations
Console.WriteLine($"Friend recommendations for user {userId}:");
foreach (int recommendationId in friendRecommendations)
{
    Console.WriteLine($"- User {recommendationId}");
}