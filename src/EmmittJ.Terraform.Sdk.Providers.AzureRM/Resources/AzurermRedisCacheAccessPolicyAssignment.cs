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
    public TerraformLiteralProperty<string>? AccessPolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_policy_name");
        set => this.WithProperty("access_policy_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_id");
        set => this.WithProperty("object_id", value);
    }

    /// <summary>
    /// The object_id_alias attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ObjectIdAlias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_id_alias");
        set => this.WithProperty("object_id_alias", value);
    }

    /// <summary>
    /// The redis_cache_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RedisCacheId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redis_cache_id");
        set => this.WithProperty("redis_cache_id", value);
    }

}
