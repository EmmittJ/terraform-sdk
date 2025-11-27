using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_storagegateway_cache Terraform resource.
/// Manages a aws_storagegateway_cache resource.
/// </summary>
public partial class AwsStoragegatewayCache(string name) : TerraformResource("aws_storagegateway_cache", name)
{
    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskId is required")]
    public required TerraformValue<string> DiskId
    {
        get => new TerraformReference<string>(this, "disk_id");
        set => SetArgument("disk_id", value);
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    public required TerraformValue<string> GatewayArn
    {
        get => new TerraformReference<string>(this, "gateway_arn");
        set => SetArgument("gateway_arn", value);
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

}
