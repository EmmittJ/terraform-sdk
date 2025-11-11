using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_authorization_token.
/// </summary>
public partial class AwsEcrAuthorizationTokenDataSource : TerraformDataSource
{
    public AwsEcrAuthorizationTokenDataSource(string name) : base("aws_ecr_authorization_token", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformProperty("registry_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RegistryId { get; set; }

    /// <summary>
    /// The authorization_token attribute.
    /// </summary>
    [TerraformProperty("authorization_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthorizationToken { get; }

    /// <summary>
    /// The expires_at attribute.
    /// </summary>
    [TerraformProperty("expires_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpiresAt { get; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Password { get; }

    /// <summary>
    /// The proxy_endpoint attribute.
    /// </summary>
    [TerraformProperty("proxy_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProxyEndpoint { get; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformProperty("user_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserName { get; }

}
