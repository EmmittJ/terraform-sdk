using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in GoogleApphubService.
/// Nesting mode: list
/// </summary>
public class GoogleApphubServiceAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attributes";

    /// <summary>
    /// BusinessOwners block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApphubServiceAttributesBlockBusinessOwnersBlock>? BusinessOwners
    {
        get => GetArgument<TerraformList<GoogleApphubServiceAttributesBlockBusinessOwnersBlock>>("business_owners");
        set => SetArgument("business_owners", value);
    }

    /// <summary>
    /// Criticality block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Criticality block(s) allowed")]
    public TerraformList<GoogleApphubServiceAttributesBlockCriticalityBlock>? Criticality
    {
        get => GetArgument<TerraformList<GoogleApphubServiceAttributesBlockCriticalityBlock>>("criticality");
        set => SetArgument("criticality", value);
    }

    /// <summary>
    /// DeveloperOwners block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApphubServiceAttributesBlockDeveloperOwnersBlock>? DeveloperOwners
    {
        get => GetArgument<TerraformList<GoogleApphubServiceAttributesBlockDeveloperOwnersBlock>>("developer_owners");
        set => SetArgument("developer_owners", value);
    }

    /// <summary>
    /// Environment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    public TerraformList<GoogleApphubServiceAttributesBlockEnvironmentBlock>? Environment
    {
        get => GetArgument<TerraformList<GoogleApphubServiceAttributesBlockEnvironmentBlock>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// OperatorOwners block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApphubServiceAttributesBlockOperatorOwnersBlock>? OperatorOwners
    {
        get => GetArgument<TerraformList<GoogleApphubServiceAttributesBlockOperatorOwnersBlock>>("operator_owners");
        set => SetArgument("operator_owners", value);
    }

}

/// <summary>
/// Block type for business_owners in GoogleApphubServiceAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubServiceAttributesBlockBusinessOwnersBlock : TerraformBlock
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
    /// Required. Email address of the contacts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

}

/// <summary>
/// Block type for criticality in GoogleApphubServiceAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubServiceAttributesBlockCriticalityBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for developer_owners in GoogleApphubServiceAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubServiceAttributesBlockDeveloperOwnersBlock : TerraformBlock
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
    /// Required. Email address of the contacts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

}

/// <summary>
/// Block type for environment in GoogleApphubServiceAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubServiceAttributesBlockEnvironmentBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for operator_owners in GoogleApphubServiceAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubServiceAttributesBlockOperatorOwnersBlock : TerraformBlock
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
    /// Required. Email address of the contacts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApphubService.
/// Nesting mode: single
/// </summary>
public class GoogleApphubServiceTimeoutsBlock : TerraformBlock
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
/// Represents a google_apphub_service Terraform resource.
/// Manages a google_apphub_service resource.
/// </summary>
public partial class GoogleApphubService(string name) : TerraformResource("google_apphub_service", name)
{
    /// <summary>
    /// Part of &#39;parent&#39;.  Full resource name of a parent Application. Example: projects/{HOST_PROJECT_ID}/locations/{LOCATION}/applications/{APPLICATION_ID}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// User-defined description of a Service.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Immutable. The resource name of the original discovered service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiscoveredService is required")]
    public required TerraformValue<string> DiscoveredService
    {
        get => GetArgument<TerraformValue<string>>("discovered_service");
        set => SetArgument("discovered_service", value);
    }

    /// <summary>
    /// User-defined name for the Service.
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
    /// Part of &#39;parent&#39;.  Full resource name of a parent Application. Example: projects/{HOST_PROJECT_ID}/locations/{LOCATION}/applications/{APPLICATION_ID}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The Service identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    public required TerraformValue<string> ServiceId
    {
        get => GetArgument<TerraformValue<string>>("service_id");
        set => SetArgument("service_id", value);
    }

    /// <summary>
    /// Output only. Create time.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Identifier. The resource name of a Service. Format:
    /// &amp;quot;projects/{host-project-id}/locations/{location}/applications/{application-id}/services/{service-id}&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Properties of an underlying cloud resource that can comprise a Service.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceProperties
        => AsReference("service_properties");

    /// <summary>
    /// Reference to an underlying networking resource that can comprise a Service.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceReference
        => AsReference("service_reference");

    /// <summary>
    /// Output only. Service state. Possible values: STATE_UNSPECIFIED CREATING ACTIVE DELETING DETACHED
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Output only. A universally unique identifier (UUID) for the &#39;Service&#39; in the UUID4
    /// format.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Output only. Update time.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Attributes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Attributes block(s) allowed")]
    public TerraformList<GoogleApphubServiceAttributesBlock>? Attributes
    {
        get => GetArgument<TerraformList<GoogleApphubServiceAttributesBlock>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApphubServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApphubServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
