using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for configmanagement in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipConfigmanagementBlock : ITerraformBlock
{
    /// <summary>
    /// Set this field to MANAGEMENT_AUTOMATIC to enable Config Sync auto-upgrades, and set this field to MANAGEMENT_MANUAL or MANAGEMENT_UNSPECIFIED to disable Config Sync auto-upgrades.
    /// </summary>
    [TerraformPropertyName("management")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Management { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "management");

    /// <summary>
    /// Optional. Version of ACM to install. Defaults to the latest version.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "version");

}

/// <summary>
/// Block type for mesh in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipMeshBlock : ITerraformBlock
{
    /// <summary>
    /// **DEPRECATED** Whether to automatically manage Service Mesh control planes. Possible values: CONTROL_PLANE_MANAGEMENT_UNSPECIFIED, AUTOMATIC, MANUAL
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("control_plane")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ControlPlane { get; set; }

    /// <summary>
    /// Whether to automatically manage Service Mesh. Possible values: MANAGEMENT_UNSPECIFIED, MANAGEMENT_AUTOMATIC, MANAGEMENT_MANUAL
    /// </summary>
    [TerraformPropertyName("management")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Management { get; set; }

}

/// <summary>
/// Block type for policycontroller in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. Version of Policy Controller to install. Defaults to the latest version.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "version");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubFeatureMembershipTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_gke_hub_feature_membership resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeHubFeatureMembership : TerraformResource
{
    public GoogleGkeHubFeatureMembership(string name) : base("google_gke_hub_feature_membership", name)
    {
    }

    /// <summary>
    /// The name of the feature
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Feature is required")]
    [TerraformPropertyName("feature")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Feature { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location of the feature
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name of the membership
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Membership is required")]
    [TerraformPropertyName("membership")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Membership { get; set; }

    /// <summary>
    /// The location of the membership
    /// </summary>
    [TerraformPropertyName("membership_location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MembershipLocation { get; set; }

    /// <summary>
    /// The project of the feature
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for configmanagement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configmanagement block(s) allowed")]
    [TerraformPropertyName("configmanagement")]
    public TerraformList<TerraformBlock<GoogleGkeHubFeatureMembershipConfigmanagementBlock>>? Configmanagement { get; set; } = new();

    /// <summary>
    /// Block for mesh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mesh block(s) allowed")]
    [TerraformPropertyName("mesh")]
    public TerraformList<TerraformBlock<GoogleGkeHubFeatureMembershipMeshBlock>>? Mesh { get; set; } = new();

    /// <summary>
    /// Block for policycontroller.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Policycontroller block(s) allowed")]
    [TerraformPropertyName("policycontroller")]
    public TerraformList<TerraformBlock<GoogleGkeHubFeatureMembershipPolicycontrollerBlock>>? Policycontroller { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleGkeHubFeatureMembershipTimeoutsBlock>? Timeouts { get; set; } = new();

}
