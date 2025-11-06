using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_network_security_tls_inspection_policy resource.
/// </summary>
public class GoogleNetworkSecurityTlsInspectionPolicy : TerraformResource
{
    public GoogleNetworkSecurityTlsInspectionPolicy(string name) : base("google_network_security_tls_inspection_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// A CA pool resource used to issue interception certificates.
    /// </summary>
    public string? CaPool
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ca_pool")?.Value;
        set => this.WithProperty("ca_pool", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// List of custom TLS cipher suites selected. This field is valid only if the selected tls_feature_profile is CUSTOM. The compute.SslPoliciesService.ListAvailableFeatures method returns the set of features that can be specified in this list. Note that Secure Web Proxy does not yet honor this field.
    /// </summary>
    public List<string>? CustomTlsFeatures
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("custom_tls_features")?.Value;
        set => this.WithProperty("custom_tls_features", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Free-text description of the resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If FALSE (the default), use our default set of public CAs in addition to any CAs specified in trustConfig. These public CAs are currently based on the Mozilla Root Program and are subject to change over time. If TRUE, do not accept our default set of public CAs. Only CAs specified in trustConfig will be accepted.
    /// </summary>
    public bool? ExcludePublicCaSet
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_public_ca_set")?.Value;
        set => this.WithProperty("exclude_public_ca_set", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The location of the tls inspection policy.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Minimum TLS version that the firewall should use when negotiating connections with both clients and servers. If this is not set, then the default value is to allow the broadest set of clients and servers (TLS 1.0 or higher). Setting this to more restrictive values may improve security, but may also prevent the firewall from connecting to some clients or servers. Note that Secure Web Proxy does not yet honor this field. Default value: &amp;quot;TLS_VERSION_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;TLS_VERSION_UNSPECIFIED&amp;quot;, &amp;quot;TLS_1_0&amp;quot;, &amp;quot;TLS_1_1&amp;quot;, &amp;quot;TLS_1_2&amp;quot;, &amp;quot;TLS_1_3&amp;quot;]
    /// </summary>
    public string? MinTlsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("min_tls_version")?.Value;
        set => this.WithProperty("min_tls_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Short name of the TlsInspectionPolicy resource to be created.
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
    /// The selected Profile. If this is not set, then the default value is to allow the broadest set of clients and servers (\&amp;quot;PROFILE_COMPATIBLE\&amp;quot;). Setting this to more restrictive values may improve security, but may also prevent the TLS inspection proxy from connecting to some clients or servers. Note that Secure Web Proxy does not yet honor this field. Default value: &amp;quot;PROFILE_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;PROFILE_UNSPECIFIED&amp;quot;, &amp;quot;PROFILE_COMPATIBLE&amp;quot;, &amp;quot;PROFILE_MODERN&amp;quot;, &amp;quot;PROFILE_RESTRICTED&amp;quot;, &amp;quot;PROFILE_CUSTOM&amp;quot;]
    /// </summary>
    public string? TlsFeatureProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tls_feature_profile")?.Value;
        set => this.WithProperty("tls_feature_profile", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A TrustConfig resource used when making a connection to the TLS server. This is a relative resource path following the form \&amp;quot;projects/{project}/locations/{location}/trustConfigs/{trust_config}\&amp;quot;. This is necessary to intercept TLS connections to servers with certificates signed by a private CA or self-signed certificates. Trust config and the TLS inspection policy must be in the same region. Note that Secure Web Proxy does not yet honor this field.
    /// </summary>
    public string? TrustConfig
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_config")?.Value;
        set => this.WithProperty("trust_config", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
