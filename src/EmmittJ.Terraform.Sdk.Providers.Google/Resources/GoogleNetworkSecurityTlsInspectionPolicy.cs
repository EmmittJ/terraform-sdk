using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityTlsInspectionPolicyTimeoutsBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaPool is required")]
    public required TerraformProperty<string> CaPool
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ca_pool");
        set => this.WithProperty("ca_pool", value);
    }

    /// <summary>
    /// List of custom TLS cipher suites selected. This field is valid only if the selected tls_feature_profile is CUSTOM. The compute.SslPoliciesService.ListAvailableFeatures method returns the set of features that can be specified in this list. Note that Secure Web Proxy does not yet honor this field.
    /// </summary>
    public List<TerraformProperty<string>>? CustomTlsFeatures
    {
        get => GetProperty<List<TerraformProperty<string>>>("custom_tls_features");
        set => this.WithProperty("custom_tls_features", value);
    }

    /// <summary>
    /// Free-text description of the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// If FALSE (the default), use our default set of public CAs in addition to any CAs specified in trustConfig. These public CAs are currently based on the Mozilla Root Program and are subject to change over time. If TRUE, do not accept our default set of public CAs. Only CAs specified in trustConfig will be accepted.
    /// </summary>
    public TerraformProperty<bool>? ExcludePublicCaSet
    {
        get => GetProperty<TerraformProperty<bool>>("exclude_public_ca_set");
        set => this.WithProperty("exclude_public_ca_set", value);
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
    /// The location of the tls inspection policy.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Minimum TLS version that the firewall should use when negotiating connections with both clients and servers. If this is not set, then the default value is to allow the broadest set of clients and servers (TLS 1.0 or higher). Setting this to more restrictive values may improve security, but may also prevent the firewall from connecting to some clients or servers. Note that Secure Web Proxy does not yet honor this field. Default value: &amp;quot;TLS_VERSION_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;TLS_VERSION_UNSPECIFIED&amp;quot;, &amp;quot;TLS_1_0&amp;quot;, &amp;quot;TLS_1_1&amp;quot;, &amp;quot;TLS_1_2&amp;quot;, &amp;quot;TLS_1_3&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? MinTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("min_tls_version");
        set => this.WithProperty("min_tls_version", value);
    }

    /// <summary>
    /// Short name of the TlsInspectionPolicy resource to be created.
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
    /// The selected Profile. If this is not set, then the default value is to allow the broadest set of clients and servers (\&amp;quot;PROFILE_COMPATIBLE\&amp;quot;). Setting this to more restrictive values may improve security, but may also prevent the TLS inspection proxy from connecting to some clients or servers. Note that Secure Web Proxy does not yet honor this field. Default value: &amp;quot;PROFILE_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;PROFILE_UNSPECIFIED&amp;quot;, &amp;quot;PROFILE_COMPATIBLE&amp;quot;, &amp;quot;PROFILE_MODERN&amp;quot;, &amp;quot;PROFILE_RESTRICTED&amp;quot;, &amp;quot;PROFILE_CUSTOM&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? TlsFeatureProfile
    {
        get => GetProperty<TerraformProperty<string>>("tls_feature_profile");
        set => this.WithProperty("tls_feature_profile", value);
    }

    /// <summary>
    /// A TrustConfig resource used when making a connection to the TLS server. This is a relative resource path following the form \&amp;quot;projects/{project}/locations/{location}/trustConfigs/{trust_config}\&amp;quot;. This is necessary to intercept TLS connections to servers with certificates signed by a private CA or self-signed certificates. Trust config and the TLS inspection policy must be in the same region. Note that Secure Web Proxy does not yet honor this field.
    /// </summary>
    public TerraformProperty<string>? TrustConfig
    {
        get => GetProperty<TerraformProperty<string>>("trust_config");
        set => this.WithProperty("trust_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkSecurityTlsInspectionPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetworkSecurityTlsInspectionPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
