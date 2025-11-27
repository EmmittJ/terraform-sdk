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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_arns").ResolveNodes(ctx));
        set => SetArgument("security_group_arns", value);
    }

    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetArn is required")]
    public required TerraformValue<string> SubnetArn
    {
        get => new TerraformReference<string>(this, "subnet_arn");
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
        get => new TerraformReference<string>(this, "access_point_arn");
        set => SetArgument("access_point_arn", value);
    }

    /// <summary>
    /// The efs_file_system_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EfsFileSystemArn is required")]
    public required TerraformValue<string> EfsFileSystemArn
    {
        get => new TerraformReference<string>(this, "efs_file_system_arn");
        set => SetArgument("efs_file_system_arn", value);
    }

    /// <summary>
    /// The file_system_access_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? FileSystemAccessRoleArn
    {
        get => new TerraformReference<string>(this, "file_system_access_role_arn");
        set => SetArgument("file_system_access_role_arn", value);
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
    /// The in_transit_encryption attribute.
    /// </summary>
    public TerraformValue<string>? InTransitEncryption
    {
        get => new TerraformReference<string>(this, "in_transit_encryption");
        set => SetArgument("in_transit_encryption", value);
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
    /// The subdirectory attribute.
    /// </summary>
    public TerraformValue<string>? Subdirectory
    {
        get => new TerraformReference<string>(this, "subdirectory");
        set => SetArgument("subdirectory", value);
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
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
    }

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
