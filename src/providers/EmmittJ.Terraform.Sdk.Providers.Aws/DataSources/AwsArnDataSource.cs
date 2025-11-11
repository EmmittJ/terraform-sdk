using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_arn.
/// </summary>
public class AwsArnDataSource : TerraformDataSource
{
    public AwsArnDataSource(string name) : base("aws_arn", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The account attribute.
    /// </summary>
    [TerraformPropertyName("account")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Account => new TerraformReference(this, "account");

    /// <summary>
    /// The partition attribute.
    /// </summary>
    [TerraformPropertyName("partition")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Partition => new TerraformReference(this, "partition");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Region => new TerraformReference(this, "region");

    /// <summary>
    /// The resource attribute.
    /// </summary>
    [TerraformPropertyName("resource")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Resource => new TerraformReference(this, "resource");

    /// <summary>
    /// The service attribute.
    /// </summary>
    [TerraformPropertyName("service")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Service => new TerraformReference(this, "service");

}
