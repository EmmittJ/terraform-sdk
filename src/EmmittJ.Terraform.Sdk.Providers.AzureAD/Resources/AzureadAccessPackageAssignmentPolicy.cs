using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_access_package_assignment_policy resource.
/// </summary>
public class AzureadAccessPackageAssignmentPolicy : TerraformResource
{
    public AzureadAccessPackageAssignmentPolicy(string name) : base("azuread_access_package_assignment_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The ID of the access package that will contain the policy
    /// </summary>
    public TerraformProperty<string>? AccessPackageId
    {
        get => GetProperty<TerraformProperty<string>>("access_package_id");
        set => this.WithProperty("access_package_id", value);
    }

    /// <summary>
    /// The description of the policy
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the policy
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// How many days this assignment is valid for
    /// </summary>
    public TerraformProperty<double>? DurationInDays
    {
        get => GetProperty<TerraformProperty<double>>("duration_in_days");
        set => this.WithProperty("duration_in_days", value);
    }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public TerraformProperty<string>? ExpirationDate
    {
        get => GetProperty<TerraformProperty<string>>("expiration_date");
        set => this.WithProperty("expiration_date", value);
    }

    /// <summary>
    /// When enabled, users will be able to request extension of their access to this package before their access expires
    /// </summary>
    public TerraformProperty<bool>? ExtensionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("extension_enabled");
        set => this.WithProperty("extension_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
