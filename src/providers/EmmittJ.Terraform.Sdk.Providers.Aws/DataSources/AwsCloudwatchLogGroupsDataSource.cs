using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudwatch_log_groups.
/// </summary>
public class AwsCloudwatchLogGroupsDataSource : TerraformDataSource
{
    public AwsCloudwatchLogGroupsDataSource(string name) : base("aws_cloudwatch_log_groups", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The log_group_name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("log_group_name_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogGroupNamePrefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformPropertyName("arns")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Arns => new TerraformReference(this, "arns");

    /// <summary>
    /// The log_group_names attribute.
    /// </summary>
    [TerraformPropertyName("log_group_names")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> LogGroupNames => new TerraformReference(this, "log_group_names");

}
