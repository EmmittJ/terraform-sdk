using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for application_endpoint in .
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpAppConnectionApplicationEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Hostname or IP address of the remote application endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformProperty<string> Host
    {
        get => GetProperty<TerraformProperty<string>>("host");
        set => WithProperty("host", value);
    }

    /// <summary>
    /// Port of the remote application endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

}

/// <summary>
/// Block type for gateway in .
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpAppConnectionGatewayBlock : TerraformBlock
{
    /// <summary>
    /// AppGateway name in following format: projects/{project_id}/locations/{locationId}/appgateways/{gateway_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppGateway is required")]
    public required TerraformProperty<string> AppGateway
    {
        get => GetProperty<TerraformProperty<string>>("app_gateway");
        set => WithProperty("app_gateway", value);
    }

    /// <summary>
    /// Ingress port reserved on the gateways for this AppConnection, if not specified or zero, the default port is 19443.
    /// </summary>
    public TerraformProperty<double>? IngressPort
    {
        get => GetProperty<TerraformProperty<double>>("ingress_port");
        set => WithProperty("ingress_port", value);
    }

    /// <summary>
    /// The type of hosting used by the gateway. Refer to
    /// https://cloud.google.com/beyondcorp/docs/reference/rest/v1/projects.locations.appConnections#Type_1
    /// for a list of possible values.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// Server-defined URI for this resource.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBeyondcorpAppConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_beyondcorp_app_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBeyondcorpAppConnection : TerraformResource
{
    public GoogleBeyondcorpAppConnection(string name) : base("google_beyondcorp_app_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// List of AppConnectors that are authorised to be associated with this AppConnection
    /// </summary>
    public List<TerraformProperty<string>>? Connectors
    {
        get => GetProperty<List<TerraformProperty<string>>>("connectors");
        set => this.WithProperty("connectors", value);
    }

    /// <summary>
    /// An arbitrary user-provided name for the AppConnection.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// ID of the AppConnection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region of the AppConnection.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The type of network connectivity used by the AppConnection. Refer
    /// to https://cloud.google.com/beyondcorp/docs/reference/rest/v1/projects.locations.appConnections#type
    /// for a list of possible values.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for application_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApplicationEndpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationEndpoint block(s) allowed")]
    public List<GoogleBeyondcorpAppConnectionApplicationEndpointBlock>? ApplicationEndpoint
    {
        get => GetProperty<List<GoogleBeyondcorpAppConnectionApplicationEndpointBlock>>("application_endpoint");
        set => this.WithProperty("application_endpoint", value);
    }

    /// <summary>
    /// Block for gateway.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gateway block(s) allowed")]
    public List<GoogleBeyondcorpAppConnectionGatewayBlock>? Gateway
    {
        get => GetProperty<List<GoogleBeyondcorpAppConnectionGatewayBlock>>("gateway");
        set => this.WithProperty("gateway", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBeyondcorpAppConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBeyondcorpAppConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
