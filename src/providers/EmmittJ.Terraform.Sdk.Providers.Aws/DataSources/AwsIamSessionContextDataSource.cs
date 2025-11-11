using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_session_context.
/// </summary>
public partial class AwsIamSessionContextDataSource : TerraformDataSource
{
    public AwsIamSessionContextDataSource(string name) : base("aws_iam_session_context", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The issuer_arn attribute.
    /// </summary>
    [TerraformProperty("issuer_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IssuerArn { get; }

    /// <summary>
    /// The issuer_id attribute.
    /// </summary>
    [TerraformProperty("issuer_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IssuerId { get; }

    /// <summary>
    /// The issuer_name attribute.
    /// </summary>
    [TerraformProperty("issuer_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IssuerName { get; }

    /// <summary>
    /// The session_name attribute.
    /// </summary>
    [TerraformProperty("session_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SessionName { get; }

}
