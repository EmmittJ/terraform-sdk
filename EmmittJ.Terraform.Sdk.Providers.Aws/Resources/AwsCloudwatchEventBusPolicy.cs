using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_event_bus_policy resource.
/// </summary>
public class AwsCloudwatchEventBusPolicy : TerraformResource
{
    public AwsCloudwatchEventBusPolicy(string name) : base("aws_cloudwatch_event_bus_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The event_bus_name attribute.
    /// </summary>
    public string? EventBusName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_bus_name")?.Value;
        set => this.WithProperty("event_bus_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public string? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy")?.Value;
        set => this.WithProperty("policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
