using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for device in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDeviceDeviceBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformProperty<string> DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// The iot_thing_name attribute.
    /// </summary>
    public TerraformProperty<string>? IotThingName
    {
        get => GetProperty<TerraformProperty<string>>("iot_thing_name");
        set => WithProperty("iot_thing_name", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceFleetName is required")]
    public required TerraformProperty<string> DeviceFleetName
    {
        get => GetProperty<TerraformProperty<string>>("device_fleet_name");
        set => this.WithProperty("device_fleet_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Device block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Device block(s) allowed")]
    public List<AwsSagemakerDeviceDeviceBlock>? Device
    {
        get => GetProperty<List<AwsSagemakerDeviceDeviceBlock>>("device");
        set => this.WithProperty("device", value);
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
