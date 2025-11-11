using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudwatch_event_buses.
/// </summary>
public partial class AwsCloudwatchEventBusesDataSource : TerraformDataSource
{
    public AwsCloudwatchEventBusesDataSource(string name) : base("aws_cloudwatch_event_buses", name)
    {
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NamePrefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The event_buses attribute.
    /// </summary>
    [TerraformProperty("event_buses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EventBuses { get; }

}
