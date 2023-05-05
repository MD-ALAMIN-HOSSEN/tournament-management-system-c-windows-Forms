using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace tournament_system_dotnet.all_class

{   
    public  class sqlConnectionClass
    {
        string connection = "Data Source=LAPTOP-J4FO9U9C\\SQLEXPRESS;Initial Catalog=\"tournament system 2\";Integrated Security=True";

        public void updateTournamentStatus(int tournamentId)
        {
            int status = 0;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand com1 = new SqlCommand("UPDATE dbo.tournament set tournament_status=@tournament_status where tournament_id=@tournament_id ", con);
            com1.Parameters.AddWithValue("@tournament_status", status);
            com1.Parameters.AddWithValue("@tournament_id", tournamentId);
            // SqlDataReader myreader;
            try
            {
                con.Open();
                com1.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void updateCurrentRound(int tournamentId,int a)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand com1 = new SqlCommand("UPDATE dbo.tournament set tournament_current_round=@tournament_current_round where tournament_id=@tournament_id ", con);
            com1.Parameters.AddWithValue("@tournament_current_round", a);
            com1.Parameters.AddWithValue("@tournament_id", tournamentId);
            // SqlDataReader myreader;
            try
            {
                con.Open();
                com1.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }

        }
        public void saveMatchWinner(matchClass match)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand com1 = new SqlCommand("UPDATE dbo.match set [match_winner(team_id)]=@match_winner where match_id=@match_idd ", con);
            com1.Parameters.AddWithValue("@match_idd", match.matchId);
            com1.Parameters.AddWithValue("@match_winner", match.winner.teamId);
           // SqlDataReader myreader;
            try
            {
                con.Open();
                 com1.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            saveMatchScore(match);
            save_MatchCompiting_id(match);
        }

        public void save_MatchCompiting_id(matchClass match)
        {
            
                SqlConnection con = new SqlConnection(connection);
                SqlCommand com1 = new SqlCommand("UPDATE dbo.match_participant SET [match_participant_team(team_id)]=@match_participant_team_id WHERE [match_participant_parent_match(match_id)]=@match_participant_parent_match_id  ", con);
                com1.Parameters.AddWithValue("@match_participant_team_id", match.winner.teamId);
                com1.Parameters.AddWithValue("@match_participant_parent_match_id", match.matchId);
               
                // SqlDataReader myreader;
                try
                {
                    con.Open();
                    com1.ExecuteNonQuery();

                }
                catch (Exception)
                {

                    throw;
                }
            

        }
        public void saveMatchScore(matchClass match)
        {
            foreach (matchParticipentTeamClass item in match.matchPArticipentTeams)
            {
                SqlConnection con = new SqlConnection(connection);
                SqlCommand com1 = new SqlCommand("UPDATE dbo.match_participant set match_participant_score=@match_participant_score where match_idd=@match_idd AND [match_participant_team(team_id)]=@teamid ", con);
                com1.Parameters.AddWithValue("@match_idd", match.matchId);
                com1.Parameters.AddWithValue("@teamid", item.matchParticipentTeam.teamId);
                com1.Parameters.AddWithValue("@match_participant_score", item.score);
                // SqlDataReader myreader;
                try
                {
                    con.Open();
                    com1.ExecuteNonQuery();

                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }
        public List<List<matchClass>>  getAllmatchParticipentAndScore (tournamentClass tournament)
        {
            List<List<matchClass>> allRounds = new List<List<matchClass>>();
            allRounds = tournament.AllRounds;
            foreach (List<matchClass> round in allRounds)
            {
                foreach (matchClass match in round)
                {
                    List<matchParticipentTeamClass> matchparticipent = new List<matchParticipentTeamClass>();
                    SqlConnection con = new SqlConnection(connection);
                    SqlCommand command1 = new SqlCommand(" SELECT *  from dbo.match_participant where match_idd=@match_idd ", con);
                    command1.Parameters.AddWithValue("@match_idd", match.matchId);
                    SqlDataReader myreader;
                    try
                    {
                        con.Open();
                        myreader = command1.ExecuteReader();
                        while (myreader.Read())
                        {
                            matchParticipentTeamClass a = new matchParticipentTeamClass();

                            a.matchParticipentTeamClassId = myreader.GetInt32("match_participant_id");
                            
                            if (myreader["match_participant_score"] != DBNull.Value)
                            {
                                 a.score = myreader.GetInt32("match_participant_score");
      
                            }
                            //[[match_participant_team(team_id)]=match_participant_team(team_id)
                            //[match_participant_parent_match(match_id)]=match_participant_parent_match(match_id)

                            if (myreader["match_participant_team(team_id)"] != DBNull.Value)
                            {
                                int teamID = myreader.GetInt32("match_participant_team(team_id)");
                                a.matchParticipentTeam = getTeamById(teamID);
                            }
                            if (myreader["match_participant_parent_match(match_id)"] != DBNull.Value)
                            {
                                int parantMatchID = myreader.GetInt32("match_participant_parent_match(match_id)");
                                a.parantMatch = getParantmatchByID(parantMatchID, allRounds);
                            }
                           
                            matchparticipent.Add(a);

                        }

                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An exception occurred:");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);

                    }
                    match.matchPArticipentTeams = matchparticipent;
                }
            }
            return allRounds;

        }
        public matchClass getParantmatchByID(int matchID, List<List<matchClass>> allRounds)
        {
            matchClass match1 = new matchClass();
            foreach (List<matchClass> round in allRounds)
            {
                foreach (matchClass match in round)
                { 
                    if(match.matchId== matchID)
                    {
                        match1 = match;
                    }

                }
            }
            return match1;
        }
        public List<teamClass> getTournamentEnteredTeams(int tournametID)
        {
            List<teamClass> EnteredTeams = new List<teamClass>();
            SqlConnection con = new SqlConnection(connection);
            SqlCommand command1 = new SqlCommand(" SELECT *  from dbo.tournament_teams where tournament_id=@tournament_id ", con);
            command1.Parameters.AddWithValue("@tournament_id", tournametID);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = command1.ExecuteReader();
                while (myreader.Read())
                {
                    teamClass  a = new teamClass();
                    int teamID= myreader.GetInt32("team_id");
                     
                    a = getTeamById(teamID);
                    EnteredTeams.Add(a);
                }
                
                  con.Close();
            }
            catch (Exception ex)
            {

            }
            return EnteredTeams;                                                                  ///////last team member loading?????????????/////////
        }

       
        public List<List<matchClass>> getAllroundforTournamentLOad (tournamentClass tournamet)
        {
            List<List<matchClass>> allRounds = new List<List<matchClass>>();
            for(int match_round=1; match_round<= tournamet.TournamentRound; match_round++)
            {
                List<matchClass>Rounds = new List<matchClass>();
                //get mach details for first round andd addthem to a list
                SqlConnection con = new SqlConnection(connection);
                SqlCommand command1 = new SqlCommand(" SELECT *  from dbo.match where tournament_id=@tournament_id AND match_round=@match_round ", con);
                command1.Parameters.AddWithValue("@tournament_id", tournamet.tournamentId);
                command1.Parameters.AddWithValue("@match_round", match_round);
                SqlDataReader myreader;

                try
                {
                    con.Open();
                    myreader = command1.ExecuteReader();
                    while (myreader.Read())
                    {
                        matchClass a = new matchClass();
                        a.matchId = myreader.GetInt32("match_id");
                        a.matchRound = match_round;
                        
                        if (myreader["match_winner(team_id)"] != DBNull.Value)
                        {
                            // get winer team id 
                            int winer_team_id = myreader.GetInt32("match_winner(team_id)");
                            //load team add to the match
                            a.winner = getTeamById(winer_team_id);
                        }
                        

                        Rounds.Add(a);
                    }
                    allRounds.Add(Rounds);
                       con.Close();
                 }
                catch (Exception ex)
                {
                  
                }
                

            }
            return allRounds;
        }

        /// <summary>
        /// unchaked output
        /// </summary>
        /// <param name="winer_team_id"></param>
        /// <returns></returns>
        public teamClass getTeamById(int winer_team_id)
        {
            teamClass team = new teamClass();
            SqlConnection con = new SqlConnection(connection);
            SqlCommand command12 = new SqlCommand(" SELECT *  from dbo.team where team_id=@team_id", con);
            command12.Parameters.AddWithValue("@team_id", winer_team_id);
            
            SqlDataReader myreader;
            con.Open();
            myreader = command12.ExecuteReader();
            while (myreader.Read())
            {
                team.teamName = myreader.GetString("team_name");
                team.teamId = winer_team_id;
            }
            con.Close();
            SqlCommand command2 = new SqlCommand(" SELECT *  from dbo.team_member where team_id=@team_id", con);
            command2.Parameters.AddWithValue("@team_id", winer_team_id);

            SqlDataReader myreader2;
            con.Open();
            myreader2 = command2.ExecuteReader();
            while (myreader2.Read())
            {
                int player_ID;
                player_ID = myreader2.GetInt32("player_id");
                team.teamMembers.Add(getPlayerdetailsWith_id(player_ID)) ;
            }
            con.Close();
            return team;
        }

        public List<prizeClass> getAllOrganizerPrizeForTurnament(int tournamentID)
        {
            List<prizeClass> prizes = new List<prizeClass>();
            SqlConnection con = new SqlConnection(connection);
            SqlCommand command1 = new SqlCommand(" SELECT *  from dbo.prize where tournament_id=@tournament_id ", con);
            command1.Parameters.AddWithValue("@tournament_id", tournamentID);
            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = command1.ExecuteReader();
                while (myreader.Read())
                {
                    prizeClass a = new prizeClass();
                    a.prizeId = myreader.GetInt32("prize_id");
                    a.prizeName = myreader.GetString("prize_name");
                    a.tournamentId_inprize = tournamentID;
                    a.prizeNumber = myreader.GetInt32("prize_number");
                    a.prizeAmount = myreader.GetInt32("prize_amount");


                    prizes.Add(a);
                }
                con.Close();
            }
            catch (Exception ex)
            {
            }
            return prizes;
        }

        public List<tournamentClass> getAllTournamentForOrganizerfinishied(int ID)//load tournament for selected organizer finised
        {
           
            List<tournamentClass> tournament = new List<tournamentClass>();
            SqlConnection con = new SqlConnection(connection);
            //con.Open();
            SqlCommand command1 = new SqlCommand(" SELECT *  from dbo.tournament where organizer_id=@organizer_id AND tournament_status=@tournament_status", con);
            command1.Parameters.AddWithValue("@organizer_id",ID);
            int status = 0;
            command1.Parameters.AddWithValue("@tournament_status", status);

            SqlDataReader myreader;
            
            try
            {
                con.Open();
                myreader = command1.ExecuteReader();
                while (myreader.Read())
                {
                    tournamentClass a = new tournamentClass();
                    a.tournamentId = myreader.GetInt32("tournament_id");
                    a.tournamentName = myreader.GetString("tournament_name");
                    a.OrganizerId = myreader.GetInt32("organizer_id");
                    a.TournamentRound = myreader.GetInt32("tournament_round");
                    a.TournamentStatus = myreader.GetInt32("tournament_status");
                    a.TournamentCurrentRound = myreader.GetInt32("tournament_current_round");
                
                  tournament.Add(a);
                 }
                 con.Close();
             }
              catch (Exception ex)
              {
              }
              return tournament;
        }
        public List<tournamentClass> getAllTournamentForOrganizerRunning(int ID)//load tournament for selected organizer running
        {


            List<tournamentClass> tournament = new List<tournamentClass>();
            SqlConnection con = new SqlConnection(connection);
            //con.Open();
            SqlCommand command1 = new SqlCommand(" SELECT *  from dbo.tournament where organizer_id=@organizer_id AND tournament_status=@tournament_status", con);
            command1.Parameters.AddWithValue("@organizer_id", ID);
            int status = 1;
            command1.Parameters.AddWithValue("@tournament_status", status);

            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = command1.ExecuteReader();
                while (myreader.Read())
                {
                    tournamentClass a = new tournamentClass();
                    a.tournamentId = myreader.GetInt32("tournament_id");
                    a.tournamentName = myreader.GetString("tournament_name");
                    a.OrganizerId = myreader.GetInt32("organizer_id");
                    a.TournamentRound = myreader.GetInt32("tournament_round");
                    a.TournamentStatus = myreader.GetInt32("tournament_status");
                    a.TournamentCurrentRound = myreader.GetInt32("tournament_current_round");

                    tournament.Add(a);
                }
                con.Close();
            }
            catch (Exception ex)
            {
            }
            return tournament;
        }
        public int get_player_id(string user)//////////////get organizer id with his name
        {
            int playerid;
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand command = new SqlCommand("Select player_id from dbo.player  where player_name=@player_name", con);
            command.Parameters.AddWithValue("@player_name", user);
            //model.playerId = command.ExecuteNonQuery();
            playerid = (int)(command.ExecuteScalar());
            return playerid;

        }
        public int get_OrganizerId (string user)//////////////get organizer id with his name
        {
            int OrganizerId;
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand command = new SqlCommand("Select organizer_id from dbo.organizer where organizer_name=@organizer_name", con);
            command.Parameters.AddWithValue("@organizer_name", user);
            //model.playerId = command.ExecuteNonQuery();
            OrganizerId = (int)(command.ExecuteScalar());
            return OrganizerId;
        
        }

        public void savePrize(List<prizeClass> enteredPeizes, int tournamentId)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.prize (prize_name,prize_number,prize_amount,tournament_id) VALUES (@prize_name,@prize_number,@prize_amount,@tournament_id)", con);

            con.Open();
            foreach (prizeClass prize in enteredPeizes)
            {
                cmd.Parameters.AddWithValue("@prize_name", prize.prizeName);
                cmd.Parameters.AddWithValue("@prize_number", prize.prizeNumber);
                cmd.Parameters.AddWithValue("@prize_amount", prize.prizeAmount);
                cmd.Parameters.AddWithValue("@tournament_id", tournamentId);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        //""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
        public void save_tournament_team(tournamentClass model)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            foreach (teamClass team in model.enteredTeams)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.tournament_teams (tournament_id,team_id) VALUES (@tournament_id,@team_id)", con);

                cmd.Parameters.AddWithValue("@tournament_id", model.tournamentId);
                cmd.Parameters.AddWithValue("@team_id", team.teamId);
                cmd.ExecuteNonQuery();
            }

            con.Close();

        }
        public void SaveTurnament(tournamentClass model,int tournamentRoundsNumber) /////////////whene first turnament is created///////////////////
        {
            
            int tournamentStatus = 1;
            int tournamentCurrentRound = 1;
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.tournament (tournament_name,organizer_id,tournament_round,tournament_status,tournament_current_round) VALUES (@tournament_name,@organizer_id,@tournament_round,@tournament_status,@tournament_current_round)", con);
            
            cmd.Parameters.AddWithValue("@tournament_name", model.tournamentName);
            cmd.Parameters.AddWithValue("@organizer_id", model.OrganizerId);
            cmd.Parameters.AddWithValue("@tournament_round", tournamentRoundsNumber);
            cmd.Parameters.AddWithValue("@tournament_status", tournamentStatus);
            cmd.Parameters.AddWithValue("@tournament_current_round", tournamentCurrentRound);
            cmd.ExecuteNonQuery();
            /// geting turnament id from database
            SqlCommand command = new SqlCommand("Select tournament_id from dbo.tournament where tournament_name=@tournament_name", con);
            command.Parameters.AddWithValue("@tournament_name", model.tournamentName);           
            model.tournamentId = (int)(command.ExecuteScalar());
            con.Close();
            //////////////////////////////
            save_tournament_team(model);
            //saving prize
            savePrize(model.enteredPeizes, model.tournamentId);
            // saving match and match participent
            foreach (List<matchClass> round in model.AllRounds)
            {
                con.Open();
                foreach (matchClass matchup in round)//save each match in the round
                {
                    //SqlCommand cmd_match = new SqlCommand("INSERT INTO dbo.match (tournament_id,match_round) VALUES (@tournament_id,@match_round)", con);

                    //cmd_match.Parameters.AddWithValue("@tournament_id", model.tournamentId);
                    //cmd_match.Parameters.AddWithValue("@match_round", matchup.matchRound);
                    //cmd_match.ExecuteNonQuery();
                    //get mach id back
                    //con.Open();
                    SqlCommand cmd_match = new SqlCommand("INSERT INTO dbo.match (tournament_id, match_round) OUTPUT INSERTED.match_id VALUES (@tournament_id, @match_round)", con);

                    cmd_match.Parameters.AddWithValue("@tournament_id", model.tournamentId);
                    cmd_match.Parameters.AddWithValue("@match_round", matchup.matchRound);

                    //int insertedMatchId = (int)cmd_match.ExecuteScalar();
                    //int a= (int)cmd_match.ExecuteScalar();///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    matchup.matchId=(int)cmd_match.ExecuteScalar();

                    foreach (matchParticipentTeamClass entered_team in matchup.matchPArticipentTeams)// save the matchParticipent of current round
                    {
                        SqlCommand cmd_matchParticipent = new SqlCommand("INSERT INTO dbo.match_participant (match_idd,[match_participant_parent_match(match_id)],[match_participant_team(team_id)]) OUTPUT INSERTED.match_participant_id VALUES (@match_idd,@match_participant_parent_match,@match_participant_team)", con);

                        cmd_matchParticipent.Parameters.AddWithValue("@match_idd", matchup.matchId);
                        if (entered_team.parantMatch == null)
                        {
                            cmd_matchParticipent.Parameters.AddWithValue("@match_participant_parent_match", DBNull.Value);
                        }
                        else
                        {
                            cmd_matchParticipent.Parameters.AddWithValue("@match_participant_parent_match", entered_team.parantMatch.matchId);

                        }
                       
                        if (entered_team.matchParticipentTeam==null)
                        {
                            cmd_matchParticipent.Parameters.AddWithValue("@match_participant_team", DBNull.Value);
                        }
                        else
                        {
                            cmd_matchParticipent.Parameters.AddWithValue("@match_participant_team", entered_team.matchParticipentTeam.teamId);

                        }
                        //cmd_matchParticipent.ExecuteNonQuery();
                        ////get mach id back
                        entered_team.matchParticipentTeamClassId = (int)cmd_matchParticipent.ExecuteScalar();

                    }

                }
                con.Close();

            }

        }
        public List<teamClass> getAllTeams_id_name()
        {
            List<teamClass> allTeams = new List<teamClass>();
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd1 = new SqlCommand(" SELECT * FROM dbo.team  ", con);
            SqlDataReader myreader;
      //      [team_id]
      //,[team_name]
            try
            {
                con.Open();
                myreader = cmd1.ExecuteReader();
                while (myreader.Read())
                {
                    teamClass a = new teamClass();                   
                    a.teamId = myreader.GetInt32("team_id");
                    a.teamName= myreader.GetString("team_name");
                    a.playerId = getPlayerId(a.teamId);
                    playerClass x = new playerClass();
                    x=getPlayerdetailsWith_id(a.playerId);
                    a.teamMembers.Add( x );
                    // also add team members to boject a.teamMembers= getTeamMembers(a.teamId) [a listof players in team]
                    allTeams.Add(a);
                }
                con.Close();
            }
            catch(Exception ex)
            {
            }

            return allTeams;
        }

        playerClass getPlayerdetailsWith_id(int playerid)/////////////////////////////////// last changed////////////////////////////
        {
            int x = -1;
            playerClass a = new playerClass();
            a.playerId = playerid;
            SqlConnection conn = new SqlConnection(connection);
            //SELECT player_id FROM dbo.team_member where team_id=@team_id player_id
           
            SqlCommand cmd12 = new SqlCommand(" SELECT player_name, player_password, player_email, player_number  FROM dbo.player  where player_id=@player_id ", conn);
            cmd12.Parameters.AddWithValue("@player_id", playerid);
            
            //SqlDataReader myreader1;
            SqlDataReader myreader;
            conn.Open();
            myreader = cmd12.ExecuteReader();

            myreader.Read();
                // (player_id,player_name, player_password, player_email, player_number)

                a.playerName = myreader.GetString("player_name");
                a.playerPassword = myreader.GetString("player_password");
                a.playerEmail = myreader.GetString("player_email");
                a.playerNumber = myreader.GetInt32("player_number");
                a.playerId = playerid;


               return a;
        }

        int getPlayerId(int teamId)/////////////////////////////////// last changed////////////////////////////
        {
            int x =-1;

             SqlConnection conn = new SqlConnection(connection);
            conn.Open();
             SqlCommand cmd12 = new SqlCommand(" SELECT player_id FROM dbo.team_member where team_id=@team_id  ", conn);
             cmd12.Parameters.AddWithValue("@team_id", teamId);
             //SqlDataReader myreader1;
             using (SqlDataReader reader = cmd12.ExecuteReader())
             {
                if (reader.Read())
                {
                    x = reader.GetInt32("player_id");
                }
             }
            conn.Close();

            return x;
        }




        public void Save_team_in_database(List<playerClass> model,string team_name)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
      //      [team_id]
      //,[team_name]
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.team (team_name) VALUES (@team_name)", con);
            cmd.Parameters.AddWithValue("@team_name", team_name);
            cmd.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();///////////////////////////////////////////////////////////////////////////////////////////////////
            SqlCommand command = new SqlCommand("Select team_id from dbo.team where team_name=@team_name", con);
            command.Parameters.AddWithValue("@team_name", team_name);
            int team_id = (int)(command.ExecuteScalar());
            con.Close();
            foreach (var player in model)
            {
                //          [team_member_id]
                //,[team_id]
                //,[player_id]
                con.Open();
                SqlCommand cmd1 = new SqlCommand("INSERT INTO dbo.team_member (team_id,player_id) VALUES (@team_id,@player_id)", con);
                cmd1.Parameters.AddWithValue("@team_id", team_id);
                cmd1.Parameters.AddWithValue("@player_id", player.playerId);////////////////////
                cmd1.ExecuteNonQuery();
                con.Close();
                
            }

        }

        public List<organizerClass> getAllOrganizer()
        {
            List<organizerClass> allorganizerlist = new List<organizerClass>();
           SqlConnection con = new SqlConnection(connection);

            SqlCommand cmd1 = new SqlCommand(" SELECT * FROM dbo.organizer  ", con);
            SqlDataReader myreader;
      //      [organizer_id]
      //,[organizer_name]
      //,[organizer_password]
      //,[organizer_email]
      //,[organizer_number]
            try
           {
                con.Open();
                myreader = cmd1.ExecuteReader();
                while (myreader.Read())
                {
                    organizerClass a = new organizerClass();
                   // (player_id,player_name, player_password, player_email, player_number)
                    a.organizerId = myreader.GetInt32("organizer_id");
                    a.organizerName = myreader.GetString("organizer_name");
                    a.organizerPassword= myreader.GetString("organizer_password");
                    a.organizerEmail = myreader.GetString("organizer_email");
                    a.organizerNumber = myreader.GetInt32("organizer_number");
                    allorganizerlist.Add(a);
               }
                con.Close();
            }
            catch (Exception ex)
            {

            }


            return allorganizerlist;
        }


        public List<playerClass> getAllPlayer()
        {
            List<playerClass> allplayerList = new List<playerClass>();
            SqlConnection con = new SqlConnection(connection);
            
            SqlCommand cmd1 = new SqlCommand(" SELECT * FROM dbo.player  ", con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader=cmd1.ExecuteReader();
                while(myreader.Read())
                {
                    playerClass a = new playerClass();
                    // (player_id,player_name, player_password, player_email, player_number)
                    a.playerId = myreader.GetInt32("player_id");
                    a.playerName = myreader.GetString("player_name");
                    a.playerPassword= myreader.GetString("player_password");
                    a.playerEmail= myreader.GetString("player_email");
                    a.playerNumber = myreader.GetInt32("player_number");
                    allplayerList.Add(a);
                }
                con.Close();
            }
            catch (Exception ex)
            {

            }
            

            return allplayerList;
        }

        public playerClass updateUsernOrganizer(playerClass model, string user)
        {
             
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE  dbo.Login set password=@player_password where user__name=@player_name", con);
            cmd.Parameters.AddWithValue("@player_name", user);
            cmd.Parameters.AddWithValue("@player_password", model.playerPassword);
            cmd.ExecuteNonQuery();
            //      [organizer_name]
            //,[organizer_password]
            //,[organizer_email]
            //,[organizer_number]
            SqlCommand cmd1 = new SqlCommand("UPDATE  dbo.organizer set organizer_password=@organizer_password, organizer_email=@organizer_email, organizer_number=@organizer_number where organizer_name=@organizer_name", con);
            cmd1.Parameters.AddWithValue("@organizer_name", user);
            cmd1.Parameters.AddWithValue("@organizer_password", model.playerPassword);
            cmd1.Parameters.AddWithValue("@organizer_email", model.playerEmail);
            cmd1.Parameters.AddWithValue("@organizer_number", model.playerNumber);
            cmd1.ExecuteNonQuery();
            con.Close();
            return model;
        }
        public playerClass updateUsernPlayer(playerClass model,string user)
        {
            
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE  dbo.Login set password=@player_password where user__name=@player_name", con);
            cmd.Parameters.AddWithValue("@player_name", user);
            cmd.Parameters.AddWithValue("@player_password", model.playerPassword);
            cmd.ExecuteNonQuery();


            //      ,[player_name]
            //,[player_password]
            //,[player_email]
            //,[player_number]
            SqlCommand cmd1 = new SqlCommand("UPDATE  dbo.player set player_password=@player_password, player_email=@player_email, player_number=@player_number where player_name=@player_name", con);
            cmd1.Parameters.AddWithValue("@player_name", user);
            cmd1.Parameters.AddWithValue("@player_password", model.playerPassword);
            cmd1.Parameters.AddWithValue("@player_email", model.playerEmail);
            cmd1.Parameters.AddWithValue("@player_number", model.playerNumber);
            cmd1.ExecuteNonQuery();
            con.Close();
            return model;
        }
        public string deleteUsernOrganizer(string model)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete dbo.Login  where user__name=@player_name", con);
            cmd.Parameters.AddWithValue("@player_name", model);
            cmd.ExecuteNonQuery();


            SqlCommand cmd1 = new SqlCommand("Delete dbo.organizer where organizer_name=@player_name", con);
            cmd1.Parameters.AddWithValue("@player_name", model);
            cmd1.ExecuteNonQuery();
            con.Close();

            return "successfully deleted";

        }
        public string deleteUsernPlayer(string model)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete dbo.Login  where user__name=@player_name", con);
            cmd.Parameters.AddWithValue("@player_name", model);
            cmd.ExecuteNonQuery();


            SqlCommand cmd1 = new SqlCommand("Delete dbo.player  where player_name=@player_name", con);
            cmd1.Parameters.AddWithValue("@player_name", model);
            cmd1.ExecuteNonQuery();
            con.Close();

            return "successfully deleted";
            
        }
       public playerClass createUsernPlayer(playerClass model)
        {
            
            SqlConnection con = new SqlConnection(connection);
            con.Open();
           //      [player_name]
           //,[player_password]
           //,[player_email]
           //,[player_number]
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.player (player_name,player_password,player_email,player_number) VALUES (@player_name,@player_password,@player_email,@player_number)", con);
            cmd.Parameters.AddWithValue("@player_name",model.playerName);
            cmd.Parameters.AddWithValue("@player_password", model.playerPassword);
            cmd.Parameters.AddWithValue("@player_email", model.playerEmail);
            cmd.Parameters.AddWithValue("@player_number", model.playerNumber);
            cmd.ExecuteNonQuery();
            SqlCommand command = new SqlCommand("Select player_id from dbo.player where player_name=@player_name", con);
            command.Parameters.AddWithValue("@player_name", model.playerName);
            //model.playerId = command.ExecuteNonQuery();
            model.playerId = (int)(command.ExecuteScalar());
            // add data to login table
            //      [user__name]
            //,[password]
            //,[status]
            SqlCommand cmd2 = new SqlCommand("INSERT INTO dbo.Login (user__name,password,status) VALUES (@user__name,@password,@status)", con);
            cmd2.Parameters.AddWithValue("@user__name", model.playerName);
            cmd2.Parameters.AddWithValue("@password", model.playerPassword);
            cmd2.Parameters.AddWithValue("@status", "Player");
            cmd2.ExecuteNonQuery();
            con.Close();
            return model;
        }
        public organizerClass createUsernOrganizer(organizerClass model)
        {

            SqlConnection con = new SqlConnection(connection);
            con.Open();
      //      [organizer_id]
      //,[organizer_name]
      //,[organizer_password]
      //,[organizer_email]
      //,[organizer_number]
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.organizer (organizer_name,organizer_password,organizer_email,organizer_number) VALUES (@organizer_name,@organizer_password,@organizer_email,@organizer_number)", con);
            cmd.Parameters.AddWithValue("@organizer_name", model.organizerName);
            cmd.Parameters.AddWithValue("@organizer_password", model.organizerPassword);
            cmd.Parameters.AddWithValue("@organizer_email", model.organizerEmail);
            cmd.Parameters.AddWithValue("@organizer_number", model.organizerNumber);
            cmd.ExecuteNonQuery();
            SqlCommand command = new SqlCommand("Select organizer_id from dbo.organizer where organizer_name=@organizer_name", con);
            command.Parameters.AddWithValue("@organizer_name", model.organizerName);
            //model.playerId = command.ExecuteNonQuery();
            model.organizerId = (int)(command.ExecuteScalar());
            //add organiger to login table
            //      [user__name]
            //,[password]
            //,[status]
            SqlCommand cmd2 = new SqlCommand("INSERT INTO dbo.Login (user__name,password,status) VALUES (@user__name,@password,@status)", con);
            cmd2.Parameters.AddWithValue("@user__name", model.organizerName);
            cmd2.Parameters.AddWithValue("@password", model.organizerPassword);
            cmd2.Parameters.AddWithValue("@status", "Organizer");
            cmd2.ExecuteNonQuery();
            con.Close();
            return model;
        }

        

    }
}
