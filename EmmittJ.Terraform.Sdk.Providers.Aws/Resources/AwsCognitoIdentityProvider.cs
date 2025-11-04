using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_identity_provider resource.
/// </summary>
public class AwsCognitoIdentityProvider : TerraformResource
{
    public AwsCognitoIdentityProvider(string name) : base("aws_cognito_identity_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The attribute_mapping attribute.
    /// </summary>
    public Dictionary<string, string>? AttributeMapping
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("attribute_mapping")?.Value;
        set => this.WithProperty("attribute_mapping", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The idp_identifiers attribute.
    /// </summary>
    public List<string>? IdpIdentifiers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("idp_identifiers")?.Value;
        set => this.WithProperty("idp_identifiers", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The provider_details attribute.
    /// </summary>
    public Dictionary<string, string>? ProviderDetails
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("provider_details")?.Value;
        set => this.WithProperty("provider_details", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public string? ProviderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provider_name")?.Value;
        set => this.WithProperty("provider_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    public string? ProviderType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provider_type")?.Value;
        set => this.WithProperty("provider_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    public string? UserPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_pool_id")?.Value;
        set => this.WithProperty("user_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
