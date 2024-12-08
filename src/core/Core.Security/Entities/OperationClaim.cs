﻿using Core.Persistence.Repositories.Entities;

namespace Core.Security.Entities;

public class OperationClaim : Entity<int>
{
    public bool IsDeleted;

    public string Name { get; set; }

    public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; } = null!;

    public OperationClaim()
    {
        Name = string.Empty;
    }

    public OperationClaim(string name)
    {
        Name = name;
    }

    public OperationClaim(int id, string name)
        : base(id)
    {
        Name = name;
    }
}
