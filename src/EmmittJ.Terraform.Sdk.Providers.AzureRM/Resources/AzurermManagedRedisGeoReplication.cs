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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The linked_managed_redis_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedManagedRedisIds is required")]
    public HashSet<TerraformProperty<string>>? LinkedManagedRedisIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("linked_managed_redis_ids");
        set => this.WithProperty("linked_managed_redis_ids", value);
    }

    /// <summary>
    /// The managed_redis_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedRedisId is required")]
    public required TerraformProperty<string> ManagedRedisId
    {
        get => GetProperty<TerraformProperty<string>>("managed_redis_id");
        set => this.WithProperty("managed_redis_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagedRedisGeoReplicationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermManagedRedisGeoReplicationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
