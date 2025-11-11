using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecrpublic_authorization_token.
/// </summary>
public partial class AwsEcrpublicAuthorizationTokenDataSource : TerraformDataSource
{
    public AwsEcrpublicAuthorizationTokenDataSource(string name) : base("aws_ecrpublic_authorization_token", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The authorization_token attribute.
    /// </summary>
    [TerraformProperty("authorization_token")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AuthorizationToken { get; }

    /// <summary>
    /// The expires_at attribute.
    /// </summary>
    [TerraformProperty("expires_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExpiresAt { get; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Password { get; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformProperty("user_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserName { get; }

}
