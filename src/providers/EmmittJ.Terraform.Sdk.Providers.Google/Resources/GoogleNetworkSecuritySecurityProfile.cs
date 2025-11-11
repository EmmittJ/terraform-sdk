using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for custom_intercept_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecuritySecurityProfileCustomInterceptProfileBlock
{
    /// <summary>
    /// The Intercept Endpoint Group to which matching traffic should be intercepted.
    /// Format: projects/{project_id}/locations/global/interceptEndpointGroups/{endpoint_group_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterceptEndpointGroup is required")]
    [TerraformPropertyName("intercept_endpoint_group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InterceptEndpointGroup { get; set; }

}

/// <summary>
/// Block type for custom_mirroring_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecuritySecurityProfileCustomMirroringProfileBlock
{
    /// <summary>
    /// The Mirroring Endpoint Group to which matching traffic should be mirrored.
    /// Format: projects/{project_id}/locations/global/mirroringEndpointGroups/{endpoint_group_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroringEndpointGroup is required")]
    [TerraformPropertyName("mirroring_endpoint_group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MirroringEndpointGroup { get; set; }

}

/// <summary>
/// Block type for threat_prevention_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecuritySecurityProfileTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_security_security_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkSecuritySecurityProfile : TerraformResource
{
    public GoogleNetworkSecuritySecurityProfile(string name) : base("google_network_security_security_profile", name)
    {
    }

    /// <summary>
    /// An optional description of the security profile. The Max length is 512 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// A map of key/value label pairs to assign to the resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the security profile.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The name of the security profile resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name of the parent this security profile belongs to.
    /// Format: organizations/{organization_id}.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// The type of security profile. Possible values: [&amp;quot;THREAT_PREVENTION&amp;quot;, &amp;quot;URL_FILTERING&amp;quot;, &amp;quot;CUSTOM_MIRRORING&amp;quot;, &amp;quot;CUSTOM_INTERCEPT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for custom_intercept_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomInterceptProfile block(s) allowed")]
    [TerraformPropertyName("custom_intercept_profile")]
    public TerraformList<TerraformBlock<GoogleNetworkSecuritySecurityProfileCustomInterceptProfileBlock>>? CustomInterceptProfile { get; set; }

    /// <summary>
    /// Block for custom_mirroring_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomMirroringProfile block(s) allowed")]
    [TerraformPropertyName("custom_mirroring_profile")]
    public TerraformList<TerraformBlock<GoogleNetworkSecuritySecurityProfileCustomMirroringProfileBlock>>? CustomMirroringProfile { get; set; }

    /// <summary>
    /// Block for threat_prevention_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatPreventionProfile block(s) allowed")]
    [TerraformPropertyName("threat_prevention_profile")]
    public TerraformList<TerraformBlock<GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlock>>? ThreatPreventionProfile { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkSecuritySecurityProfileTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time the security profile was created in UTC.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// This checksum is computed by the server based on the value of other fields,
    /// and may be sent on update and delete requests to ensure the client has an up-to-date
    /// value before proceeding.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Time the security profile was updated in UTC.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
