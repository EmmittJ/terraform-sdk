using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_storagegateway_local_disk Terraform data source.
/// Retrieves information about a aws_storagegateway_local_disk.
/// </summary>
public partial class AwsStoragegatewayLocalDiskDataSource(string name) : TerraformDataSource("aws_storagegateway_local_disk", name)
{
    /// <summary>
    /// The disk_node attribute.
    /// </summary>
    public TerraformValue<string> DiskNode
    {
        get => GetArgument<TerraformValue<string>>("disk_node") ?? CreateReference("disk_node");
        set => SetArgument("disk_node", value);
    }

    /// <summary>
    /// The disk_path attribute.
    /// </summary>
    public TerraformValue<string> DiskPath
    {
        get => GetArgument<TerraformValue<string>>("disk_path") ?? CreateReference("disk_path");
        set => SetArgument("disk_path", value);
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    public required TerraformValue<string> GatewayArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("gateway_arn");
        set => SetArgument("gateway_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    public TerraformValue<string> DiskId
        => CreateReference("disk_id");

}
