using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for home_directory_mappings in AwsTransferAccess.
/// Nesting mode: list
/// </summary>
public class AwsTransferAccessHomeDirectoryMappingsBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("entry");
        set => SetArgument("entry", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<string> Target
    {
        get => GetRequiredArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

}


/// <summary>
/// Block type for posix_profile in AwsTransferAccess.
/// Nesting mode: list
/// </summary>
public class AwsTransferAccessPosixProfileBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<double>>("gid");
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
        get => GetRequiredArgument<TerraformValue<double>>("uid");
        set => SetArgument("uid", value);
    }

}


/// <summary>
/// Represents a aws_transfer_access Terraform resource.
/// Manages a aws_transfer_access resource.
/// </summary>
public partial class AwsTransferAccess(string name) : TerraformResource("aws_transfer_access", name)
{
    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    public required TerraformValue<string> ExternalId
    {
        get => GetRequiredArgument<TerraformValue<string>>("external_id");
        set => SetArgument("external_id", value);
    }

    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    public TerraformValue<string>? HomeDirectory
    {
        get => GetArgument<TerraformValue<string>>("home_directory");
        set => SetArgument("home_directory", value);
    }

    /// <summary>
    /// The home_directory_type attribute.
    /// </summary>
    public TerraformValue<string>? HomeDirectoryType
    {
        get => GetArgument<TerraformValue<string>>("home_directory_type");
        set => SetArgument("home_directory_type", value);
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
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => GetArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
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
    /// The role attribute.
    /// </summary>
    public TerraformValue<string>? Role
    {
        get => GetArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// HomeDirectoryMappings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 HomeDirectoryMappings block(s) allowed")]
    public TerraformList<AwsTransferAccessHomeDirectoryMappingsBlock>? HomeDirectoryMappings
    {
        get => GetArgument<TerraformList<AwsTransferAccessHomeDirectoryMappingsBlock>>("home_directory_mappings");
        set => SetArgument("home_directory_mappings", value);
    }

    /// <summary>
    /// PosixProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixProfile block(s) allowed")]
    public TerraformList<AwsTransferAccessPosixProfileBlock>? PosixProfile
    {
        get => GetArgument<TerraformList<AwsTransferAccessPosixProfileBlock>>("posix_profile");
        set => SetArgument("posix_profile", value);
    }

}
