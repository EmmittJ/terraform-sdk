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
        this.DeclareOutput("event_buses");
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_buses attribute.
    /// </summary>
    public TerraformExpression EventBuses => this["event_buses"];

}
