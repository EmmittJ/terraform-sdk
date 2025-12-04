using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkServicesAuthzExtension.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesAuthzExtensionTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_services_authz_extension Terraform resource.
/// Manages a google_network_services_authz_extension resource.
/// </summary>
public partial class GoogleNetworkServicesAuthzExtension(string name) : TerraformResource("google_network_services_authz_extension", name)
{
    /// <summary>
    /// The :authority header in the gRPC request sent from Envoy to the extension service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authority is required")]
    public required TerraformValue<string> Authority
    {
        get => GetArgument<TerraformValue<string>>("authority");
        set => SetArgument("authority", value);
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Determines how the proxy behaves if the call to the extension fails or times out.
    /// When set to TRUE, request or response processing continues without error. Any subsequent extensions in the extension chain are also executed. When set to FALSE or the default setting of FALSE is used, one of the following happens:
    /// * If response headers have not been delivered to the downstream client, a generic 500 error is returned to the client. The error response can be tailored by configuring a custom error response in the load balancer.
    /// * If response headers have been delivered, then the HTTP stream to the downstream client is reset.
    /// </summary>
    public TerraformValue<bool>? FailOpen
    {
        get => GetArgument<TerraformValue<bool>>("fail_open");
        set => SetArgument("fail_open", value);
    }

    /// <summary>
    /// List of the HTTP headers to forward to the extension (from the client). If omitted, all headers are sent. Each element is a string indicating the header name.
    /// </summary>
    public TerraformList<string>? ForwardHeaders
    {
        get => GetArgument<TerraformList<string>>("forward_headers");
        set => SetArgument("forward_headers", value);
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
    /// Set of labels associated with the AuthzExtension resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// All backend services and forwarding rules referenced by this extension must share the same load balancing scheme.
    /// For more information, refer to [Backend services overview](https://cloud.google.com/load-balancing/docs/backend-service). Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingScheme is required")]
    public required TerraformValue<string> LoadBalancingScheme
    {
        get => GetArgument<TerraformValue<string>>("load_balancing_scheme");
        set => SetArgument("load_balancing_scheme", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The metadata provided here is included as part of the metadata_context (of type google.protobuf.Struct) in the ProcessingRequest message sent to the extension server. The metadata is available under the namespace com.google.authz_extension.&amp;lt;resourceName&amp;gt;. The following variables are supported in the metadata Struct:
    /// 
    /// {forwarding_rule_id} - substituted with the forwarding rule&#39;s fully qualified resource name.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Identifier. Name of the AuthzExtension resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The reference to the service that runs the extension.
    /// To configure a callout extension, service must be a fully-qualified reference to a [backend service](https://cloud.google.com/compute/docs/reference/rest/v1/backendServices) in the format:
    /// https://www.googleapis.com/compute/v1/projects/{project}/regions/{region}/backendServices/{backendService} or https://www.googleapis.com/compute/v1/projects/{project}/global/backendServices/{backendService}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// Specifies the timeout for each individual message on the stream. The timeout must be between 10-10000 milliseconds.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    public required TerraformValue<string> Timeout
    {
        get => GetArgument<TerraformValue<string>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The format of communication supported by the callout extension. Will be set to EXT_PROC_GRPC by the backend if no value is set. Possible values: [&amp;quot;WIRE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;EXT_PROC_GRPC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? WireFormat
    {
        get => GetArgument<TerraformValue<string>>("wire_format");
        set => SetArgument("wire_format", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkServicesAuthzExtensionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkServicesAuthzExtensionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
