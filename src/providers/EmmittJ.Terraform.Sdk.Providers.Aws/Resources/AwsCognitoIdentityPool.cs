using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cognito_identity_providers in .
/// Nesting mode: set
/// </summary>
public class AwsCognitoIdentityPoolCognitoIdentityProvidersBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformPropertyName("provider_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProviderName { get; set; }

    /// <summary>
    /// The server_side_token_check attribute.
    /// </summary>
    [TerraformPropertyName("server_side_token_check")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ServerSideTokenCheck { get; set; }

}

/// <summary>
/// Manages a aws_cognito_identity_pool resource.
/// </summary>
public class AwsCognitoIdentityPool : TerraformResource
{
    public AwsCognitoIdentityPool(string name) : base("aws_cognito_identity_pool", name)
    {
    }

    /// <summary>
    /// The allow_classic_flow attribute.
    /// </summary>
    [TerraformPropertyName("allow_classic_flow")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowClassicFlow { get; set; }

    /// <summary>
    /// The allow_unauthenticated_identities attribute.
    /// </summary>
    [TerraformPropertyName("allow_unauthenticated_identities")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowUnauthenticatedIdentities { get; set; }

    /// <summary>
    /// The developer_provider_name attribute.
    /// </summary>
    [TerraformPropertyName("developer_provider_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeveloperProviderName { get; set; }

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
    /// The openid_connect_provider_arns attribute.
    /// </summary>
    [TerraformPropertyName("openid_connect_provider_arns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? OpenidConnectProviderArns { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The saml_provider_arns attribute.
    /// </summary>
    [TerraformPropertyName("saml_provider_arns")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? SamlProviderArns { get; set; }

    /// <summary>
    /// The supported_login_providers attribute.
    /// </summary>
    [TerraformPropertyName("supported_login_providers")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? SupportedLoginProviders { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for cognito_identity_providers.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("cognito_identity_providers")]
    public TerraformSet<TerraformBlock<AwsCognitoIdentityPoolCognitoIdentityProvidersBlock>>? CognitoIdentityProviders { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
