using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeSslPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleComputeSslPolicyTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_ssl_policy Terraform resource.
/// Manages a google_compute_ssl_policy resource.
/// </summary>
public partial class GoogleComputeSslPolicy(string name) : TerraformResource("google_compute_ssl_policy", name)
{
    /// <summary>
    /// Profile specifies the set of SSL features that can be used by the
    /// load balancer when negotiating SSL with clients. This can be one of
    /// &#39;COMPATIBLE&#39;, &#39;MODERN&#39;, &#39;RESTRICTED&#39;, or &#39;CUSTOM&#39;. If using &#39;CUSTOM&#39;,
    /// the set of SSL features to enable must be specified in the
    /// &#39;customFeatures&#39; field.
    /// 
    /// See the [official documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport)
    /// for which ciphers are available to use. **Note**: this argument
    /// *must* be present when using the &#39;CUSTOM&#39; profile. This argument
    /// *must not* be present when using any other profile.
    /// </summary>
    public TerraformSet<string>? CustomFeatures
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "custom_features").ResolveNodes(ctx));
        set => SetArgument("custom_features", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The minimum version of SSL protocol that can be used by the clients
    /// to establish a connection with the load balancer. Default value: &amp;quot;TLS_1_0&amp;quot; Possible values: [&amp;quot;TLS_1_0&amp;quot;, &amp;quot;TLS_1_1&amp;quot;, &amp;quot;TLS_1_2&amp;quot;]
    /// </summary>
    public TerraformValue<string>? MinTlsVersion
    {
        get => new TerraformReference<string>(this, "min_tls_version");
        set => SetArgument("min_tls_version", value);
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
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    public TerraformValue<string>? Profile
    {
        get => new TerraformReference<string>(this, "profile");
        set => SetArgument("profile", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// The list of features enabled in the SSL policy.
    /// </summary>
    public TerraformSet<string> EnabledFeatures
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "enabled_features").ResolveNodes(ctx));
    }

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this
    /// object. This field is used in optimistic locking.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeSslPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeSslPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
