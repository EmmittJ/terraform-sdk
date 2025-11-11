using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for custom_intercept_profile in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkSecuritySecurityProfileCustomInterceptProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// The Intercept Endpoint Group to which matching traffic should be intercepted.
    /// Format: projects/{project_id}/locations/global/interceptEndpointGroups/{endpoint_group_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterceptEndpointGroup is required")]
    [TerraformProperty("intercept_endpoint_group")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InterceptEndpointGroup { get; set; }

}

/// <summary>
/// Block type for custom_mirroring_profile in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkSecuritySecurityProfileCustomMirroringProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// The Mirroring Endpoint Group to which matching traffic should be mirrored.
    /// Format: projects/{project_id}/locations/global/mirroringEndpointGroups/{endpoint_group_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroringEndpointGroup is required")]
    [TerraformProperty("mirroring_endpoint_group")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MirroringEndpointGroup { get; set; }

}

/// <summary>
/// Block type for threat_prevention_profile in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkSecuritySecurityProfileTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_security_security_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNetworkSecuritySecurityProfile : TerraformResource
{
    public GoogleNetworkSecuritySecurityProfile(string name) : base("google_network_security_security_profile", name)
    {
    }

    /// <summary>
    /// An optional description of the security profile. The Max length is 512 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A map of key/value label pairs to assign to the resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the security profile.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The name of the security profile resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name of the parent this security profile belongs to.
    /// Format: organizations/{organization_id}.
    /// </summary>
    [TerraformProperty("parent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// The type of security profile. Possible values: [&amp;quot;THREAT_PREVENTION&amp;quot;, &amp;quot;URL_FILTERING&amp;quot;, &amp;quot;CUSTOM_MIRRORING&amp;quot;, &amp;quot;CUSTOM_INTERCEPT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for custom_intercept_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomInterceptProfile block(s) allowed")]
    [TerraformProperty("custom_intercept_profile")]
    public TerraformList<TerraformBlock<GoogleNetworkSecuritySecurityProfileCustomInterceptProfileBlock>>? CustomInterceptProfile { get; set; }

    /// <summary>
    /// Block for custom_mirroring_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomMirroringProfile block(s) allowed")]
    [TerraformProperty("custom_mirroring_profile")]
    public TerraformList<TerraformBlock<GoogleNetworkSecuritySecurityProfileCustomMirroringProfileBlock>>? CustomMirroringProfile { get; set; }

    /// <summary>
    /// Block for threat_prevention_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatPreventionProfile block(s) allowed")]
    [TerraformProperty("threat_prevention_profile")]
    public TerraformList<TerraformBlock<GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlock>>? ThreatPreventionProfile { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleNetworkSecuritySecurityProfileTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time the security profile was created in UTC.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// This checksum is computed by the server based on the value of other fields,
    /// and may be sent on update and delete requests to ensure the client has an up-to-date
    /// value before proceeding.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Time the security profile was updated in UTC.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
