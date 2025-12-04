using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_storagegateway_upload_buffer Terraform resource.
/// Manages a aws_storagegateway_upload_buffer resource.
/// </summary>
public partial class AwsStoragegatewayUploadBuffer(string name) : TerraformResource("aws_storagegateway_upload_buffer", name)
{
    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    public TerraformValue<string> DiskId
    {
        get => GetArgument<TerraformValue<string>>("disk_id") ?? AsReference("disk_id");
        set => SetArgument("disk_id", value);
    }

    /// <summary>
    /// The disk_path attribute.
    /// </summary>
    public TerraformValue<string> DiskPath
    {
        get => GetArgument<TerraformValue<string>>("disk_path") ?? AsReference("disk_path");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

}
