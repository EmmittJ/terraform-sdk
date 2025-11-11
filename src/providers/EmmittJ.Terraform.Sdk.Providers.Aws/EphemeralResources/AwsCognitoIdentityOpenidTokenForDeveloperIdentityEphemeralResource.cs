using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_identity_openid_token_for_developer_identity ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public partial class AwsCognitoIdentityOpenidTokenForDeveloperIdentityEphemeralResource : TerraformEphemeralResource
{
    public AwsCognitoIdentityOpenidTokenForDeveloperIdentityEphemeralResource(string name) : base("aws_cognito_identity_openid_token_for_developer_identity", name)
    {
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    [TerraformProperty("identity_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IdentityId { get; set; }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    [TerraformProperty("identity_pool_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IdentityPoolId { get; set; }

    /// <summary>
    /// The logins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Logins is required")]
    [TerraformProperty("logins")]
    // Required argument - source generator will implement get/set
    public required TerraformMap<string> Logins { get; set; }

    /// <summary>
    /// The principal_tags attribute.
    /// </summary>
    [TerraformProperty("principal_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? PrincipalTags { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The token_duration attribute.
    /// </summary>
    [TerraformProperty("token_duration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TokenDuration { get; set; }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [TerraformProperty("token")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Token { get; }

}
