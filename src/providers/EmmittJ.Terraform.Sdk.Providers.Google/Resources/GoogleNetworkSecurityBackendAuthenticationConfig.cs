using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkSecurityBackendAuthenticationConfig.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityBackendAuthenticationConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_security_backend_authentication_config Terraform resource.
/// Manages a google_network_security_backend_authentication_config resource.
/// </summary>
public partial class GoogleNetworkSecurityBackendAuthenticationConfig(string name) : TerraformResource("google_network_security_backend_authentication_config", name)
{
    /// <summary>
    /// Reference to a Certificate resource from the certificatemanager.googleapis.com namespace.
    /// Used by a BackendService to negotiate mTLS when the backend connection uses TLS and the backend requests a client certificate. Must have a CLIENT_AUTH scope.
    /// </summary>
    public TerraformValue<string>? ClientCertificate
    {
        get => GetArgument<TerraformValue<string>>("client_certificate");
        set => SetArgument("client_certificate", value);
    }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// Set of label tags associated with the BackendAuthenticationConfig resource.
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
    /// The location of the backend authentication config.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the BackendAuthenticationConfig resource.
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
    /// Reference to a TrustConfig resource from the certificatemanager.googleapis.com namespace.
    /// A BackendService uses the chain of trust represented by this TrustConfig, if specified, to validate the server certificates presented by the backend. Required unless wellKnownRoots is set to PUBLIC_ROOTS.
    /// </summary>
    public TerraformValue<string>? TrustConfig
    {
        get => GetArgument<TerraformValue<string>>("trust_config");
        set => SetArgument("trust_config", value);
    }

    /// <summary>
    /// Well known roots to use for server certificate validation. If set to NONE, the BackendService will only validate server certificates against roots specified in TrustConfig.
    /// If set to PUBLIC_ROOTS, the BackendService uses a set of well-known public roots, in addition to any roots specified in the trustConfig field, when validating the server certificates presented by the backend.
    /// Validation with these roots is only considered when the TlsSettings.sni field in the BackendService is set. The well-known roots are a set of root CAs managed by Google. CAs in this set can be added or removed without notice. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PUBLIC_ROOTS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? WellKnownRoots
    {
        get => GetArgument<TerraformValue<string>>("well_known_roots");
        set => SetArgument("well_known_roots", value);
    }

    /// <summary>
    /// Time the BackendAuthenticationConfig was created in UTC.
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
    /// Time the BackendAuthenticationConfig was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkSecurityBackendAuthenticationConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkSecurityBackendAuthenticationConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
