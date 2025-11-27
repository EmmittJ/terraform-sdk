using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for protocol in AwsDatasyncLocationFsxOntapFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationFsxOntapFileSystemProtocolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protocol";

    /// <summary>
    /// Nfs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Nfs block(s) allowed")]
    public TerraformList<AwsDatasyncLocationFsxOntapFileSystemProtocolBlockNfsBlock>? Nfs
    {
        get => GetArgument<TerraformList<AwsDatasyncLocationFsxOntapFileSystemProtocolBlockNfsBlock>>("nfs");
        set => SetArgument("nfs", value);
    }

    /// <summary>
    /// Smb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Smb block(s) allowed")]
    public TerraformList<AwsDatasyncLocationFsxOntapFileSystemProtocolBlockSmbBlock>? Smb
    {
        get => GetArgument<TerraformList<AwsDatasyncLocationFsxOntapFileSystemProtocolBlockSmbBlock>>("smb");
        set => SetArgument("smb", value);
    }

}

/// <summary>
/// Block type for nfs in AwsDatasyncLocationFsxOntapFileSystemProtocolBlock.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationFsxOntapFileSystemProtocolBlockNfsBlock : TerraformBlock
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
    public required TerraformList<AwsDatasyncLocationFsxOntapFileSystemProtocolBlockNfsBlockMountOptionsBlock> MountOptions
    {
        get => GetRequiredArgument<TerraformList<AwsDatasyncLocationFsxOntapFileSystemProtocolBlockNfsBlockMountOptionsBlock>>("mount_options");
        set => SetArgument("mount_options", value);
    }

}

/// <summary>
/// Block type for mount_options in AwsDatasyncLocationFsxOntapFileSystemProtocolBlockNfsBlock.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationFsxOntapFileSystemProtocolBlockNfsBlockMountOptionsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for smb in AwsDatasyncLocationFsxOntapFileSystemProtocolBlock.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationFsxOntapFileSystemProtocolBlockSmbBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "smb";

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformValue<string> User
    {
        get => new TerraformReference<string>(this, "user");
        set => SetArgument("user", value);
    }

    /// <summary>
    /// MountOptions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MountOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MountOptions block(s) allowed")]
    public required TerraformList<AwsDatasyncLocationFsxOntapFileSystemProtocolBlockSmbBlockMountOptionsBlock> MountOptions
    {
        get => GetRequiredArgument<TerraformList<AwsDatasyncLocationFsxOntapFileSystemProtocolBlockSmbBlockMountOptionsBlock>>("mount_options");
        set => SetArgument("mount_options", value);
    }

}

/// <summary>
/// Block type for mount_options in AwsDatasyncLocationFsxOntapFileSystemProtocolBlockSmbBlock.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationFsxOntapFileSystemProtocolBlockSmbBlockMountOptionsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Represents a aws_datasync_location_fsx_ontap_file_system Terraform resource.
/// Manages a aws_datasync_location_fsx_ontap_file_system resource.
/// </summary>
public partial class AwsDatasyncLocationFsxOntapFileSystem(string name) : TerraformResource("aws_datasync_location_fsx_ontap_file_system", name)
{
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
    /// The security_group_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupArns is required")]
    public required TerraformSet<string> SecurityGroupArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_arns").ResolveNodes(ctx));
        set => SetArgument("security_group_arns", value);
    }

    /// <summary>
    /// The storage_virtual_machine_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageVirtualMachineArn is required")]
    public required TerraformValue<string> StorageVirtualMachineArn
    {
        get => new TerraformReference<string>(this, "storage_virtual_machine_arn");
        set => SetArgument("storage_virtual_machine_arn", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformValue<string> Subdirectory
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
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// The fsx_filesystem_arn attribute.
    /// </summary>
    public TerraformValue<string> FsxFilesystemArn
    {
        get => new TerraformReference<string>(this, "fsx_filesystem_arn");
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
    }

    /// <summary>
    /// Protocol block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Protocol block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protocol block(s) allowed")]
    public required TerraformList<AwsDatasyncLocationFsxOntapFileSystemProtocolBlock> Protocol
    {
        get => GetRequiredArgument<TerraformList<AwsDatasyncLocationFsxOntapFileSystemProtocolBlock>>("protocol");
        set => SetArgument("protocol", value);
    }

}
