using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for features in GoogleDialogflowFulfillment.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowFulfillmentFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "features";

    /// <summary>
    /// The type of the feature that enabled for fulfillment.
    /// * SMALLTALK: Fulfillment is enabled for SmallTalk. Possible values: [&amp;quot;SMALLTALK&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for generic_web_service in GoogleDialogflowFulfillment.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowFulfillmentGenericWebServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "generic_web_service";

    /// <summary>
    /// The password for HTTP Basic authentication.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The HTTP request headers to send together with fulfillment requests.
    /// </summary>
    public TerraformMap<string>? RequestHeaders
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "request_headers").ResolveNodes(ctx));
        set => SetArgument("request_headers", value);
    }

    /// <summary>
    /// The fulfillment URI for receiving POST requests. It must use https protocol.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The user name for HTTP Basic authentication.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowFulfillment.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowFulfillmentTimeoutsBlock : TerraformBlock
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
/// Represents a google_dialogflow_fulfillment Terraform resource.
/// Manages a google_dialogflow_fulfillment resource.
/// </summary>
public partial class GoogleDialogflowFulfillment(string name) : TerraformResource("google_dialogflow_fulfillment", name)
{
    /// <summary>
    /// The human-readable name of the fulfillment, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Whether fulfillment is enabled.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The unique identifier of the fulfillment.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/fulfillment - projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent/fulfillment
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Features block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowFulfillmentFeaturesBlock>? Features
    {
        get => GetArgument<TerraformList<GoogleDialogflowFulfillmentFeaturesBlock>>("features");
        set => SetArgument("features", value);
    }

    /// <summary>
    /// GenericWebService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenericWebService block(s) allowed")]
    public TerraformList<GoogleDialogflowFulfillmentGenericWebServiceBlock>? GenericWebService
    {
        get => GetArgument<TerraformList<GoogleDialogflowFulfillmentGenericWebServiceBlock>>("generic_web_service");
        set => SetArgument("generic_web_service", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowFulfillmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowFulfillmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
