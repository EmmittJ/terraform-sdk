using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for posix_user in AwsEfsAccessPoint.
/// Nesting mode: list
/// </summary>
public class AwsEfsAccessPointPosixUserBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("gid");
        set => SetArgument("gid", value);
    }

    /// <summary>
    /// The secondary_gids attribute.
    /// </summary>
    public TerraformSet<double>? SecondaryGids
    {
        get => GetArgument<TerraformSet<double>>("secondary_gids");
        set => SetArgument("secondary_gids", value);
    }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uid is required")]
    public required TerraformValue<double> Uid
    {
        get => GetArgument<TerraformValue<double>>("uid");
        set => SetArgument("uid", value);
    }

}


/// <summary>
/// Block type for root_directory in AwsEfsAccessPoint.
/// Nesting mode: list
/// </summary>
public class AwsEfsAccessPointRootDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "root_directory";

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// CreationInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreationInfo block(s) allowed")]
    public TerraformList<AwsEfsAccessPointRootDirectoryBlockCreationInfoBlock>? CreationInfo
    {
        get => GetArgument<TerraformList<AwsEfsAccessPointRootDirectoryBlockCreationInfoBlock>>("creation_info");
        set => SetArgument("creation_info", value);
    }

}

/// <summary>
/// Block type for creation_info in AwsEfsAccessPointRootDirectoryBlock.
/// Nesting mode: list
/// </summary>
public class AwsEfsAccessPointRootDirectoryBlockCreationInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "creation_info";

    /// <summary>
    /// The owner_gid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerGid is required")]
    public required TerraformValue<double> OwnerGid
    {
        get => GetArgument<TerraformValue<double>>("owner_gid");
        set => SetArgument("owner_gid", value);
    }

    /// <summary>
    /// The owner_uid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerUid is required")]
    public required TerraformValue<double> OwnerUid
    {
        get => GetArgument<TerraformValue<double>>("owner_uid");
        set => SetArgument("owner_uid", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public required TerraformValue<string> Permissions
    {
        get => GetArgument<TerraformValue<string>>("permissions");
        set => SetArgument("permissions", value);
    }

}


/// <summary>
/// Represents a aws_efs_access_point Terraform resource.
/// Manages a aws_efs_access_point resource.
/// </summary>
public partial class AwsEfsAccessPoint(string name) : TerraformResource("aws_efs_access_point", name)
{
    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformValue<string> FileSystemId
    {
        get => GetArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    public TerraformValue<string> FileSystemArn
        => AsReference("file_system_arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// PosixUser block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixUser block(s) allowed")]
    public TerraformList<AwsEfsAccessPointPosixUserBlock>? PosixUser
    {
        get => GetArgument<TerraformList<AwsEfsAccessPointPosixUserBlock>>("posix_user");
        set => SetArgument("posix_user", value);
    }

    /// <summary>
    /// RootDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootDirectory block(s) allowed")]
    public TerraformList<AwsEfsAccessPointRootDirectoryBlock>? RootDirectory
    {
        get => GetArgument<TerraformList<AwsEfsAccessPointRootDirectoryBlock>>("root_directory");
        set => SetArgument("root_directory", value);
    }

}
