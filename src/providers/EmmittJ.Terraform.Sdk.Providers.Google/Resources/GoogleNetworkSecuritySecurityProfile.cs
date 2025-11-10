using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for custom_intercept_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecuritySecurityProfileCustomInterceptProfileBlock : TerraformBlock
{
    /// <summary>
    /// The Intercept Endpoint Group to which matching traffic should be intercepted.
    /// Format: projects/{project_id}/locations/global/interceptEndpointGroups/{endpoint_group_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterceptEndpointGroup is required")]
    public required TerraformProperty<string> InterceptEndpointGroup
    {
        set => SetProperty("intercept_endpoint_group", value);
    }

}

/// <summary>
/// Block type for custom_mirroring_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecuritySecurityProfileCustomMirroringProfileBlock : TerraformBlock
{
    /// <summary>
    /// The Mirroring Endpoint Group to which matching traffic should be mirrored.
    /// Format: projects/{project_id}/locations/global/mirroringEndpointGroups/{endpoint_group_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroringEndpointGroup is required")]
    public required TerraformProperty<string> MirroringEndpointGroup
    {
        set => SetProperty("mirroring_endpoint_group", value);
    }

}

/// <summary>
/// Block type for threat_prevention_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecuritySecurityProfileTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_security_security_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkSecuritySecurityProfile : TerraformResource
{
    public GoogleNetworkSecuritySecurityProfile(string name) : base("google_network_security_security_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("etag");
        SetOutput("self_link");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("parent");
        SetOutput("type");
    }

    /// <summary>
    /// An optional description of the security profile. The Max length is 512 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// A map of key/value label pairs to assign to the resource.
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
    /// The location of the security profile.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name of the security profile resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name of the parent this security profile belongs to.
    /// Format: organizations/{organization_id}.
    /// </summary>
    public TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// The type of security profile. Possible values: [&amp;quot;THREAT_PREVENTION&amp;quot;, &amp;quot;URL_FILTERING&amp;quot;, &amp;quot;CUSTOM_MIRRORING&amp;quot;, &amp;quot;CUSTOM_INTERCEPT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for custom_intercept_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomInterceptProfile block(s) allowed")]
    public List<GoogleNetworkSecuritySecurityProfileCustomInterceptProfileBlock>? CustomInterceptProfile
    {
        set => SetProperty("custom_intercept_profile", value);
    }

    /// <summary>
    /// Block for custom_mirroring_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomMirroringProfile block(s) allowed")]
    public List<GoogleNetworkSecuritySecurityProfileCustomMirroringProfileBlock>? CustomMirroringProfile
    {
        set => SetProperty("custom_mirroring_profile", value);
    }

    /// <summary>
    /// Block for threat_prevention_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatPreventionProfile block(s) allowed")]
    public List<GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlock>? ThreatPreventionProfile
    {
        set => SetProperty("threat_prevention_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkSecuritySecurityProfileTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Time the security profile was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// This checksum is computed by the server based on the value of other fields,
    /// and may be sent on update and delete requests to ensure the client has an up-to-date
    /// value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Time the security profile was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
