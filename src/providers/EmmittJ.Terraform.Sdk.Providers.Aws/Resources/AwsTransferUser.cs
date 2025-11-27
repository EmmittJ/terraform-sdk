using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for home_directory_mappings in AwsTransferUser.
/// Nesting mode: list
/// </summary>
public class AwsTransferUserHomeDirectoryMappingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "home_directory_mappings";

    /// <summary>
    /// The entry attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entry is required")]
    public required TerraformValue<string> Entry
    {
        get => new TerraformReference<string>(this, "entry");
        set => SetArgument("entry", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<string> Target
    {
        get => new TerraformReference<string>(this, "target");
        set => SetArgument("target", value);
    }

}


/// <summary>
/// Block type for posix_profile in AwsTransferUser.
/// Nesting mode: list
/// </summary>
public class AwsTransferUserPosixProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "posix_profile";

    /// <summary>
    /// The gid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gid is required")]
    public required TerraformValue<double> Gid
    {
        get => new TerraformReference<double>(this, "gid");
        set => SetArgument("gid", value);
    }

    /// <summary>
    /// The secondary_gids attribute.
    /// </summary>
    public TerraformSet<double>? SecondaryGids
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "secondary_gids").ResolveNodes(ctx));
        set => SetArgument("secondary_gids", value);
    }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uid is required")]
    public required TerraformValue<double> Uid
    {
        get => new TerraformReference<double>(this, "uid");
        set => SetArgument("uid", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsTransferUser.
/// Nesting mode: single
/// </summary>
public class AwsTransferUserTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_transfer_user Terraform resource.
/// Manages a aws_transfer_user resource.
/// </summary>
public partial class AwsTransferUser(string name) : TerraformResource("aws_transfer_user", name)
{
    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    public TerraformValue<string>? HomeDirectory
    {
        get => new TerraformReference<string>(this, "home_directory");
        set => SetArgument("home_directory", value);
    }

    /// <summary>
    /// The home_directory_type attribute.
    /// </summary>
    public TerraformValue<string>? HomeDirectoryType
    {
        get => new TerraformReference<string>(this, "home_directory_type");
        set => SetArgument("home_directory_type", value);
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
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
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
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => new TerraformReference<string>(this, "role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => new TerraformReference<string>(this, "server_id");
        set => SetArgument("server_id", value);
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
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => new TerraformReference<string>(this, "user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// HomeDirectoryMappings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTransferUserHomeDirectoryMappingsBlock>? HomeDirectoryMappings
    {
        get => GetArgument<TerraformList<AwsTransferUserHomeDirectoryMappingsBlock>>("home_directory_mappings");
        set => SetArgument("home_directory_mappings", value);
    }

    /// <summary>
    /// PosixProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixProfile block(s) allowed")]
    public TerraformList<AwsTransferUserPosixProfileBlock>? PosixProfile
    {
        get => GetArgument<TerraformList<AwsTransferUserPosixProfileBlock>>("posix_profile");
        set => SetArgument("posix_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsTransferUserTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsTransferUserTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
