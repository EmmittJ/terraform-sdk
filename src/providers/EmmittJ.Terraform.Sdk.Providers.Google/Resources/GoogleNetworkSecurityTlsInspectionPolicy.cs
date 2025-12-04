using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkSecurityTlsInspectionPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityTlsInspectionPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_security_tls_inspection_policy Terraform resource.
/// Manages a google_network_security_tls_inspection_policy resource.
/// </summary>
public partial class GoogleNetworkSecurityTlsInspectionPolicy(string name) : TerraformResource("google_network_security_tls_inspection_policy", name)
{
    /// <summary>
    /// A CA pool resource used to issue interception certificates.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaPool is required")]
    public required TerraformValue<string> CaPool
    {
        get => GetArgument<TerraformValue<string>>("ca_pool");
        set => SetArgument("ca_pool", value);
    }

    /// <summary>
    /// List of custom TLS cipher suites selected. This field is valid only if the selected tls_feature_profile is CUSTOM. The compute.SslPoliciesService.ListAvailableFeatures method returns the set of features that can be specified in this list. Note that Secure Web Proxy does not yet honor this field.
    /// </summary>
    public TerraformList<string>? CustomTlsFeatures
    {
        get => GetArgument<TerraformList<string>>("custom_tls_features");
        set => SetArgument("custom_tls_features", value);
    }

    /// <summary>
    /// Free-text description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// If FALSE (the default), use our default set of public CAs in addition to any CAs specified in trustConfig. These public CAs are currently based on the Mozilla Root Program and are subject to change over time. If TRUE, do not accept our default set of public CAs. Only CAs specified in trustConfig will be accepted.
    /// </summary>
    public TerraformValue<bool>? ExcludePublicCaSet
    {
        get => GetArgument<TerraformValue<bool>>("exclude_public_ca_set");
        set => SetArgument("exclude_public_ca_set", value);
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
    /// The location of the tls inspection policy.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Minimum TLS version that the firewall should use when negotiating connections with both clients and servers. If this is not set, then the default value is to allow the broadest set of clients and servers (TLS 1.0 or higher). Setting this to more restrictive values may improve security, but may also prevent the firewall from connecting to some clients or servers. Note that Secure Web Proxy does not yet honor this field. Default value: &amp;quot;TLS_VERSION_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;TLS_VERSION_UNSPECIFIED&amp;quot;, &amp;quot;TLS_1_0&amp;quot;, &amp;quot;TLS_1_1&amp;quot;, &amp;quot;TLS_1_2&amp;quot;, &amp;quot;TLS_1_3&amp;quot;]
    /// </summary>
    public TerraformValue<string>? MinTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("min_tls_version");
        set => SetArgument("min_tls_version", value);
    }

    /// <summary>
    /// Short name of the TlsInspectionPolicy resource to be created.
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
    /// The selected Profile. If this is not set, then the default value is to allow the broadest set of clients and servers (\&amp;quot;PROFILE_COMPATIBLE\&amp;quot;). Setting this to more restrictive values may improve security, but may also prevent the TLS inspection proxy from connecting to some clients or servers. Note that Secure Web Proxy does not yet honor this field. Default value: &amp;quot;PROFILE_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;PROFILE_UNSPECIFIED&amp;quot;, &amp;quot;PROFILE_COMPATIBLE&amp;quot;, &amp;quot;PROFILE_MODERN&amp;quot;, &amp;quot;PROFILE_RESTRICTED&amp;quot;, &amp;quot;PROFILE_CUSTOM&amp;quot;]
    /// </summary>
    public TerraformValue<string>? TlsFeatureProfile
    {
        get => GetArgument<TerraformValue<string>>("tls_feature_profile");
        set => SetArgument("tls_feature_profile", value);
    }

    /// <summary>
    /// A TrustConfig resource used when making a connection to the TLS server. This is a relative resource path following the form \&amp;quot;projects/{project}/locations/{location}/trustConfigs/{trust_config}\&amp;quot;. This is necessary to intercept TLS connections to servers with certificates signed by a private CA or self-signed certificates. Trust config and the TLS inspection policy must be in the same region. Note that Secure Web Proxy does not yet honor this field.
    /// </summary>
    public TerraformValue<string>? TrustConfig
    {
        get => GetArgument<TerraformValue<string>>("trust_config");
        set => SetArgument("trust_config", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkSecurityTlsInspectionPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkSecurityTlsInspectionPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
