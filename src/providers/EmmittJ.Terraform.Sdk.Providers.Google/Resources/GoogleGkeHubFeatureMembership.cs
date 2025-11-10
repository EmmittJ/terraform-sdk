using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for configmanagement in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipConfigmanagementBlock : TerraformBlock
{
    /// <summary>
    /// Set this field to MANAGEMENT_AUTOMATIC to enable Config Sync auto-upgrades, and set this field to MANAGEMENT_MANUAL or MANAGEMENT_UNSPECIFIED to disable Config Sync auto-upgrades.
    /// </summary>
    public TerraformProperty<string>? Management
    {
        set => SetProperty("management", value);
    }

    /// <summary>
    /// Optional. Version of ACM to install. Defaults to the latest version.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for mesh in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipMeshBlock : TerraformBlock
{
    /// <summary>
    /// **DEPRECATED** Whether to automatically manage Service Mesh control planes. Possible values: CONTROL_PLANE_MANAGEMENT_UNSPECIFIED, AUTOMATIC, MANUAL
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? ControlPlane
    {
        set => SetProperty("control_plane", value);
    }

    /// <summary>
    /// Whether to automatically manage Service Mesh. Possible values: MANAGEMENT_UNSPECIFIED, MANAGEMENT_AUTOMATIC, MANAGEMENT_MANUAL
    /// </summary>
    public TerraformProperty<string>? Management
    {
        set => SetProperty("management", value);
    }

}

/// <summary>
/// Block type for policycontroller in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Version of Policy Controller to install. Defaults to the latest version.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubFeatureMembershipTimeoutsBlock : TerraformBlock
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
/// Manages a google_gke_hub_feature_membership resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeHubFeatureMembership : TerraformResource
{
    public GoogleGkeHubFeatureMembership(string name) : base("google_gke_hub_feature_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("feature");
        SetOutput("id");
        SetOutput("location");
        SetOutput("membership");
        SetOutput("membership_location");
        SetOutput("project");
    }

    /// <summary>
    /// The name of the feature
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Feature is required")]
    public required TerraformProperty<string> Feature
    {
        get => GetRequiredOutput<TerraformProperty<string>>("feature");
        set => SetProperty("feature", value);
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
    /// The location of the feature
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name of the membership
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Membership is required")]
    public required TerraformProperty<string> Membership
    {
        get => GetRequiredOutput<TerraformProperty<string>>("membership");
        set => SetProperty("membership", value);
    }

    /// <summary>
    /// The location of the membership
    /// </summary>
    public TerraformProperty<string> MembershipLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("membership_location");
        set => SetProperty("membership_location", value);
    }

    /// <summary>
    /// The project of the feature
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for configmanagement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configmanagement block(s) allowed")]
    public List<GoogleGkeHubFeatureMembershipConfigmanagementBlock>? Configmanagement
    {
        set => SetProperty("configmanagement", value);
    }

    /// <summary>
    /// Block for mesh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mesh block(s) allowed")]
    public List<GoogleGkeHubFeatureMembershipMeshBlock>? Mesh
    {
        set => SetProperty("mesh", value);
    }

    /// <summary>
    /// Block for policycontroller.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Policycontroller block(s) allowed")]
    public List<GoogleGkeHubFeatureMembershipPolicycontrollerBlock>? Policycontroller
    {
        set => SetProperty("policycontroller", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeHubFeatureMembershipTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
