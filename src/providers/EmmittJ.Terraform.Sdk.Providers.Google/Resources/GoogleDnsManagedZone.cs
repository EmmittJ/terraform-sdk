using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cloud_logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZoneCloudLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// If set, enable query logging for this ManagedZone. False by default, making logging opt-in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableLogging is required")]
    public required TerraformProperty<bool> EnableLogging
    {
        set => SetProperty("enable_logging", value);
    }

}

/// <summary>
/// Block type for dnssec_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZoneDnssecConfigBlock : TerraformBlock
{
    /// <summary>
    /// Identifies what kind of resource this is
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        set => SetProperty("kind", value);
    }

    /// <summary>
    /// Specifies the mechanism used to provide authenticated denial-of-existence responses.
    /// non_existence can only be updated when the state is &#39;off&#39;. Possible values: [&amp;quot;nsec&amp;quot;, &amp;quot;nsec3&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? NonExistence
    {
        set => SetProperty("non_existence", value);
    }

    /// <summary>
    /// Specifies whether DNSSEC is enabled, and what mode it is in Possible values: [&amp;quot;off&amp;quot;, &amp;quot;on&amp;quot;, &amp;quot;transfer&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

}

/// <summary>
/// Block type for forwarding_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZoneForwardingConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for peering_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZonePeeringConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for private_visibility_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZonePrivateVisibilityConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDnsManagedZoneTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dns_managed_zone resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDnsManagedZone : TerraformResource
{
    public GoogleDnsManagedZone(string name) : base("google_dns_managed_zone", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("creation_time");
        SetOutput("effective_labels");
        SetOutput("managed_zone_id");
        SetOutput("name_servers");
        SetOutput("terraform_labels");
        SetOutput("description");
        SetOutput("dns_name");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("project");
        SetOutput("visibility");
    }

    /// <summary>
    /// A textual description field. Defaults to &#39;Managed by Terraform&#39;.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The DNS name of this managed zone, for instance &amp;quot;example.com.&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsName is required")]
    public required TerraformProperty<string> DnsName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_name");
        set => SetProperty("dns_name", value);
    }

    /// <summary>
    /// Set this true to delete all records in the zone.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to this ManagedZone.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// User assigned name for this resource.
    /// Must be unique within the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The zone&#39;s visibility: public zones are exposed to the Internet,
    /// while private zones are visible only to Virtual Private Cloud resources. Default value: &amp;quot;public&amp;quot; Possible values: [&amp;quot;private&amp;quot;, &amp;quot;public&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Visibility
    {
        get => GetRequiredOutput<TerraformProperty<string>>("visibility");
        set => SetProperty("visibility", value);
    }

    /// <summary>
    /// Block for cloud_logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudLoggingConfig block(s) allowed")]
    public List<GoogleDnsManagedZoneCloudLoggingConfigBlock>? CloudLoggingConfig
    {
        set => SetProperty("cloud_logging_config", value);
    }

    /// <summary>
    /// Block for dnssec_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnssecConfig block(s) allowed")]
    public List<GoogleDnsManagedZoneDnssecConfigBlock>? DnssecConfig
    {
        set => SetProperty("dnssec_config", value);
    }

    /// <summary>
    /// Block for forwarding_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardingConfig block(s) allowed")]
    public List<GoogleDnsManagedZoneForwardingConfigBlock>? ForwardingConfig
    {
        set => SetProperty("forwarding_config", value);
    }

    /// <summary>
    /// Block for peering_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PeeringConfig block(s) allowed")]
    public List<GoogleDnsManagedZonePeeringConfigBlock>? PeeringConfig
    {
        set => SetProperty("peering_config", value);
    }

    /// <summary>
    /// Block for private_visibility_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateVisibilityConfig block(s) allowed")]
    public List<GoogleDnsManagedZonePrivateVisibilityConfigBlock>? PrivateVisibilityConfig
    {
        set => SetProperty("private_visibility_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDnsManagedZoneTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The time that this resource was created on the server.
    /// This is in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Unique identifier for the resource; defined by the server.
    /// </summary>
    public TerraformExpression ManagedZoneId => this["managed_zone_id"];

    /// <summary>
    /// Delegate your managed_zone to these virtual name servers;
    /// defined by the server
    /// </summary>
    public TerraformExpression NameServers => this["name_servers"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
