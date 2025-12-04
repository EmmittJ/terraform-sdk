using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in GoogleApphubApplication.
/// Nesting mode: list
/// </summary>
public class GoogleApphubApplicationAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attributes";

    /// <summary>
    /// BusinessOwners block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApphubApplicationAttributesBlockBusinessOwnersBlock>? BusinessOwners
    {
        get => GetArgument<TerraformList<GoogleApphubApplicationAttributesBlockBusinessOwnersBlock>>("business_owners");
        set => SetArgument("business_owners", value);
    }

    /// <summary>
    /// Criticality block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Criticality block(s) allowed")]
    public TerraformList<GoogleApphubApplicationAttributesBlockCriticalityBlock>? Criticality
    {
        get => GetArgument<TerraformList<GoogleApphubApplicationAttributesBlockCriticalityBlock>>("criticality");
        set => SetArgument("criticality", value);
    }

    /// <summary>
    /// DeveloperOwners block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApphubApplicationAttributesBlockDeveloperOwnersBlock>? DeveloperOwners
    {
        get => GetArgument<TerraformList<GoogleApphubApplicationAttributesBlockDeveloperOwnersBlock>>("developer_owners");
        set => SetArgument("developer_owners", value);
    }

    /// <summary>
    /// Environment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    public TerraformList<GoogleApphubApplicationAttributesBlockEnvironmentBlock>? Environment
    {
        get => GetArgument<TerraformList<GoogleApphubApplicationAttributesBlockEnvironmentBlock>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// OperatorOwners block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApphubApplicationAttributesBlockOperatorOwnersBlock>? OperatorOwners
    {
        get => GetArgument<TerraformList<GoogleApphubApplicationAttributesBlockOperatorOwnersBlock>>("operator_owners");
        set => SetArgument("operator_owners", value);
    }

}

/// <summary>
/// Block type for business_owners in GoogleApphubApplicationAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubApplicationAttributesBlockBusinessOwnersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "business_owners";

    /// <summary>
    /// Optional. Contact&#39;s name.
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
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

}

/// <summary>
/// Block type for criticality in GoogleApphubApplicationAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubApplicationAttributesBlockCriticalityBlock : TerraformBlock
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
/// Block type for developer_owners in GoogleApphubApplicationAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubApplicationAttributesBlockDeveloperOwnersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "developer_owners";

    /// <summary>
    /// Optional. Contact&#39;s name.
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
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

}

/// <summary>
/// Block type for environment in GoogleApphubApplicationAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubApplicationAttributesBlockEnvironmentBlock : TerraformBlock
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
/// Block type for operator_owners in GoogleApphubApplicationAttributesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApphubApplicationAttributesBlockOperatorOwnersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operator_owners";

    /// <summary>
    /// Optional. Contact&#39;s name.
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
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

}


/// <summary>
/// Block type for scope in GoogleApphubApplication.
/// Nesting mode: list
/// </summary>
public class GoogleApphubApplicationScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scope";

    /// <summary>
    /// Required. Scope Type. 
    ///  Possible values:
    /// REGIONAL
    /// GLOBAL Possible values: [&amp;quot;REGIONAL&amp;quot;, &amp;quot;GLOBAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApphubApplication.
/// Nesting mode: single
/// </summary>
public class GoogleApphubApplicationTimeoutsBlock : TerraformBlock
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
/// Represents a google_apphub_application Terraform resource.
/// Manages a google_apphub_application resource.
/// </summary>
public partial class GoogleApphubApplication(string name) : TerraformResource("google_apphub_application", name)
{
    /// <summary>
    /// Required. The Application identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// Optional. User-defined description of an Application.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Optional. User-defined name for the Application.
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
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
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. Create time.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Identifier. The resource name of an Application. Format:
    /// &amp;quot;projects/{host-project-id}/locations/{location}/applications/{application-id}&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Output only. Application state. 
    ///  Possible values:
    ///  STATE_UNSPECIFIED
    /// CREATING
    /// ACTIVE
    /// DELETING
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Output only. A universally unique identifier (in UUID4 format) for the &#39;Application&#39;.
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
    public TerraformList<GoogleApphubApplicationAttributesBlock>? Attributes
    {
        get => GetArgument<TerraformList<GoogleApphubApplicationAttributesBlock>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// Scope block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Scope block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scope block(s) allowed")]
    public required TerraformList<GoogleApphubApplicationScopeBlock> Scope
    {
        get => GetRequiredArgument<TerraformList<GoogleApphubApplicationScopeBlock>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApphubApplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApphubApplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
