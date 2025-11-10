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
    public TerraformProperty<TerraformProperty<string>>? NamePrefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The event_buses attribute.
    /// </summary>
    [TerraformPropertyName("event_buses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EventBuses => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "event_buses");

}
