using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cognito_identity_providers in .
/// Nesting mode: set
/// </summary>
public class AwsCognitoIdentityPoolCognitoIdentityProvidersBlock : ITerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientId { get; set; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformPropertyName("provider_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProviderName { get; set; }

    /// <summary>
    /// The server_side_token_check attribute.
    /// </summary>
    [TerraformPropertyName("server_side_token_check")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ServerSideTokenCheck { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? AllowClassicFlow { get; set; }

    /// <summary>
    /// The allow_unauthenticated_identities attribute.
    /// </summary>
    [TerraformPropertyName("allow_unauthenticated_identities")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowUnauthenticatedIdentities { get; set; }

    /// <summary>
    /// The developer_provider_name attribute.
    /// </summary>
    [TerraformPropertyName("developer_provider_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeveloperProviderName { get; set; }

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
    /// The openid_connect_provider_arns attribute.
    /// </summary>
    [TerraformPropertyName("openid_connect_provider_arns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? OpenidConnectProviderArns { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The saml_provider_arns attribute.
    /// </summary>
    [TerraformPropertyName("saml_provider_arns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SamlProviderArns { get; set; }

    /// <summary>
    /// The supported_login_providers attribute.
    /// </summary>
    [TerraformPropertyName("supported_login_providers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? SupportedLoginProviders { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for cognito_identity_providers.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("cognito_identity_providers")]
    public TerraformSet<TerraformBlock<AwsCognitoIdentityPoolCognitoIdentityProvidersBlock>>? CognitoIdentityProviders { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
