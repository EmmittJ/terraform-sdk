using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for default_cluster_config in GoogleGkeHubFleet.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFleetDefaultClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_cluster_config";

    /// <summary>
    /// BinaryAuthorizationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorizationConfig block(s) allowed")]
    public TerraformList<GoogleGkeHubFleetDefaultClusterConfigBlockBinaryAuthorizationConfigBlock>? BinaryAuthorizationConfig
    {
        get => GetArgument<TerraformList<GoogleGkeHubFleetDefaultClusterConfigBlockBinaryAuthorizationConfigBlock>>("binary_authorization_config");
        set => SetArgument("binary_authorization_config", value);
    }

    /// <summary>
    /// SecurityPostureConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityPostureConfig block(s) allowed")]
    public TerraformList<GoogleGkeHubFleetDefaultClusterConfigBlockSecurityPostureConfigBlock>? SecurityPostureConfig
    {
        get => GetArgument<TerraformList<GoogleGkeHubFleetDefaultClusterConfigBlockSecurityPostureConfigBlock>>("security_posture_config");
        set => SetArgument("security_posture_config", value);
    }

}

/// <summary>
/// Block type for binary_authorization_config in GoogleGkeHubFleetDefaultClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFleetDefaultClusterConfigBlockBinaryAuthorizationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "binary_authorization_config";

    /// <summary>
    /// Mode of operation for binauthz policy evaluation. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;POLICY_BINDINGS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EvaluationMode
    {
        get => GetArgument<TerraformValue<string>>("evaluation_mode");
        set => SetArgument("evaluation_mode", value);
    }

    /// <summary>
    /// PolicyBindings block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeHubFleetDefaultClusterConfigBlockBinaryAuthorizationConfigBlockPolicyBindingsBlock>? PolicyBindings
    {
        get => GetArgument<TerraformList<GoogleGkeHubFleetDefaultClusterConfigBlockBinaryAuthorizationConfigBlockPolicyBindingsBlock>>("policy_bindings");
        set => SetArgument("policy_bindings", value);
    }

}

/// <summary>
/// Block type for policy_bindings in GoogleGkeHubFleetDefaultClusterConfigBlockBinaryAuthorizationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFleetDefaultClusterConfigBlockBinaryAuthorizationConfigBlockPolicyBindingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_bindings";

    /// <summary>
    /// The relative resource name of the binauthz platform policy to audit. GKE
    /// platform policies have the following format:
    /// &#39;projects/{project_number}/platforms/gke/policies/{policy_id}&#39;.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for security_posture_config in GoogleGkeHubFleetDefaultClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFleetDefaultClusterConfigBlockSecurityPostureConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_posture_config";

    /// <summary>
    /// Sets which mode to use for Security Posture features. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;BASIC&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Sets which mode to use for vulnerability scanning. Possible values: [&amp;quot;VULNERABILITY_DISABLED&amp;quot;, &amp;quot;VULNERABILITY_BASIC&amp;quot;, &amp;quot;VULNERABILITY_ENTERPRISE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? VulnerabilityMode
    {
        get => GetArgument<TerraformValue<string>>("vulnerability_mode");
        set => SetArgument("vulnerability_mode", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGkeHubFleet.
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubFleetTimeoutsBlock : TerraformBlock
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
/// Represents a google_gke_hub_fleet Terraform resource.
/// Manages a google_gke_hub_fleet resource.
/// </summary>
public partial class GoogleGkeHubFleet(string name) : TerraformResource("google_gke_hub_fleet", name)
{
    /// <summary>
    /// A user-assigned display name of the Fleet. When present, it must be between 4 to 30 characters.
    /// Allowed characters are: lowercase and uppercase letters, numbers, hyphen, single-quote, double-quote, space, and exclamation point.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The time the fleet was created, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The time the fleet was deleted, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> DeleteTime
        => AsReference("delete_time");

    /// <summary>
    /// The state of the fleet resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> State
        => AsReference("state");

    /// <summary>
    /// Google-generated UUID for this resource. This is unique across all
    /// Fleet resources. If a Fleet resource is deleted and another
    /// resource with the same name is created, it gets a different uid.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// The time the fleet was last updated, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// DefaultClusterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultClusterConfig block(s) allowed")]
    public TerraformList<GoogleGkeHubFleetDefaultClusterConfigBlock>? DefaultClusterConfig
    {
        get => GetArgument<TerraformList<GoogleGkeHubFleetDefaultClusterConfigBlock>>("default_cluster_config");
        set => SetArgument("default_cluster_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeHubFleetTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeHubFleetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
