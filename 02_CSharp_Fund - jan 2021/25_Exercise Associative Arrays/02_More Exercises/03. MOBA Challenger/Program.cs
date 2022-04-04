using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._MOBA_Chalanger
{    
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playerPool = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, string> playerPositions = new Dictionary<string, string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains(" -> "))
                {
                    string[] player = input.Split(" -> ");

                    string playerName = player[0];
                    string position = player[1];
                    int skill = int.Parse(player[2]);

                    if (!playerPool.ContainsKey(playerName))
                    {
                        playerPool[playerName] = new Dictionary<string, int>();
                    }

                    if (!playerPool[playerName].ContainsKey(position))
                    {
                        playerPool[playerName][position] = 0;

                        playerPositions[playerName] = position;
                    }

                    if (playerPool[playerName][position] < skill)
                    {
                        playerPool[playerName][position] = skill;
                    }
                }
                else if (input.Contains(" vs "))
                {
                    string[] duel = input.Split(" vs ");

                    string playerOne = duel[0];
                    string playerTwo = duel[1];

                    bool playersExist = playerPositions.ContainsKey(playerOne) && playerPositions.ContainsKey(playerTwo);

                    bool commanPosiotion = false;

                    if (playersExist)
                    {
                        foreach (var item in playerPositions[playerOne])
                        {
                            foreach (var position in playerPositions[playerTwo])
                            {
                                if (item == position)
                                {
                                    commanPosiotion = true;
                                    break;
                                }
                                if (commanPosiotion)
                                    break;
                            }
                        }
                    }

                    if (commanPosiotion)
                    {
                        if (playerPool[playerOne].Values.Sum() > playerPool[playerTwo].Values.Sum())
                        {
                            playerPool.Remove(playerTwo);

                            playerPositions.Remove(playerTwo);
                        }
                        else if (playerPool[playerOne].Values.Sum() < playerPool[playerTwo].Values.Sum())
                        {
                            playerPool.Remove(playerOne);

                            playerPositions.Remove(playerOne);
                        }
                    }
                }
            }

            foreach (var player in playerPool.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}