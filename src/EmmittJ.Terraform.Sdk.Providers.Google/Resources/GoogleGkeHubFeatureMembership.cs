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
        get => GetProperty<TerraformProperty<string>>("management");
        set => WithProperty("management", value);
    }

    /// <summary>
    /// Optional. Version of ACM to install. Defaults to the latest version.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
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
        get => GetProperty<TerraformProperty<string>>("control_plane");
        set => WithProperty("control_plane", value);
    }

    /// <summary>
    /// Whether to automatically manage Service Mesh. Possible values: MANAGEMENT_UNSPECIFIED, MANAGEMENT_AUTOMATIC, MANAGEMENT_MANUAL
    /// </summary>
    public TerraformProperty<string>? Management
    {
        get => GetProperty<TerraformProperty<string>>("management");
        set => WithProperty("management", value);
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
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_gke_hub_feature_membership resource.
/// </summary>
public class GoogleGkeHubFeatureMembership : TerraformResource
{
    public GoogleGkeHubFeatureMembership(string name) : base("google_gke_hub_feature_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The name of the feature
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Feature is required")]
    public required TerraformProperty<string> Feature
    {
        get => GetProperty<TerraformProperty<string>>("feature");
        set => this.WithProperty("feature", value);
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
    /// The location of the feature
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the membership
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Membership is required")]
    public required TerraformProperty<string> Membership
    {
        get => GetProperty<TerraformProperty<string>>("membership");
        set => this.WithProperty("membership", value);
    }

    /// <summary>
    /// The location of the membership
    /// </summary>
    public TerraformProperty<string>? MembershipLocation
    {
        get => GetProperty<TerraformProperty<string>>("membership_location");
        set => this.WithProperty("membership_location", value);
    }

    /// <summary>
    /// The project of the feature
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for configmanagement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configmanagement block(s) allowed")]
    public List<GoogleGkeHubFeatureMembershipConfigmanagementBlock>? Configmanagement
    {
        get => GetProperty<List<GoogleGkeHubFeatureMembershipConfigmanagementBlock>>("configmanagement");
        set => this.WithProperty("configmanagement", value);
    }

    /// <summary>
    /// Block for mesh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mesh block(s) allowed")]
    public List<GoogleGkeHubFeatureMembershipMeshBlock>? Mesh
    {
        get => GetProperty<List<GoogleGkeHubFeatureMembershipMeshBlock>>("mesh");
        set => this.WithProperty("mesh", value);
    }

    /// <summary>
    /// Block for policycontroller.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Policycontroller block(s) allowed")]
    public List<GoogleGkeHubFeatureMembershipPolicycontrollerBlock>? Policycontroller
    {
        get => GetProperty<List<GoogleGkeHubFeatureMembershipPolicycontrollerBlock>>("policycontroller");
        set => this.WithProperty("policycontroller", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeHubFeatureMembershipTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleGkeHubFeatureMembershipTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
