using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for application_endpoint in GoogleBeyondcorpAppConnection.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpAppConnectionApplicationEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_endpoint";

    /// <summary>
    /// Hostname or IP address of the remote application endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// Port of the remote application endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

}


/// <summary>
/// Block type for gateway in GoogleBeyondcorpAppConnection.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpAppConnectionGatewayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gateway";

    /// <summary>
    /// AppGateway name in following format: projects/{project_id}/locations/{locationId}/appgateways/{gateway_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppGateway is required")]
    public required TerraformValue<string> AppGateway
    {
        get => new TerraformReference<string>(this, "app_gateway");
        set => SetArgument("app_gateway", value);
    }

    /// <summary>
    /// Ingress port reserved on the gateways for this AppConnection, if not specified or zero, the default port is 19443.
    /// </summary>
    public TerraformValue<double> IngressPort
    {
        get => new TerraformReference<double>(this, "ingress_port");
    }

    /// <summary>
    /// The type of hosting used by the gateway. Refer to
    /// https://cloud.google.com/beyondcorp/docs/reference/rest/v1/projects.locations.appConnections#Type_1
    /// for a list of possible values.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Server-defined URI for this resource.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
    }

}


/// <summary>
/// Block type for timeouts in GoogleBeyondcorpAppConnection.
/// Nesting mode: single
/// </summary>
public class GoogleBeyondcorpAppConnectionTimeoutsBlock : TerraformBlock
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
/// Represents a google_beyondcorp_app_connection Terraform resource.
/// Manages a google_beyondcorp_app_connection resource.
/// </summary>
public partial class GoogleBeyondcorpAppConnection(string name) : TerraformResource("google_beyondcorp_app_connection", name)
{
    /// <summary>
    /// List of AppConnectors that are authorised to be associated with this AppConnection
    /// </summary>
    public TerraformList<string>? Connectors
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "connectors").ResolveNodes(ctx));
        set => SetArgument("connectors", value);
    }

    /// <summary>
    /// An arbitrary user-provided name for the AppConnection.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// Resource labels to represent user provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// ID of the AppConnection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The region of the AppConnection.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The type of network connectivity used by the AppConnection. Refer
    /// to https://cloud.google.com/beyondcorp/docs/reference/rest/v1/projects.locations.appConnections#type
    /// for a list of possible values.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// ApplicationEndpoint block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationEndpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApplicationEndpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationEndpoint block(s) allowed")]
    public required TerraformList<GoogleBeyondcorpAppConnectionApplicationEndpointBlock> ApplicationEndpoint
    {
        get => GetRequiredArgument<TerraformList<GoogleBeyondcorpAppConnectionApplicationEndpointBlock>>("application_endpoint");
        set => SetArgument("application_endpoint", value);
    }

    /// <summary>
    /// Gateway block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gateway block(s) allowed")]
    public TerraformList<GoogleBeyondcorpAppConnectionGatewayBlock>? Gateway
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpAppConnectionGatewayBlock>>("gateway");
        set => SetArgument("gateway", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBeyondcorpAppConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBeyondcorpAppConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
