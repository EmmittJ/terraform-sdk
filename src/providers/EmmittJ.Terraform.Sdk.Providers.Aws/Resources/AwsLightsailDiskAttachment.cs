using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lightsail_disk_attachment Terraform resource.
/// Manages a aws_lightsail_disk_attachment resource.
/// </summary>
public partial class AwsLightsailDiskAttachment(string name) : TerraformResource("aws_lightsail_disk_attachment", name)
{
    /// <summary>
    /// The disk_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskName is required")]
    public required TerraformValue<string> DiskName
    {
        get => GetRequiredArgument<TerraformValue<string>>("disk_name");
        set => SetArgument("disk_name", value);
    }

    /// <summary>
    /// The disk_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskPath is required")]
    public required TerraformValue<string> DiskPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("disk_path");
        set => SetArgument("disk_path", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformValue<string> InstanceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_name");
        set => SetArgument("instance_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

}
