using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for protocol in AwsDatasyncLocationFsxOpenzfsFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationFsxOpenzfsFileSystemProtocolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protocol";

    /// <summary>
    /// Nfs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Nfs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Nfs block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Nfs block(s) allowed")]
    public required TerraformList<AwsDatasyncLocationFsxOpenzfsFileSystemProtocolBlockNfsBlock> Nfs
    {
        get => GetRequiredArgument<TerraformList<AwsDatasyncLocationFsxOpenzfsFileSystemProtocolBlockNfsBlock>>("nfs");
        set => SetArgument("nfs", value);
    }

}

/// <summary>
/// Block type for nfs in AwsDatasyncLocationFsxOpenzfsFileSystemProtocolBlock.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationFsxOpenzfsFileSystemProtocolBlockNfsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nfs";

    /// <summary>
    /// MountOptions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MountOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MountOptions block(s) allowed")]
    public required TerraformList<AwsDatasyncLocationFsxOpenzfsFileSystemProtocolBlockNfsBlockMountOptionsBlock> MountOptions
    {
        get => GetRequiredArgument<TerraformList<AwsDatasyncLocationFsxOpenzfsFileSystemProtocolBlockNfsBlockMountOptionsBlock>>("mount_options");
        set => SetArgument("mount_options", value);
    }

}

/// <summary>
/// Block type for mount_options in AwsDatasyncLocationFsxOpenzfsFileSystemProtocolBlockNfsBlock.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationFsxOpenzfsFileSystemProtocolBlockNfsBlockMountOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mount_options";

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Represents a aws_datasync_location_fsx_openzfs_file_system Terraform resource.
/// Manages a aws_datasync_location_fsx_openzfs_file_system resource.
/// </summary>
public partial class AwsDatasyncLocationFsxOpenzfsFileSystem(string name) : TerraformResource("aws_datasync_location_fsx_openzfs_file_system", name)
{
    /// <summary>
    /// The fsx_filesystem_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FsxFilesystemArn is required")]
    public required TerraformValue<string> FsxFilesystemArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("fsx_filesystem_arn");
        set => SetArgument("fsx_filesystem_arn", value);
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
    /// The security_group_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupArns is required")]
    public required TerraformSet<string> SecurityGroupArns
    {
        get => GetRequiredArgument<TerraformSet<string>>("security_group_arns");
        set => SetArgument("security_group_arns", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformValue<string> Subdirectory
    {
        get => GetArgument<TerraformValue<string>>("subdirectory") ?? CreateReference("subdirectory");
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
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => CreateReference("creation_time");

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string> Uri
        => CreateReference("uri");

    /// <summary>
    /// Protocol block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Protocol block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protocol block(s) allowed")]
    public required TerraformList<AwsDatasyncLocationFsxOpenzfsFileSystemProtocolBlock> Protocol
    {
        get => GetRequiredArgument<TerraformList<AwsDatasyncLocationFsxOpenzfsFileSystemProtocolBlock>>("protocol");
        set => SetArgument("protocol", value);
    }

}
