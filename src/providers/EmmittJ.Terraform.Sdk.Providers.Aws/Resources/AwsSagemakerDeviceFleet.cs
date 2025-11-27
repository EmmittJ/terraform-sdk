using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for output_config in AwsSagemakerDeviceFleet.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDeviceFleetOutputConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_config";

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The s3_output_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3OutputLocation is required")]
    public required TerraformValue<string> S3OutputLocation
    {
        get => new TerraformReference<string>(this, "s3_output_location");
        set => SetArgument("s3_output_location", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_device_fleet Terraform resource.
/// Manages a aws_sagemaker_device_fleet resource.
/// </summary>
public partial class AwsSagemakerDeviceFleet(string name) : TerraformResource("aws_sagemaker_device_fleet", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

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
    /// The enable_iot_role_alias attribute.
    /// </summary>
    public TerraformValue<bool>? EnableIotRoleAlias
    {
        get => new TerraformReference<bool>(this, "enable_iot_role_alias");
        set => SetArgument("enable_iot_role_alias", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The iot_role_alias attribute.
    /// </summary>
    public TerraformValue<string> IotRoleAlias
    {
        get => new TerraformReference<string>(this, "iot_role_alias");
    }

    /// <summary>
    /// OutputConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputConfig block(s) allowed")]
    public required TerraformList<AwsSagemakerDeviceFleetOutputConfigBlock> OutputConfig
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerDeviceFleetOutputConfigBlock>>("output_config");
        set => SetArgument("output_config", value);
    }

}
