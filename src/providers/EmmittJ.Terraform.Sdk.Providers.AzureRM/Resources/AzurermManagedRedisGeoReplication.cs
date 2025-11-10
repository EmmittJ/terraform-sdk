using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagedRedisGeoReplicationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_managed_redis_geo_replication resource.
/// </summary>
public class AzurermManagedRedisGeoReplication : TerraformResource
{
    public AzurermManagedRedisGeoReplication(string name) : base("azurerm_managed_redis_geo_replication", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("linked_managed_redis_ids");
        SetOutput("managed_redis_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The linked_managed_redis_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedManagedRedisIds is required")]
    public HashSet<TerraformProperty<string>> LinkedManagedRedisIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("linked_managed_redis_ids");
        set => SetProperty("linked_managed_redis_ids", value);
    }

    /// <summary>
    /// The managed_redis_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedRedisId is required")]
    public required TerraformProperty<string> ManagedRedisId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_redis_id");
        set => SetProperty("managed_redis_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagedRedisGeoReplicationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
