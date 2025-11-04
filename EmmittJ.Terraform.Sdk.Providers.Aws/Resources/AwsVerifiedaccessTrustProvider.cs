using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_verifiedaccess_trust_provider resource.
/// </summary>
public class AwsVerifiedaccessTrustProvider : TerraformResource
{
    public AwsVerifiedaccessTrustProvider(string name) : base("aws_verifiedaccess_trust_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The device_trust_provider_type attribute.
    /// </summary>
    public string? DeviceTrustProviderType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_trust_provider_type")?.Value;
        set => this.WithProperty("device_trust_provider_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The policy_reference_name attribute.
    /// </summary>
    public string? PolicyReferenceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_reference_name")?.Value;
        set => this.WithProperty("policy_reference_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The trust_provider_type attribute.
    /// </summary>
    public string? TrustProviderType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_provider_type")?.Value;
        set => this.WithProperty("trust_provider_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_trust_provider_type attribute.
    /// </summary>
    public string? UserTrustProviderType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_trust_provider_type")?.Value;
        set => this.WithProperty("user_trust_provider_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
