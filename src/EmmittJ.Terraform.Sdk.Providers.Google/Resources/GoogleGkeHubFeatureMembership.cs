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
    public TerraformLiteralProperty<string>? Feature
    {
        get => GetProperty<TerraformLiteralProperty<string>>("feature");
        set => this.WithProperty("feature", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location of the feature
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the membership
    /// </summary>
    public TerraformLiteralProperty<string>? Membership
    {
        get => GetProperty<TerraformLiteralProperty<string>>("membership");
        set => this.WithProperty("membership", value);
    }

    /// <summary>
    /// The location of the membership
    /// </summary>
    public TerraformLiteralProperty<string>? MembershipLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("membership_location");
        set => this.WithProperty("membership_location", value);
    }

    /// <summary>
    /// The project of the feature
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

}
