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
    public string? Feature
    {
        get => GetProperty<TerraformLiteralProperty<string>>("feature")?.Value;
        set => this.WithProperty("feature", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location of the feature
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the membership
    /// </summary>
    public string? Membership
    {
        get => GetProperty<TerraformLiteralProperty<string>>("membership")?.Value;
        set => this.WithProperty("membership", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location of the membership
    /// </summary>
    public string? MembershipLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("membership_location")?.Value;
        set => this.WithProperty("membership_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project of the feature
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
