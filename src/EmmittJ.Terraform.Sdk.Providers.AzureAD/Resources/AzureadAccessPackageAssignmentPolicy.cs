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
    public TerraformLiteralProperty<string>? AccessPackageId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_package_id");
        set => this.WithProperty("access_package_id", value);
    }

    /// <summary>
    /// The description of the policy
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the policy
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// How many days this assignment is valid for
    /// </summary>
    public TerraformLiteralProperty<double>? DurationInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("duration_in_days");
        set => this.WithProperty("duration_in_days", value);
    }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public TerraformLiteralProperty<string>? ExpirationDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiration_date");
        set => this.WithProperty("expiration_date", value);
    }

    /// <summary>
    /// When enabled, users will be able to request extension of their access to this package before their access expires
    /// </summary>
    public TerraformLiteralProperty<bool>? ExtensionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("extension_enabled");
        set => this.WithProperty("extension_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
