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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The device_trust_provider_type attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTrustProviderType
    {
        get => GetProperty<TerraformProperty<string>>("device_trust_provider_type");
        set => this.WithProperty("device_trust_provider_type", value);
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
    /// The policy_reference_name attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyReferenceName
    {
        get => GetProperty<TerraformProperty<string>>("policy_reference_name");
        set => this.WithProperty("policy_reference_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The trust_provider_type attribute.
    /// </summary>
    public TerraformProperty<string>? TrustProviderType
    {
        get => GetProperty<TerraformProperty<string>>("trust_provider_type");
        set => this.WithProperty("trust_provider_type", value);
    }

    /// <summary>
    /// The user_trust_provider_type attribute.
    /// </summary>
    public TerraformProperty<string>? UserTrustProviderType
    {
        get => GetProperty<TerraformProperty<string>>("user_trust_provider_type");
        set => this.WithProperty("user_trust_provider_type", value);
    }

}
