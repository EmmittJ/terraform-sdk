using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionSslPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_region_ssl_policy resource.
/// </summary>
public class GoogleComputeRegionSslPolicy : TerraformResource
{
    public GoogleComputeRegionSslPolicy(string name) : base("google_compute_region_ssl_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("creation_timestamp");
        this.WithOutput("enabled_features");
        this.WithOutput("fingerprint");
        this.WithOutput("self_link");
    }

    /// <summary>
    /// A list of features enabled when the selected profile is CUSTOM. The
    /// method returns the set of features that can be specified in this
    /// list. This field must be empty if the profile is not CUSTOM.
    /// 
    /// See the [official documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport)
    /// for which ciphers are available to use. **Note**: this argument
    /// *must* be present when using the &#39;CUSTOM&#39; profile. This argument
    /// *must not* be present when using any other profile.
    /// </summary>
    public HashSet<TerraformProperty<string>>? CustomFeatures
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("custom_features");
        set => this.WithProperty("custom_features", value);
    }

    /// <summary>
    /// An optional description of this resource.
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
    /// The minimum version of SSL protocol that can be used by the clients
    /// to establish a connection with the load balancer. Default value: &amp;quot;TLS_1_0&amp;quot; Possible values: [&amp;quot;TLS_1_0&amp;quot;, &amp;quot;TLS_1_1&amp;quot;, &amp;quot;TLS_1_2&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? MinTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("min_tls_version");
        set => this.WithProperty("min_tls_version", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Profile specifies the set of SSL features that can be used by the
    /// load balancer when negotiating SSL with clients. If using &#39;CUSTOM&#39;,
    /// the set of SSL features to enable must be specified in the
    /// &#39;customFeatures&#39; field.
    /// 
    /// See the [official documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport)
    /// for information on what cipher suites each profile provides. If
    /// &#39;CUSTOM&#39; is used, the &#39;custom_features&#39; attribute **must be set**. Default value: &amp;quot;COMPATIBLE&amp;quot; Possible values: [&amp;quot;COMPATIBLE&amp;quot;, &amp;quot;MODERN&amp;quot;, &amp;quot;RESTRICTED&amp;quot;, &amp;quot;CUSTOM&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Profile
    {
        get => GetProperty<TerraformProperty<string>>("profile");
        set => this.WithProperty("profile", value);
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
    /// The region where the regional SSL policy resides.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRegionSslPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeRegionSslPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The list of features enabled in the SSL policy.
    /// </summary>
    public TerraformExpression EnabledFeatures => this["enabled_features"];

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this
    /// object. This field is used in optimistic locking.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
