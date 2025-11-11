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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The identity_pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolName is required")]
    [TerraformPropertyName("identity_pool_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IdentityPoolName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The allow_classic_flow attribute.
    /// </summary>
    [TerraformPropertyName("allow_classic_flow")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AllowClassicFlow => new TerraformReference(this, "allow_classic_flow");

    /// <summary>
    /// The allow_unauthenticated_identities attribute.
    /// </summary>
    [TerraformPropertyName("allow_unauthenticated_identities")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AllowUnauthenticatedIdentities => new TerraformReference(this, "allow_unauthenticated_identities");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The cognito_identity_providers attribute.
    /// </summary>
    [TerraformPropertyName("cognito_identity_providers")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> CognitoIdentityProviders => new TerraformReference(this, "cognito_identity_providers");

    /// <summary>
    /// The developer_provider_name attribute.
    /// </summary>
    [TerraformPropertyName("developer_provider_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeveloperProviderName => new TerraformReference(this, "developer_provider_name");

    /// <summary>
    /// The openid_connect_provider_arns attribute.
    /// </summary>
    [TerraformPropertyName("openid_connect_provider_arns")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> OpenidConnectProviderArns => new TerraformReference(this, "openid_connect_provider_arns");

    /// <summary>
    /// The saml_provider_arns attribute.
    /// </summary>
    [TerraformPropertyName("saml_provider_arns")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SamlProviderArns => new TerraformReference(this, "saml_provider_arns");

    /// <summary>
    /// The supported_login_providers attribute.
    /// </summary>
    [TerraformPropertyName("supported_login_providers")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> SupportedLoginProviders => new TerraformReference(this, "supported_login_providers");

}
