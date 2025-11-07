using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<HashSet<string>>? LinkedManagedRedisIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("linked_managed_redis_ids");
        set => this.WithProperty("linked_managed_redis_ids", value);
    }

    /// <summary>
    /// The managed_redis_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedRedisId
    {
        get => GetProperty<TerraformProperty<string>>("managed_redis_id");
        set => this.WithProperty("managed_redis_id", value);
    }

}
