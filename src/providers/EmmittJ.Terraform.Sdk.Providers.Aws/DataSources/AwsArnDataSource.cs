using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_arn.
/// </summary>
public partial class AwsArnDataSource : TerraformDataSource
{
    public AwsArnDataSource(string name) : base("aws_arn", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The account attribute.
    /// </summary>
    [TerraformProperty("account")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Account { get; }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    [TerraformProperty("partition")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Partition { get; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Region { get; }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    [TerraformProperty("resource")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Resource { get; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [TerraformProperty("service")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Service { get; }

}
