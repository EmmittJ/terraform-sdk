using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for configmanagement in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipConfigmanagementBlock
{
    /// <summary>
    /// Set this field to MANAGEMENT_AUTOMATIC to enable Config Sync auto-upgrades, and set this field to MANAGEMENT_MANUAL or MANAGEMENT_UNSPECIFIED to disable Config Sync auto-upgrades.
    /// </summary>
    [TerraformPropertyName("management")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Management { get; set; } = default!;

    /// <summary>
    /// Optional. Version of ACM to install. Defaults to the latest version.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Version { get; set; } = default!;

}

/// <summary>
/// Block type for mesh in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipMeshBlock
{
    /// <summary>
    /// **DEPRECATED** Whether to automatically manage Service Mesh control planes. Possible values: CONTROL_PLANE_MANAGEMENT_UNSPECIFIED, AUTOMATIC, MANUAL
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("control_plane")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ControlPlane { get; set; }

    /// <summary>
    /// Whether to automatically manage Service Mesh. Possible values: MANAGEMENT_UNSPECIFIED, MANAGEMENT_AUTOMATIC, MANAGEMENT_MANUAL
    /// </summary>
    [TerraformPropertyName("management")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Management { get; set; }

}

/// <summary>
/// Block type for policycontroller in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlock
{
    /// <summary>
    /// Optional. Version of Policy Controller to install. Defaults to the latest version.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Version { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubFeatureMembershipTimeoutsBlock
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
    public required TerraformValue<string> Feature { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location of the feature
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the membership
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Membership is required")]
    [TerraformPropertyName("membership")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Membership { get; set; }

    /// <summary>
    /// The location of the membership
    /// </summary>
    [TerraformPropertyName("membership_location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MembershipLocation { get; set; }

    /// <summary>
    /// The project of the feature
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for configmanagement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configmanagement block(s) allowed")]
    [TerraformPropertyName("configmanagement")]
    public TerraformList<TerraformBlock<GoogleGkeHubFeatureMembershipConfigmanagementBlock>>? Configmanagement { get; set; }

    /// <summary>
    /// Block for mesh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mesh block(s) allowed")]
    [TerraformPropertyName("mesh")]
    public TerraformList<TerraformBlock<GoogleGkeHubFeatureMembershipMeshBlock>>? Mesh { get; set; }

    /// <summary>
    /// Block for policycontroller.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Policycontroller block(s) allowed")]
    [TerraformPropertyName("policycontroller")]
    public TerraformList<TerraformBlock<GoogleGkeHubFeatureMembershipPolicycontrollerBlock>>? Policycontroller { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleGkeHubFeatureMembershipTimeoutsBlock>? Timeouts { get; set; }

}
