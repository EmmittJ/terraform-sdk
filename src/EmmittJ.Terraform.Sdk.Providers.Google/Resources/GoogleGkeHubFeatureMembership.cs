using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public TerraformProperty<string>? Feature
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the membership
    /// </summary>
    public TerraformProperty<string>? Membership
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

}
