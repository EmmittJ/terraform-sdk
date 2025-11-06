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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID to use for the key, which becomes the final component of the resource name. This value must be 4-32 characters, and may contain the characters [a-z0-9-].
    /// </summary>
    public string? KeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_id")?.Value;
        set => this.WithProperty("key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location for the resource.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the provider.
    /// </summary>
    public string? ProviderId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provider_id")?.Value;
        set => this.WithProperty("provider_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The purpose of the key. Possible values: [&amp;quot;ENCRYPTION&amp;quot;]
    /// </summary>
    public string? Use
    {
        get => GetProperty<TerraformLiteralProperty<string>>("use")?.Value;
        set => this.WithProperty("use", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the workforce pool.
    /// </summary>
    public string? WorkforcePoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workforce_pool_id")?.Value;
        set => this.WithProperty("workforce_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
