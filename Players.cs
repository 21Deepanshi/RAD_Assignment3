using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Assignment
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public double Rating { get; set; }
        public double Assists { get; set; }
        public string Position { get; set; }
        public double PointsPerGame { get; set; }
        public string Photo { get; set; }
    }
    internal class Players
    {
        public List<Player> player { get; set; }

        public Players()
        {
            player = new List<Player>();
            playerData();
        }

        public void playerData()
        {
            player.Add(new Player
            {
                Name = "LeBron James",
                Team = "Lakers",
                Rating = 94.5,
                Assists = 7,
                Position = "Small Forward",
                PointsPerGame = 25.0,
                Photo = "https://images.hdqwalls.com/wallpapers/lebron-james-2020-bj.jpg"
            });

            player.Add(new Player
            {
                Name = "Stephen Curry",
                Team = "Warriors",
                Rating = 85.0,
                Assists = 6,
                Position = "Point Guard",
                PointsPerGame = 30.1,
                Photo = "https://www.investopedia.com/thmb/T1dEXpSMZQ_QEf3yabnz1u80BMc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/GettyImages-1795186767-94867a77abd7454dac19f032c053c541.jpg"
            });

            player.Add(new Player
            {
                Name = "Giannis Antetokounmpo",
                Team = "Bucks",
                Rating = 74.3,
                Assists = 5,
                Position = "Power Forward",
                PointsPerGame = 29.0,
                Photo = "https://greekreporter.com/wp-content/uploads/2021/04/1920px-Giannis_Antetokounmpo_24845003687.jpg"
            });

            player.Add(new Player
            {
                Name = "Kevin Durant",
                Team = "Suns",
                Rating = 74.7,
                Assists = 5,
                Position = "Small Forward",
                PointsPerGame = 27.5,
                Photo = "https://icdn.football-espana.net/wp-content/uploads/2021/06/Kevin-Durant.jpg"
            });

            player.Add(new Player
            {
                Name = "Kawhi Leonard",
                Team = "Clippers",
                Rating = 94.2,
                Assists = 5,
                Position = "Small Forward",
                PointsPerGame = 26.0,
                Photo = "https://www.680news.com/wp-content/blogs.dir/sites/2/2018/09/Kawhi-Leonard.jpg"
            });

            player.Add(new Player
            {
                Name = "Joel Embiid",
                Team = "76ers",
                Rating = 94.1,
                Assists = 4,
                Position = "Center",
                PointsPerGame = 33.1,
                Photo = "https://www.inquirer.com/resizer/_EsRtDCgxjuWdZ156-BtpW2pUCQ=/1400x932/smart/cloudfront-us-east-1.images.arcpublishing.com/pmn/OGXQBYM36RFZXDQLRAEWDWLWSA.jpg"
            });

            player.Add(new Player
            {
                Name = "Nikola Jokic",
                Team = "Nuggets",
                Rating = 84.0,
                Assists = 8,
                Position = "Center",
                PointsPerGame = 26.0,
                Photo = "https://cdn.vanguardngr.com/wp-content/uploads/2019/08/Nikola-Jokic.jpg"
            });

            player.Add(new Player
            {
                Name = "Jimmy Butler",
                Team = "Heat",
                Rating = 95.0,
                Assists = 6,
                Position = "Small Forward",
                PointsPerGame = 22.0,
                Photo = "https://cdn.nba.com/manage/2023/11/jimmy-butler-pregame-iso.jpg"
            });

            player.Add(new Player
            {
                Name = "Luka Dončić",
                Team = "Mavericks",
                Rating = 93.8,
                Assists = 9,
                Position = "Point Guard",
                PointsPerGame = 28.4,
                Photo = "https://a2.espncdn.com/combiner/i?img=%2Fphoto%2F2021%2F0423%2Fr844375_1296x729_16-9.jpg"
            });

            player.Add(new Player
            {
                Name = "Trae Young",
                Team = "Hawks",
                Rating = 53.2,
                Assists = 9,
                Position = "Point Guard",
                PointsPerGame = 27.0,
                Photo = "https://media.gq.com/photos/60be118c528a70dcee268de0/16:9/w_2560%2Cc_limit/1322174015"
            });
        }
    }
}
