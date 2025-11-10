using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudwatch_event_buses.
/// </summary>
public class AwsCloudwatchEventBusesDataSource : TerraformDataSource
{
    public AwsCloudwatchEventBusesDataSource(string name) : base("aws_cloudwatch_event_buses", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("event_buses");
        SetOutput("name_prefix");
        SetOutput("region");
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The event_buses attribute.
    /// </summary>
    public TerraformExpression EventBuses => this["event_buses"];

}
