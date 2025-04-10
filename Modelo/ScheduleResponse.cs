using System.Collections.Generic;

namespace PitchWin.Modelo
{
    public class ScheduleResponse
    {
        public List<DateInfo> Dates { get; set; }
    }

    public class DateInfo
    {
        public string Date { get; set; }
        public List<GameInfo> Games { get; set; }
    }

    public class GameInfo
    {
        public int GamePk { get; set; }
        public string OfficialDate { get; set; }
        public Status Status { get; set; }
        public Teams Teams { get; set; }
    }

    public class Status
    {
        public string DetailedState { get; set; }
    }

    public class Teams
    {
        public TeamWrapper Home { get; set; }
        public TeamWrapper Away { get; set; }
    }

    public class TeamWrapper
    {
        public Team Team { get; set; }
        public int Score { get; set; }
    }

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
