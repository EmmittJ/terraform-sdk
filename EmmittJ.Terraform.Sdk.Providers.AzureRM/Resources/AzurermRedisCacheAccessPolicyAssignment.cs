using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_redis_cache_access_policy_assignment resource.
/// </summary>
public class AzurermRedisCacheAccessPolicyAssignment : TerraformResource
{
    public AzurermRedisCacheAccessPolicyAssignment(string name) : base("azurerm_redis_cache_access_policy_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The access_policy_name attribute.
    /// </summary>
    public string? AccessPolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_policy_name")?.Value;
        set => this.WithProperty("access_policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public string? ObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_id")?.Value;
        set => this.WithProperty("object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object_id_alias attribute.
    /// </summary>
    public string? ObjectIdAlias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_id_alias")?.Value;
        set => this.WithProperty("object_id_alias", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The redis_cache_id attribute.
    /// </summary>
    public string? RedisCacheId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redis_cache_id")?.Value;
        set => this.WithProperty("redis_cache_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
