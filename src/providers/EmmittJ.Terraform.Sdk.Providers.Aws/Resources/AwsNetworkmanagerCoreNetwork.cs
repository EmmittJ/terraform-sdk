using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNetworkmanagerCoreNetwork.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerCoreNetworkTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_networkmanager_core_network Terraform resource.
/// Manages a aws_networkmanager_core_network resource.
/// </summary>
public partial class AwsNetworkmanagerCoreNetwork(string name) : TerraformResource("aws_networkmanager_core_network", name)
{
    /// <summary>
    /// The base_policy_document attribute.
    /// </summary>
    public TerraformValue<string>? BasePolicyDocument
    {
        get => new TerraformReference<string>(this, "base_policy_document");
        set => SetArgument("base_policy_document", value);
    }

    /// <summary>
    /// The base_policy_regions attribute.
    /// </summary>
    public TerraformSet<string>? BasePolicyRegions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "base_policy_regions").ResolveNodes(ctx));
        set => SetArgument("base_policy_regions", value);
    }

    /// <summary>
    /// The create_base_policy attribute.
    /// </summary>
    public TerraformValue<bool>? CreateBasePolicy
    {
        get => new TerraformReference<bool>(this, "create_base_policy");
        set => SetArgument("create_base_policy", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformValue<string> GlobalNetworkId
    {
        get => new TerraformReference<string>(this, "global_network_id");
        set => SetArgument("global_network_id", value);
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
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The edges attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Edges
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "edges").ResolveNodes(ctx));
    }

    /// <summary>
    /// The segments attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Segments
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "segments").ResolveNodes(ctx));
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerCoreNetworkTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerCoreNetworkTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
