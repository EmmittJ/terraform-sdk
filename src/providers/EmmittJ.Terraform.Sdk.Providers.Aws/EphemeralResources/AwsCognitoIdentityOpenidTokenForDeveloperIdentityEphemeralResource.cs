using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_identity_openid_token_for_developer_identity ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class AwsCognitoIdentityOpenidTokenForDeveloperIdentityEphemeralResource : TerraformEphemeralResource
{
    public AwsCognitoIdentityOpenidTokenForDeveloperIdentityEphemeralResource(string name) : base("aws_cognito_identity_openid_token_for_developer_identity", name)
    {
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    [TerraformPropertyName("identity_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IdentityId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identity_id");

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    [TerraformPropertyName("identity_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IdentityPoolId { get; set; }

    /// <summary>
    /// The logins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Logins is required")]
    [TerraformPropertyName("logins")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Logins { get; set; }

    /// <summary>
    /// The principal_tags attribute.
    /// </summary>
    [TerraformPropertyName("principal_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? PrincipalTags { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The token_duration attribute.
    /// </summary>
    [TerraformPropertyName("token_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TokenDuration { get; set; }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [TerraformPropertyName("token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Token => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "token");

}
