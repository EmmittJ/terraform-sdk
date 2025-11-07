using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_looker_instance resource.
/// </summary>
public class GoogleLookerInstance : TerraformResource
{
    public GoogleLookerInstance(string name) : base("google_looker_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("egress_public_ip");
        this.DeclareOutput("ingress_private_ip");
        this.DeclareOutput("ingress_public_ip");
        this.DeclareOutput("looker_uri");
        this.DeclareOutput("looker_version");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Network name in the consumer project in the format of: projects/{project}/global/networks/{network}
    /// Note that the consumer network may be in a different GCP project than the consumer
    /// project that is hosting the Looker Instance.
    /// </summary>
    public TerraformProperty<string>? ConsumerNetwork
    {
        get => GetProperty<TerraformProperty<string>>("consumer_network");
        set => this.WithProperty("consumer_network", value);
    }

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// If setting deletion_policy = &amp;quot;FORCE&amp;quot;, the Looker instance will be deleted regardless
    /// of its nested resources. If set to &amp;quot;DEFAULT&amp;quot;, Looker instances that still have
    /// nested resources will return an error. Possible values: DEFAULT, FORCE
    /// </summary>
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
    }

    /// <summary>
    /// FIPS 140-2 Encryption enablement for Looker (Google Cloud Core).
    /// </summary>
    public TerraformProperty<bool>? FipsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("fips_enabled");
        set => this.WithProperty("fips_enabled", value);
    }

    /// <summary>
    /// Gemini enablement for Looker (Google Cloud Core).
    /// </summary>
    public TerraformProperty<bool>? GeminiEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("gemini_enabled");
        set => this.WithProperty("gemini_enabled", value);
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
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Platform editions for a Looker instance. Each edition maps to a set of instance features, like its size. Must be one of these values:
    /// - LOOKER_CORE_TRIAL: trial instance (Currently Unavailable)
    /// - LOOKER_CORE_STANDARD: pay as you go standard instance (Currently Unavailable)
    /// - LOOKER_CORE_STANDARD_ANNUAL: subscription standard instance
    /// - LOOKER_CORE_ENTERPRISE_ANNUAL: subscription enterprise instance
    /// - LOOKER_CORE_EMBED_ANNUAL: subscription embed instance
    /// - LOOKER_CORE_NONPROD_STANDARD_ANNUAL: nonprod subscription standard instance
    /// - LOOKER_CORE_NONPROD_ENTERPRISE_ANNUAL: nonprod subscription enterprise instance
    /// - LOOKER_CORE_NONPROD_EMBED_ANNUAL: nonprod subscription embed instance
    /// - LOOKER_CORE_TRIAL_STANDARD: A standard trial edition of Looker (Google Cloud core) product.
    /// - LOOKER_CORE_TRIAL_ENTERPRISE: An enterprise trial edition of Looker (Google Cloud core) product.
    /// - LOOKER_CORE_TRIAL_EMBED: An embed trial edition of Looker (Google Cloud core) product. Default value: &amp;quot;LOOKER_CORE_TRIAL&amp;quot; Possible values: [&amp;quot;LOOKER_CORE_TRIAL&amp;quot;, &amp;quot;LOOKER_CORE_STANDARD&amp;quot;, &amp;quot;LOOKER_CORE_STANDARD_ANNUAL&amp;quot;, &amp;quot;LOOKER_CORE_ENTERPRISE_ANNUAL&amp;quot;, &amp;quot;LOOKER_CORE_EMBED_ANNUAL&amp;quot;, &amp;quot;LOOKER_CORE_NONPROD_STANDARD_ANNUAL&amp;quot;, &amp;quot;LOOKER_CORE_NONPROD_ENTERPRISE_ANNUAL&amp;quot;, &amp;quot;LOOKER_CORE_NONPROD_EMBED_ANNUAL&amp;quot;, &amp;quot;LOOKER_CORE_TRIAL_STANDARD&amp;quot;, &amp;quot;LOOKER_CORE_TRIAL_ENTERPRISE&amp;quot;, &amp;quot;LOOKER_CORE_TRIAL_EMBED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? PlatformEdition
    {
        get => GetProperty<TerraformProperty<string>>("platform_edition");
        set => this.WithProperty("platform_edition", value);
    }

    /// <summary>
    /// Whether private IP is enabled on the Looker instance.
    /// </summary>
    public TerraformProperty<bool>? PrivateIpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("private_ip_enabled");
        set => this.WithProperty("private_ip_enabled", value);
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
    /// Whether Public Service Connect (PSC) is enabled on the Looker instance
    /// </summary>
    public TerraformProperty<bool>? PscEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("psc_enabled");
        set => this.WithProperty("psc_enabled", value);
    }

    /// <summary>
    /// Whether public IP is enabled on the Looker instance.
    /// </summary>
    public TerraformProperty<bool>? PublicIpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_ip_enabled");
        set => this.WithProperty("public_ip_enabled", value);
    }

    /// <summary>
    /// The name of the Looker region of the instance.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Name of a reserved IP address range within the consumer network, to be used for
    /// private service access connection. User may or may not specify this in a request.
    /// </summary>
    public TerraformProperty<string>? ReservedRange
    {
        get => GetProperty<TerraformProperty<string>>("reserved_range");
        set => this.WithProperty("reserved_range", value);
    }

    /// <summary>
    /// The time the instance was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Public Egress IP (IPv4).
    /// </summary>
    public TerraformExpression EgressPublicIp => this["egress_public_ip"];

    /// <summary>
    /// Private Ingress IP (IPv4).
    /// </summary>
    public TerraformExpression IngressPrivateIp => this["ingress_private_ip"];

    /// <summary>
    /// Public Ingress IP (IPv4).
    /// </summary>
    public TerraformExpression IngressPublicIp => this["ingress_public_ip"];

    /// <summary>
    /// Looker instance URI which can be used to access the Looker Instance UI.
    /// </summary>
    public TerraformExpression LookerUri => this["looker_uri"];

    /// <summary>
    /// The Looker version that the instance is using.
    /// </summary>
    public TerraformExpression LookerVersion => this["looker_version"];

    /// <summary>
    /// The time the instance was updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
