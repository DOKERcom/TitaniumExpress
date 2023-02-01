using System;

namespace TitaniumExpress.Core.DomainModels;

public class UserDomainModel
{
    public string Username { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public HeroDomainModel Hero { get; set; } = new HeroDomainModel();

    public BotDomainModel Bot { get; set; } = new BotDomainModel();
}