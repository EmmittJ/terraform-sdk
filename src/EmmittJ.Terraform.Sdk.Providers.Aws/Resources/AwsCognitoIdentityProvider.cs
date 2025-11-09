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
    public TerraformMapProperty<string>? AttributeMapping
    {
        get => GetProperty<TerraformMapProperty<string>>("attribute_mapping");
        set => this.WithProperty("attribute_mapping", value);
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
    /// The idp_identifiers attribute.
    /// </summary>
    public TerraformProperty<List<string>>? IdpIdentifiers
    {
        get => GetProperty<TerraformProperty<List<string>>>("idp_identifiers");
        set => this.WithProperty("idp_identifiers", value);
    }

    /// <summary>
    /// The provider_details attribute.
    /// </summary>
    public TerraformMapProperty<string>? ProviderDetails
    {
        get => GetProperty<TerraformMapProperty<string>>("provider_details");
        set => this.WithProperty("provider_details", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformProperty<string>? ProviderName
    {
        get => GetProperty<TerraformProperty<string>>("provider_name");
        set => this.WithProperty("provider_name", value);
    }

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    public TerraformProperty<string>? ProviderType
    {
        get => GetProperty<TerraformProperty<string>>("provider_type");
        set => this.WithProperty("provider_type", value);
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
    /// The user_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserPoolId
    {
        get => GetProperty<TerraformProperty<string>>("user_pool_id");
        set => this.WithProperty("user_pool_id", value);
    }

}
