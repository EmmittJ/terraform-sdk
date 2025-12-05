using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in GoogleApphubWorkload.
/// Nesting mode: list
/// </summary>
public class GoogleApphubWorkloadAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attributes";

    /// <summary>
    /// BusinessOwners block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApphubWorkloadAttributesBlockBusinessOwnersBlock>? BusinessOwners
    {
        get => GetArgument<TerraformList<GoogleApphubWorkloadAttributesBlockBusinessOwnersBlock>>("business_owners");
        set => SetArgument("business_owners", value);
    }

    /// <summary>
    /// Criticality block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Criticality block(s) allowed")]
    public TerraformList<GoogleApphubWorkloadAttributesBlockCriticalityBlock>? Criticality
    {
        get => GetArgument<TerraformList<GoogleApphubWorkloadAttributesBlockCriticalityBlock>>("criticality");
        set => SetArgument("criticality", value);
    }

    /// <summary>
    /// DeveloperOwners block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApphubWorkloadAttributesBlockDeveloperOwnersBlock>? DeveloperOwners
    {
        get => GetArgument<TerraformList<GoogleApphubWorkloadAttributesBlockDeveloperOwnersBlock>>("developer_owners");
        set => SetArgument("developer_owners", value);
    }

    /// <summary>
    /// Environment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    public TerraformList<GoogleApphubWorkloadAttributesBlockEnvironmentBlock>? Environment
    {
        get => GetArgument<TerraformList<GoogleApphubWorkloadAttributesBlockEnvironmentBlock>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// OperatorOwners block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApphubWorkloadAttributesBlockOperatorOwnersBlock>? OperatorOwners
    {
        get => GetArgument<TerraformList<GoogleApphubWorkloadAttributesBlockOperatorOwnersBlock>>("operator_owners");
        set => SetArgument("operator_owners", value);
    }

}

/// <summary>
/// Block type for business_owners in GoogleApphubWorkloadAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubWorkloadAttributesBlockBusinessOwnersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "business_owners";

    /// <summary>
    /// Contact&#39;s name.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Email address of the contacts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

}

/// <summary>
/// Block type for criticality in GoogleApphubWorkloadAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubWorkloadAttributesBlockCriticalityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "criticality";

    /// <summary>
    /// Criticality type. Possible values: [&amp;quot;MISSION_CRITICAL&amp;quot;, &amp;quot;HIGH&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;LOW&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for developer_owners in GoogleApphubWorkloadAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubWorkloadAttributesBlockDeveloperOwnersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "developer_owners";

    /// <summary>
    /// Contact&#39;s name.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Email address of the contacts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

}

/// <summary>
/// Block type for environment in GoogleApphubWorkloadAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubWorkloadAttributesBlockEnvironmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment";

    /// <summary>
    /// Environment type. Possible values: [&amp;quot;PRODUCTION&amp;quot;, &amp;quot;STAGING&amp;quot;, &amp;quot;TEST&amp;quot;, &amp;quot;DEVELOPMENT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for operator_owners in GoogleApphubWorkloadAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubWorkloadAttributesBlockOperatorOwnersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operator_owners";

    /// <summary>
    /// Contact&#39;s name.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Email address of the contacts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApphubWorkload.
/// Nesting mode: single
/// </summary>
public class GoogleApphubWorkloadTimeoutsBlock : TerraformBlock
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
/// Represents a google_apphub_workload Terraform resource.
/// Manages a google_apphub_workload resource.
/// </summary>
public partial class GoogleApphubWorkload(string name) : TerraformResource("google_apphub_workload", name)
{
    /// <summary>
    /// Part of &#39;parent&#39;.  Full resource name of a parent Application. Example: projects/{HOST_PROJECT_ID}/locations/{LOCATION}/applications/{APPLICATION_ID}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// User-defined description of a Workload.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Immutable. The resource name of the original discovered workload.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiscoveredWorkload is required")]
    public required TerraformValue<string> DiscoveredWorkload
    {
        get => GetRequiredArgument<TerraformValue<string>>("discovered_workload");
        set => SetArgument("discovered_workload", value);
    }

    /// <summary>
    /// User-defined name for the Workload.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// Part of &#39;parent&#39;.  Full resource name of a parent Application. Example: projects/{HOST_PROJECT_ID}/locations/{LOCATION}/applications/{APPLICATION_ID}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Workload identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadId is required")]
    public required TerraformValue<string> WorkloadId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workload_id");
        set => SetArgument("workload_id", value);
    }

    /// <summary>
    /// Output only. Create time.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// Identifier. The resource name of the Workload. Format:&amp;quot;projects/{host-project-id}/locations/{location}/applications/{application-id}/workloads/{workload-id}&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Output only. Workload state. Possible values:  STATE_UNSPECIFIED CREATING ACTIVE DELETING DETACHED
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// Output only. A universally unique identifier (UUID) for the &#39;Workload&#39; in the UUID4 format.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// Output only. Update time.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// Properties of an underlying compute resource represented by the Workload.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadProperties
        => CreateReference("workload_properties");

    /// <summary>
    /// Reference of an underlying compute resource represented by the Workload.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadReference
        => CreateReference("workload_reference");

    /// <summary>
    /// Attributes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Attributes block(s) allowed")]
    public TerraformList<GoogleApphubWorkloadAttributesBlock>? Attributes
    {
        get => GetArgument<TerraformList<GoogleApphubWorkloadAttributesBlock>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApphubWorkloadTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApphubWorkloadTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
