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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("base_policy_document");
        set => SetArgument("base_policy_document", value);
    }

    /// <summary>
    /// The base_policy_regions attribute.
    /// </summary>
    public TerraformSet<string>? BasePolicyRegions
    {
        get => GetArgument<TerraformSet<string>>("base_policy_regions");
        set => SetArgument("base_policy_regions", value);
    }

    /// <summary>
    /// The create_base_policy attribute.
    /// </summary>
    public TerraformValue<bool>? CreateBasePolicy
    {
        get => GetArgument<TerraformValue<bool>>("create_base_policy");
        set => SetArgument("create_base_policy", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformValue<string> GlobalNetworkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("global_network_id");
        set => SetArgument("global_network_id", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The edges attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Edges
        => AsReference("edges");

    /// <summary>
    /// The segments attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Segments
        => AsReference("segments");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerCoreNetworkTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerCoreNetworkTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
