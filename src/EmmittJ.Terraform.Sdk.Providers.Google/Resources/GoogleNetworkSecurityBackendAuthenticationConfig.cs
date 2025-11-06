using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_network_security_backend_authentication_config resource.
/// </summary>
public class GoogleNetworkSecurityBackendAuthenticationConfig : TerraformResource
{
    public GoogleNetworkSecurityBackendAuthenticationConfig(string name) : base("google_network_security_backend_authentication_config", name)
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
    /// Reference to a Certificate resource from the certificatemanager.googleapis.com namespace.
    /// Used by a BackendService to negotiate mTLS when the backend connection uses TLS and the backend requests a client certificate. Must have a CLIENT_AUTH scope.
    /// </summary>
    public string? ClientCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate")?.Value;
        set => this.WithProperty("client_certificate", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Set of label tags associated with the BackendAuthenticationConfig resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The location of the backend authentication config.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the BackendAuthenticationConfig resource.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Reference to a TrustConfig resource from the certificatemanager.googleapis.com namespace.
    /// A BackendService uses the chain of trust represented by this TrustConfig, if specified, to validate the server certificates presented by the backend. Required unless wellKnownRoots is set to PUBLIC_ROOTS.
    /// </summary>
    public string? TrustConfig
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_config")?.Value;
        set => this.WithProperty("trust_config", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Well known roots to use for server certificate validation. If set to NONE, the BackendService will only validate server certificates against roots specified in TrustConfig.
    /// If set to PUBLIC_ROOTS, the BackendService uses a set of well-known public roots, in addition to any roots specified in the trustConfig field, when validating the server certificates presented by the backend.
    /// Validation with these roots is only considered when the TlsSettings.sni field in the BackendService is set. The well-known roots are a set of root CAs managed by Google. CAs in this set can be added or removed without notice. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PUBLIC_ROOTS&amp;quot;]
    /// </summary>
    public string? WellKnownRoots
    {
        get => GetProperty<TerraformLiteralProperty<string>>("well_known_roots")?.Value;
        set => this.WithProperty("well_known_roots", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Time the BackendAuthenticationConfig was created in UTC.
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
    /// Time the BackendAuthenticationConfig was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
