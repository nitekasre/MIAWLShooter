using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    //an interface is being used to allow flexibility for multiple inheritance incase scores are used in another aspect of the game
    //eg: access to higher levels/boss fights when scope is expanded
    interface ScoreSheet
    {
        //method to get all the high scores from the collection
        ICollection<High_Scores> GetScores();

        //add user
        void AddUser(High_Scores obj);

        //will add new high scores
        void AddScore(int id, High_Scores playerchanges);
    }

    class ScoreRepository : ScoreSheet
    {
        //entity of the scores database
        ShooterGameEntities2 entities;

        //public constructor call for the databse since the class is internal
        public ScoreRepository()
        {
            entities = new ShooterGameEntities2();
        }
        public void AddUser(High_Scores obj)
        {
            //will add a new user to the game with the non-nullable items and save it to the database
            entities.High_Scores.Add(obj);
            entities.SaveChanges();
        }
        public void AddScore(int ID, High_Scores playerchanges)
        {
            //will update the player information and pass it to the table for display at the end of the game
            var updateplayer = entities.High_Scores.Find(ID);
            updateplayer.PlayerID = playerchanges.PlayerID;
            updateplayer.PlayerName = playerchanges.PlayerName;
            updateplayer.PlayerScore = playerchanges.PlayerScore;
            entities.SaveChanges();
        }

        public ICollection<High_Scores> GetScores()
        {
            //will pass the information from the database to the datagridview for the scores
            return entities.High_Scores.ToList();
        }
    }
}
