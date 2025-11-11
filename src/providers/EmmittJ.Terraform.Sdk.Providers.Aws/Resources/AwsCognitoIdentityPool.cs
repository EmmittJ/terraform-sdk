using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cognito_identity_providers in .
/// Nesting mode: set
/// </summary>
public partial class AwsCognitoIdentityPoolCognitoIdentityProvidersBlock : TerraformBlockBase
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformProperty("provider_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProviderName { get; set; }

    /// <summary>
    /// The server_side_token_check attribute.
    /// </summary>
    [TerraformProperty("server_side_token_check")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ServerSideTokenCheck { get; set; }

}

/// <summary>
/// Manages a aws_cognito_identity_pool resource.
/// </summary>
public partial class AwsCognitoIdentityPool : TerraformResource
{
    public AwsCognitoIdentityPool(string name) : base("aws_cognito_identity_pool", name)
    {
    }

    /// <summary>
    /// The allow_classic_flow attribute.
    /// </summary>
    [TerraformProperty("allow_classic_flow")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowClassicFlow { get; set; }

    /// <summary>
    /// The allow_unauthenticated_identities attribute.
    /// </summary>
    [TerraformProperty("allow_unauthenticated_identities")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowUnauthenticatedIdentities { get; set; }

    /// <summary>
    /// The developer_provider_name attribute.
    /// </summary>
    [TerraformProperty("developer_provider_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeveloperProviderName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolName is required")]
    [TerraformProperty("identity_pool_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IdentityPoolName { get; set; }

    /// <summary>
    /// The openid_connect_provider_arns attribute.
    /// </summary>
    [TerraformProperty("openid_connect_provider_arns")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? OpenidConnectProviderArns { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The saml_provider_arns attribute.
    /// </summary>
    [TerraformProperty("saml_provider_arns")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? SamlProviderArns { get; set; }

    /// <summary>
    /// The supported_login_providers attribute.
    /// </summary>
    [TerraformProperty("supported_login_providers")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? SupportedLoginProviders { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for cognito_identity_providers.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("cognito_identity_providers")]
    public TerraformSet<TerraformBlock<AwsCognitoIdentityPoolCognitoIdentityProvidersBlock>>? CognitoIdentityProviders { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
