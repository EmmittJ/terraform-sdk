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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The linked_managed_redis_ids attribute.
    /// </summary>
    public HashSet<string>? LinkedManagedRedisIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("linked_managed_redis_ids")?.Value;
        set => this.WithProperty("linked_managed_redis_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The managed_redis_id attribute.
    /// </summary>
    public string? ManagedRedisId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_redis_id")?.Value;
        set => this.WithProperty("managed_redis_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
