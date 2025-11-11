using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codeartifact_authorization_token.
/// </summary>
public partial class AwsCodeartifactAuthorizationTokenDataSource : TerraformDataSource
{
    public AwsCodeartifactAuthorizationTokenDataSource(string name) : base("aws_codeartifact_authorization_token", name)
    {
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformProperty("domain")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    [TerraformProperty("domain_owner")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DomainOwner { get; set; }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    [TerraformProperty("duration_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DurationSeconds { get; set; }

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
    /// The authorization_token attribute.
    /// </summary>
    [TerraformProperty("authorization_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthorizationToken { get; }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [TerraformProperty("expiration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Expiration { get; }

}
