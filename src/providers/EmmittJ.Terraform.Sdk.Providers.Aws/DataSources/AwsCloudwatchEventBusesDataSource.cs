using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudwatch_event_buses.
/// </summary>
public class AwsCloudwatchEventBusesDataSource : TerraformDataSource
{
    public AwsCloudwatchEventBusesDataSource(string name) : base("aws_cloudwatch_event_buses", name)
    {
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NamePrefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The event_buses attribute.
    /// </summary>
    [TerraformPropertyName("event_buses")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EventBuses => new TerraformReference(this, "event_buses");

}
