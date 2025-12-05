using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ec2_config in AwsDatasyncLocationEfs.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationEfsEc2ConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ec2_config";

    /// <summary>
    /// The security_group_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupArns is required")]
    public required TerraformSet<string> SecurityGroupArns
    {
        get => GetRequiredArgument<TerraformSet<string>>("security_group_arns");
        set => SetArgument("security_group_arns", value);
    }

    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetArn is required")]
    public required TerraformValue<string> SubnetArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_arn");
        set => SetArgument("subnet_arn", value);
    }

}


/// <summary>
/// Represents a aws_datasync_location_efs Terraform resource.
/// Manages a aws_datasync_location_efs resource.
/// </summary>
public partial class AwsDatasyncLocationEfs(string name) : TerraformResource("aws_datasync_location_efs", name)
{
    /// <summary>
    /// The access_point_arn attribute.
    /// </summary>
    public TerraformValue<string>? AccessPointArn
    {
        get => GetArgument<TerraformValue<string>>("access_point_arn");
        set => SetArgument("access_point_arn", value);
    }

    /// <summary>
    /// The efs_file_system_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EfsFileSystemArn is required")]
    public required TerraformValue<string> EfsFileSystemArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("efs_file_system_arn");
        set => SetArgument("efs_file_system_arn", value);
    }

    /// <summary>
    /// The file_system_access_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? FileSystemAccessRoleArn
    {
        get => GetArgument<TerraformValue<string>>("file_system_access_role_arn");
        set => SetArgument("file_system_access_role_arn", value);
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
    /// The in_transit_encryption attribute.
    /// </summary>
    public TerraformValue<string>? InTransitEncryption
    {
        get => GetArgument<TerraformValue<string>>("in_transit_encryption");
        set => SetArgument("in_transit_encryption", value);
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
    /// The subdirectory attribute.
    /// </summary>
    public TerraformValue<string>? Subdirectory
    {
        get => GetArgument<TerraformValue<string>>("subdirectory");
        set => SetArgument("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string> Uri
        => CreateReference("uri");

    /// <summary>
    /// Ec2Config block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Ec2Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ec2Config block(s) allowed")]
    public required TerraformList<AwsDatasyncLocationEfsEc2ConfigBlock> Ec2Config
    {
        get => GetRequiredArgument<TerraformList<AwsDatasyncLocationEfsEc2ConfigBlock>>("ec2_config");
        set => SetArgument("ec2_config", value);
    }

}
