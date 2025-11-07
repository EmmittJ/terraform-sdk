using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iam_workforce_pool_provider_key resource.
/// </summary>
public class GoogleIamWorkforcePoolProviderKey : TerraformResource
{
    public GoogleIamWorkforcePoolProviderKey(string name) : base("google_iam_workforce_pool_provider_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("expire_time");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
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
    /// The ID to use for the key, which becomes the final component of the resource name. This value must be 4-32 characters, and may contain the characters [a-z0-9-].
    /// </summary>
    public TerraformProperty<string>? KeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_id");
        set => this.WithProperty("key_id", value);
    }

    /// <summary>
    /// The location for the resource.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The ID of the provider.
    /// </summary>
    public TerraformProperty<string>? ProviderId
    {
        get => GetProperty<TerraformProperty<string>>("provider_id");
        set => this.WithProperty("provider_id", value);
    }

    /// <summary>
    /// The purpose of the key. Possible values: [&amp;quot;ENCRYPTION&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Use
    {
        get => GetProperty<TerraformProperty<string>>("use");
        set => this.WithProperty("use", value);
    }

    /// <summary>
    /// The ID of the workforce pool.
    /// </summary>
    public TerraformProperty<string>? WorkforcePoolId
    {
        get => GetProperty<TerraformProperty<string>>("workforce_pool_id");
        set => this.WithProperty("workforce_pool_id", value);
    }

    /// <summary>
    /// The time after which the key will be permanently deleted and cannot be recovered.
    /// Note that the key may get purged before this time if the total limit of keys per provider is exceeded.
    /// </summary>
    public TerraformExpression ExpireTime => this["expire_time"];

    /// <summary>
    /// Identifier. The resource name of the key.
    /// Format: &#39;locations/{location}/workforcePools/{workforcePoolId}/providers/{providerId}/keys/{keyId}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The state of the key.
    /// </summary>
    public TerraformExpression State => this["state"];

}
