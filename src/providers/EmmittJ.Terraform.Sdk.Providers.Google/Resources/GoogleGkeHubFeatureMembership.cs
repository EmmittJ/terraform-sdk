using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for configmanagement in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeHubFeatureMembershipConfigmanagementBlock : TerraformBlockBase
{
    /// <summary>
    /// Set this field to MANAGEMENT_AUTOMATIC to enable Config Sync auto-upgrades, and set this field to MANAGEMENT_MANUAL or MANAGEMENT_UNSPECIFIED to disable Config Sync auto-upgrades.
    /// </summary>
    [TerraformProperty("management")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Management { get; set; }

    /// <summary>
    /// Optional. Version of ACM to install. Defaults to the latest version.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for mesh in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeHubFeatureMembershipMeshBlock : TerraformBlockBase
{
    /// <summary>
    /// **DEPRECATED** Whether to automatically manage Service Mesh control planes. Possible values: CONTROL_PLANE_MANAGEMENT_UNSPECIFIED, AUTOMATIC, MANUAL
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("control_plane")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ControlPlane { get; set; }

    /// <summary>
    /// Whether to automatically manage Service Mesh. Possible values: MANAGEMENT_UNSPECIFIED, MANAGEMENT_AUTOMATIC, MANAGEMENT_MANUAL
    /// </summary>
    [TerraformProperty("management")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Management { get; set; }

}

/// <summary>
/// Block type for policycontroller in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeHubFeatureMembershipPolicycontrollerBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. Version of Policy Controller to install. Defaults to the latest version.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleGkeHubFeatureMembershipTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_gke_hub_feature_membership resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleGkeHubFeatureMembership : TerraformResource
{
    public GoogleGkeHubFeatureMembership(string name) : base("google_gke_hub_feature_membership", name)
    {
    }

    /// <summary>
    /// The name of the feature
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Feature is required")]
    [TerraformProperty("feature")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Feature { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the feature
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the membership
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Membership is required")]
    [TerraformProperty("membership")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Membership { get; set; }

    /// <summary>
    /// The location of the membership
    /// </summary>
    [TerraformProperty("membership_location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MembershipLocation { get; set; }

    /// <summary>
    /// The project of the feature
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for configmanagement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configmanagement block(s) allowed")]
    [TerraformProperty("configmanagement")]
    public TerraformList<TerraformBlock<GoogleGkeHubFeatureMembershipConfigmanagementBlock>>? Configmanagement { get; set; }

    /// <summary>
    /// Block for mesh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mesh block(s) allowed")]
    [TerraformProperty("mesh")]
    public TerraformList<TerraformBlock<GoogleGkeHubFeatureMembershipMeshBlock>>? Mesh { get; set; }

    /// <summary>
    /// Block for policycontroller.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Policycontroller block(s) allowed")]
    [TerraformProperty("policycontroller")]
    public TerraformList<TerraformBlock<GoogleGkeHubFeatureMembershipPolicycontrollerBlock>>? Policycontroller { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleGkeHubFeatureMembershipTimeoutsBlock>? Timeouts { get; set; }

}
