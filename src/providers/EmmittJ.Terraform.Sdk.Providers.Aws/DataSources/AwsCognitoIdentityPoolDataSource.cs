using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cognito_identity_pool.
/// </summary>
public class AwsCognitoIdentityPoolDataSource : TerraformDataSource
{
    public AwsCognitoIdentityPoolDataSource(string name) : base("aws_cognito_identity_pool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The identity_pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolName is required")]
    [TerraformPropertyName("identity_pool_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IdentityPoolName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The allow_classic_flow attribute.
    /// </summary>
    [TerraformPropertyName("allow_classic_flow")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowClassicFlow => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_classic_flow");

    /// <summary>
    /// The allow_unauthenticated_identities attribute.
    /// </summary>
    [TerraformPropertyName("allow_unauthenticated_identities")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowUnauthenticatedIdentities => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_unauthenticated_identities");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cognito_identity_providers attribute.
    /// </summary>
    [TerraformPropertyName("cognito_identity_providers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> CognitoIdentityProviders => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "cognito_identity_providers");

    /// <summary>
    /// The developer_provider_name attribute.
    /// </summary>
    [TerraformPropertyName("developer_provider_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeveloperProviderName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "developer_provider_name");

    /// <summary>
    /// The openid_connect_provider_arns attribute.
    /// </summary>
    [TerraformPropertyName("openid_connect_provider_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> OpenidConnectProviderArns => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "openid_connect_provider_arns");

    /// <summary>
    /// The saml_provider_arns attribute.
    /// </summary>
    [TerraformPropertyName("saml_provider_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SamlProviderArns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "saml_provider_arns");

    /// <summary>
    /// The supported_login_providers attribute.
    /// </summary>
    [TerraformPropertyName("supported_login_providers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> SupportedLoginProviders => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "supported_login_providers");

}
