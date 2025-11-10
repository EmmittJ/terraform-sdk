using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for mtls_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlock : TerraformBlock
{
    /// <summary>
    /// When the client presents an invalid certificate or no certificate to the load balancer, the clientValidationMode specifies how the client connection is handled.
    /// Required if the policy is to be used with the external HTTPS load balancing. For Traffic Director it must be empty. Possible values: [&amp;quot;CLIENT_VALIDATION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;ALLOW_INVALID_OR_MISSING_CLIENT_CERT&amp;quot;, &amp;quot;REJECT_INVALID&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ClientValidationMode
    {
        get => GetProperty<TerraformProperty<string>>("client_validation_mode");
        set => WithProperty("client_validation_mode", value);
    }

    /// <summary>
    /// Reference to the TrustConfig from certificatemanager.googleapis.com namespace.
    /// If specified, the chain validation will be performed against certificates configured in the given TrustConfig.
    /// Allowed only if the policy is to be used with external HTTPS load balancers.
    /// </summary>
    public TerraformProperty<string>? ClientValidationTrustConfig
    {
        get => GetProperty<TerraformProperty<string>>("client_validation_trust_config");
        set => WithProperty("client_validation_trust_config", value);
    }

}

/// <summary>
/// Block type for server_certificate in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyServerCertificateBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_security_server_tls_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkSecurityServerTlsPolicy : TerraformResource
{
    public GoogleNetworkSecurityServerTlsPolicy(string name) : base("google_network_security_server_tls_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("effective_labels");
        this.WithOutput("terraform_labels");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// This field applies only for Traffic Director policies. It is must be set to false for external HTTPS load balancer policies.
    /// Determines if server allows plaintext connections. If set to true, server allows plain text connections. By default, it is set to false. This setting is not exclusive of other encryption modes. For example, if allowOpen and mtlsPolicy are set, server allows both plain text and mTLS connections. See documentation of other encryption modes to confirm compatibility.
    /// Consider using it if you wish to upgrade in place your deployment to TLS while having mixed TLS and non-TLS traffic reaching port :80.
    /// </summary>
    public TerraformProperty<bool>? AllowOpen
    {
        get => GetProperty<TerraformProperty<bool>>("allow_open");
        set => this.WithProperty("allow_open", value);
    }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Set of label tags associated with the ServerTlsPolicy resource.
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
    /// The location of the server tls policy.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Name of the ServerTlsPolicy resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// Block for mtls_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MtlsPolicy block(s) allowed")]
    public List<GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlock>? MtlsPolicy
    {
        get => GetProperty<List<GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlock>>("mtls_policy");
        set => this.WithProperty("mtls_policy", value);
    }

    /// <summary>
    /// Block for server_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerCertificate block(s) allowed")]
    public List<GoogleNetworkSecurityServerTlsPolicyServerCertificateBlock>? ServerCertificate
    {
        get => GetProperty<List<GoogleNetworkSecurityServerTlsPolicyServerCertificateBlock>>("server_certificate");
        set => this.WithProperty("server_certificate", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkSecurityServerTlsPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetworkSecurityServerTlsPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Time the ServerTlsPolicy was created in UTC.
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
    /// Time the ServerTlsPolicy was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
