using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesAuthzExtensionTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_services_authz_extension resource.
/// </summary>
public class GoogleNetworkServicesAuthzExtension : TerraformResource
{
    public GoogleNetworkServicesAuthzExtension(string name) : base("google_network_services_authz_extension", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The :authority header in the gRPC request sent from Envoy to the extension service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authority is required")]
    public required TerraformProperty<string> Authority
    {
        get => GetProperty<TerraformProperty<string>>("authority");
        set => this.WithProperty("authority", value);
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Determines how the proxy behaves if the call to the extension fails or times out.
    /// When set to TRUE, request or response processing continues without error. Any subsequent extensions in the extension chain are also executed. When set to FALSE or the default setting of FALSE is used, one of the following happens:
    /// * If response headers have not been delivered to the downstream client, a generic 500 error is returned to the client. The error response can be tailored by configuring a custom error response in the load balancer.
    /// * If response headers have been delivered, then the HTTP stream to the downstream client is reset.
    /// </summary>
    public TerraformProperty<bool>? FailOpen
    {
        get => GetProperty<TerraformProperty<bool>>("fail_open");
        set => this.WithProperty("fail_open", value);
    }

    /// <summary>
    /// List of the HTTP headers to forward to the extension (from the client). If omitted, all headers are sent. Each element is a string indicating the header name.
    /// </summary>
    public List<TerraformProperty<string>>? ForwardHeaders
    {
        get => GetProperty<List<TerraformProperty<string>>>("forward_headers");
        set => this.WithProperty("forward_headers", value);
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
    /// Set of labels associated with the AuthzExtension resource.
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
    /// All backend services and forwarding rules referenced by this extension must share the same load balancing scheme.
    /// For more information, refer to [Backend services overview](https://cloud.google.com/load-balancing/docs/backend-service). Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingScheme is required")]
    public required TerraformProperty<string> LoadBalancingScheme
    {
        get => GetProperty<TerraformProperty<string>>("load_balancing_scheme");
        set => this.WithProperty("load_balancing_scheme", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The metadata provided here is included as part of the metadata_context (of type google.protobuf.Struct) in the ProcessingRequest message sent to the extension server. The metadata is available under the namespace com.google.authz_extension.&amp;lt;resourceName&amp;gt;. The following variables are supported in the metadata Struct:
    /// 
    /// {forwarding_rule_id} - substituted with the forwarding rule&#39;s fully qualified resource name.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// Identifier. Name of the AuthzExtension resource.
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
    /// The reference to the service that runs the extension.
    /// To configure a callout extension, service must be a fully-qualified reference to a [backend service](https://cloud.google.com/compute/docs/reference/rest/v1/backendServices) in the format:
    /// https://www.googleapis.com/compute/v1/projects/{project}/regions/{region}/backendServices/{backendService} or https://www.googleapis.com/compute/v1/projects/{project}/global/backendServices/{backendService}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// Specifies the timeout for each individual message on the stream. The timeout must be between 10-10000 milliseconds.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    public required TerraformProperty<string> Timeout
    {
        get => GetProperty<TerraformProperty<string>>("timeout");
        set => this.WithProperty("timeout", value);
    }

    /// <summary>
    /// The format of communication supported by the callout extension. Will be set to EXT_PROC_GRPC by the backend if no value is set. Possible values: [&amp;quot;WIRE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;EXT_PROC_GRPC&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? WireFormat
    {
        get => GetProperty<TerraformProperty<string>>("wire_format");
        set => this.WithProperty("wire_format", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkServicesAuthzExtensionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetworkServicesAuthzExtensionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
