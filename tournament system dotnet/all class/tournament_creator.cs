using System;
using System.Collections.Generic;
using System.Text;

namespace tournament_system_dotnet.all_class
{
    public static class tournament_creator
    {
        public static tournamentClass createRounds(tournamentClass model)
        {
            List<teamClass> teamsof_turnament = model.enteredTeams;// list of the teams participent
            int rounds = FindNumberOfRournd(model.enteredTeams.Count);// get totall number of rounds in tournament
            int pass = findNumberofPass(rounds, model.enteredTeams.Count);//every match is played between two teams so if round is n then the total rounds will be (2^n) so here we will find the numbers of player who will not play ion fast round
            model.AllRounds.Add( CreateFirstRound(pass, model.enteredTeams));// enter the fast rounts mact list int tournament allrounds first index 
            model = CreateRestOfRound(model, rounds);
            return model;
        }
        //private static List<matchClass>CreateFirstRound()
        //create matchs from second round
        private static tournamentClass CreateRestOfRound(tournamentClass model, int rounds)//from secend round to last
        {
            tournamentClass tournamenta = new tournamentClass();
            int round = 2;
            List<matchClass> previousRound = new List<matchClass>();//lisst of matchs in previous round
            previousRound= model.AllRounds[0];//
            List<matchClass> currentRound = new List<matchClass>();
            matchClass currentmatch = new matchClass();
            while(round<= rounds)//run untill all the the rounds are finished
            {
                foreach (matchClass match in previousRound)
                {
                    currentmatch.matchPArticipentTeams.Add(new matchParticipentTeamClass { parantMatch = match });
                    if (currentmatch.matchPArticipentTeams.Count > 1)
                    {
                        currentmatch.matchRound = round;
                        currentRound.Add(currentmatch);
                        currentmatch = new matchClass();
                    }
                }
                
                model.AllRounds.Add(currentRound);
                previousRound = currentRound;
                currentRound = new List<matchClass>();
                round += 1;
            }
            tournamenta = model;

            return tournamenta;
        }
        // fast round match create
        private static List<matchClass> CreateFirstRound(int pass, List<teamClass> teams)
        {
            // mactch class contens the list of teams that playeed that round
            List<matchClass> output = new List<matchClass>();// list of match (particepent list) or the match list of first round
            matchClass current = new matchClass();
            foreach(teamClass team in teams)
            {  //team adding to current mactClass object
                current.matchPArticipentTeams.Add(new matchParticipentTeamClass { matchParticipentTeam = team });/////////////////////
                if (pass > 0 || current.matchPArticipentTeams.Count > 1)// if there is any pass or any teams left in list
                {
                    current.matchRound = 1;
                    output.Add(current);
                    current = new matchClass();// clear empty object
                    if (pass > 0)
                    {
                        pass -= 1;
                    }
                }
            }
            return output;
        }
          
        public static int findNumberofPass(int rounds,int numberofTeams)
        {
            int output = 0;
            int totalteams = 1;
            for(int i = 1; i <= rounds; i++)
            {
                totalteams = totalteams * 2;
            }
            output = totalteams - numberofTeams;
            return output;
        }
        public static int FindNumberOfRournd(int numberofteam)
        {
            int output = 1;
            int val = 2;
            while(val< numberofteam)
            {
                output += 1;

                val = val * 2;
            }
            return output;
        }

    }
}
