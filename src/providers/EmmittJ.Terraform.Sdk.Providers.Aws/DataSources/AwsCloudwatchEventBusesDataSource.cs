using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_event_buses Terraform data source.
/// Retrieves information about a aws_cloudwatch_event_buses.
/// </summary>
public partial class AwsCloudwatchEventBusesDataSource(string name) : TerraformDataSource("aws_cloudwatch_event_buses", name)
{
    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The event_buses attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EventBuses
        => AsReference("event_buses");

}
