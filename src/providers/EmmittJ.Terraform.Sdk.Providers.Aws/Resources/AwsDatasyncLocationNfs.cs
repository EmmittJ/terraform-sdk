using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for mount_options in AwsDatasyncLocationNfs.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationNfsMountOptionsBlock : TerraformBlock
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
/// Block type for on_prem_config in AwsDatasyncLocationNfs.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationNfsOnPremConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_prem_config";

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentArns is required")]
    public required TerraformSet<string> AgentArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "agent_arns").ResolveNodes(ctx));
        set => SetArgument("agent_arns", value);
    }

}


/// <summary>
/// Represents a aws_datasync_location_nfs Terraform resource.
/// Manages a aws_datasync_location_nfs resource.
/// </summary>
public partial class AwsDatasyncLocationNfs(string name) : TerraformResource("aws_datasync_location_nfs", name)
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
    /// The server_hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerHostname is required")]
    public required TerraformValue<string> ServerHostname
    {
        get => new TerraformReference<string>(this, "server_hostname");
        set => SetArgument("server_hostname", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subdirectory is required")]
    public required TerraformValue<string> Subdirectory
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
    /// MountOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MountOptions block(s) allowed")]
    public TerraformList<AwsDatasyncLocationNfsMountOptionsBlock>? MountOptions
    {
        get => GetArgument<TerraformList<AwsDatasyncLocationNfsMountOptionsBlock>>("mount_options");
        set => SetArgument("mount_options", value);
    }

    /// <summary>
    /// OnPremConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnPremConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OnPremConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnPremConfig block(s) allowed")]
    public required TerraformList<AwsDatasyncLocationNfsOnPremConfigBlock> OnPremConfig
    {
        get => GetRequiredArgument<TerraformList<AwsDatasyncLocationNfsOnPremConfigBlock>>("on_prem_config");
        set => SetArgument("on_prem_config", value);
    }

}
