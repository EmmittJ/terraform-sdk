using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for openzfs_configuration in AwsFsxS3AccessPointAttachment.
/// Nesting mode: list
/// </summary>
public class AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "openzfs_configuration";

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    public required TerraformValue<string> VolumeId
    {
        get => GetRequiredArgument<TerraformValue<string>>("volume_id");
        set => SetArgument("volume_id", value);
    }

    /// <summary>
    /// FileSystemIdentity block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlockFileSystemIdentityBlock>? FileSystemIdentity
    {
        get => GetArgument<TerraformList<AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlockFileSystemIdentityBlock>>("file_system_identity");
        set => SetArgument("file_system_identity", value);
    }

}

/// <summary>
/// Block type for file_system_identity in AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlockFileSystemIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_system_identity";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// PosixUser block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlockFileSystemIdentityBlockPosixUserBlock>? PosixUser
    {
        get => GetArgument<TerraformList<AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlockFileSystemIdentityBlockPosixUserBlock>>("posix_user");
        set => SetArgument("posix_user", value);
    }

}

/// <summary>
/// Block type for posix_user in AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlockFileSystemIdentityBlock.
/// Nesting mode: list
/// </summary>
public class AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlockFileSystemIdentityBlockPosixUserBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "posix_user";

    /// <summary>
    /// The gid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gid is required")]
    public required TerraformValue<double> Gid
    {
        get => GetRequiredArgument<TerraformValue<double>>("gid");
        set => SetArgument("gid", value);
    }

    /// <summary>
    /// The secondary_gids attribute.
    /// </summary>
    public TerraformList<double>? SecondaryGids
    {
        get => GetArgument<TerraformList<double>>("secondary_gids");
        set => SetArgument("secondary_gids", value);
    }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uid is required")]
    public required TerraformValue<double> Uid
    {
        get => GetRequiredArgument<TerraformValue<double>>("uid");
        set => SetArgument("uid", value);
    }

}


/// <summary>
/// Block type for s3_access_point in AwsFsxS3AccessPointAttachment.
/// Nesting mode: list
/// </summary>
public class AwsFsxS3AccessPointAttachmentS3AccessPointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_access_point";

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => GetArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// VpcConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFsxS3AccessPointAttachmentS3AccessPointBlockVpcConfigurationBlock>? VpcConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxS3AccessPointAttachmentS3AccessPointBlockVpcConfigurationBlock>>("vpc_configuration");
        set => SetArgument("vpc_configuration", value);
    }

}

/// <summary>
/// Block type for vpc_configuration in AwsFsxS3AccessPointAttachmentS3AccessPointBlock.
/// Nesting mode: list
/// </summary>
public class AwsFsxS3AccessPointAttachmentS3AccessPointBlockVpcConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_configuration";

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string>? VpcId
    {
        get => GetArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsFsxS3AccessPointAttachment.
/// Nesting mode: single
/// </summary>
public class AwsFsxS3AccessPointAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_fsx_s3_access_point_attachment Terraform resource.
/// Manages a aws_fsx_s3_access_point_attachment resource.
/// </summary>
public partial class AwsFsxS3AccessPointAttachment(string name) : TerraformResource("aws_fsx_s3_access_point_attachment", name)
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The s3_access_point_alias attribute.
    /// </summary>
    public TerraformValue<string> S3AccessPointAlias
        => AsReference("s3_access_point_alias");

    /// <summary>
    /// The s3_access_point_arn attribute.
    /// </summary>
    public TerraformValue<string> S3AccessPointArn
        => AsReference("s3_access_point_arn");

    /// <summary>
    /// OpenzfsConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlock>? OpenzfsConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlock>>("openzfs_configuration");
        set => SetArgument("openzfs_configuration", value);
    }

    /// <summary>
    /// S3AccessPoint block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFsxS3AccessPointAttachmentS3AccessPointBlock>? S3AccessPoint
    {
        get => GetArgument<TerraformList<AwsFsxS3AccessPointAttachmentS3AccessPointBlock>>("s3_access_point");
        set => SetArgument("s3_access_point", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFsxS3AccessPointAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFsxS3AccessPointAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
