using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_network_interface_attachment Terraform resource.
/// Manages a aws_network_interface_attachment resource.
/// </summary>
public partial class AwsNetworkInterfaceAttachment(string name) : TerraformResource("aws_network_interface_attachment", name)
{
    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    public required TerraformValue<double> DeviceIndex
    {
        get => new TerraformReference<double>(this, "device_index");
        set => SetArgument("device_index", value);
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
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    public TerraformValue<double> NetworkCardIndex
    {
        get => new TerraformReference<double>(this, "network_card_index");
        set => SetArgument("network_card_index", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformValue<string> NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
        set => SetArgument("network_interface_id", value);
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
    /// The attachment_id attribute.
    /// </summary>
    public TerraformValue<string> AttachmentId
    {
        get => new TerraformReference<string>(this, "attachment_id");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
