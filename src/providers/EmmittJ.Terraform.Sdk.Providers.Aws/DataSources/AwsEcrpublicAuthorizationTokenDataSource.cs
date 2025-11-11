using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecrpublic_authorization_token.
/// </summary>
public class AwsEcrpublicAuthorizationTokenDataSource : TerraformDataSource
{
    public AwsEcrpublicAuthorizationTokenDataSource(string name) : base("aws_ecrpublic_authorization_token", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The authorization_token attribute.
    /// </summary>
    [TerraformPropertyName("authorization_token")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AuthorizationToken => new TerraformReference(this, "authorization_token");

    /// <summary>
    /// The expires_at attribute.
    /// </summary>
    [TerraformPropertyName("expires_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpiresAt => new TerraformReference(this, "expires_at");

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Password => new TerraformReference(this, "password");

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformPropertyName("user_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserName => new TerraformReference(this, "user_name");

}
