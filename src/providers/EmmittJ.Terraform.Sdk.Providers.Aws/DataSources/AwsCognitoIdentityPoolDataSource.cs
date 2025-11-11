using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cognito_identity_pool.
/// </summary>
public partial class AwsCognitoIdentityPoolDataSource : TerraformDataSource
{
    public AwsCognitoIdentityPoolDataSource(string name) : base("aws_cognito_identity_pool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolName is required")]
    [TerraformProperty("identity_pool_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IdentityPoolName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The allow_classic_flow attribute.
    /// </summary>
    [TerraformProperty("allow_classic_flow")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AllowClassicFlow { get; }

    /// <summary>
    /// The allow_unauthenticated_identities attribute.
    /// </summary>
    [TerraformProperty("allow_unauthenticated_identities")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AllowUnauthenticatedIdentities { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cognito_identity_providers attribute.
    /// </summary>
    [TerraformProperty("cognito_identity_providers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> CognitoIdentityProviders { get; }

    /// <summary>
    /// The developer_provider_name attribute.
    /// </summary>
    [TerraformProperty("developer_provider_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeveloperProviderName { get; }

    /// <summary>
    /// The openid_connect_provider_arns attribute.
    /// </summary>
    [TerraformProperty("openid_connect_provider_arns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> OpenidConnectProviderArns { get; }

    /// <summary>
    /// The saml_provider_arns attribute.
    /// </summary>
    [TerraformProperty("saml_provider_arns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SamlProviderArns { get; }

    /// <summary>
    /// The supported_login_providers attribute.
    /// </summary>
    [TerraformProperty("supported_login_providers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> SupportedLoginProviders { get; }

}
