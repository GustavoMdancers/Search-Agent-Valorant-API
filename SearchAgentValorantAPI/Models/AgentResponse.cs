namespace SearchAgentValorantAPI.Models;

public class AgentResponse
{
    public int Status { get; set; }
    public AgentData? Data { get; set; }
}

public class AgentData
{
    public string? DisplayName { get; set; }
    public string? Description { get; set; }
    public string? FullPortrait { get; set; }
}