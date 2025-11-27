using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for device in AwsSagemakerDevice.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDeviceDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "device";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformValue<string> DeviceName
    {
        get => new TerraformReference<string>(this, "device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// The iot_thing_name attribute.
    /// </summary>
    public TerraformValue<string>? IotThingName
    {
        get => new TerraformReference<string>(this, "iot_thing_name");
        set => SetArgument("iot_thing_name", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_device Terraform resource.
/// Manages a aws_sagemaker_device resource.
/// </summary>
public partial class AwsSagemakerDevice(string name) : TerraformResource("aws_sagemaker_device", name)
{
    /// <summary>
    /// The device_fleet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceFleetName is required")]
    public required TerraformValue<string> DeviceFleetName
    {
        get => new TerraformReference<string>(this, "device_fleet_name");
        set => SetArgument("device_fleet_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformValue<string> AgentVersion
    {
        get => new TerraformReference<string>(this, "agent_version");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Device block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Device is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Device block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Device block(s) allowed")]
    public required TerraformList<AwsSagemakerDeviceDeviceBlock> Device
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerDeviceDeviceBlock>>("device");
        set => SetArgument("device", value);
    }

}
