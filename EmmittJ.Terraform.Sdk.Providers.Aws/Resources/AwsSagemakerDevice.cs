using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_device resource.
/// </summary>
public class AwsSagemakerDevice : TerraformResource
{
    public AwsSagemakerDevice(string name) : base("aws_sagemaker_device", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("agent_version");
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The device_fleet_name attribute.
    /// </summary>
    public string? DeviceFleetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_fleet_name")?.Value;
        set => this.WithProperty("device_fleet_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The agent_version attribute.
    /// </summary>
    public TerraformExpression AgentVersion => this["agent_version"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
