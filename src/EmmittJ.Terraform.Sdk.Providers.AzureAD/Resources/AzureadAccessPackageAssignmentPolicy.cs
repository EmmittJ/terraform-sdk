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
    public string? AccessPackageId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_package_id")?.Value;
        set => this.WithProperty("access_package_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description of the policy
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display name of the policy
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// How many days this assignment is valid for
    /// </summary>
    public double? DurationInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("duration_in_days")?.Value;
        set => this.WithProperty("duration_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public string? ExpirationDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiration_date")?.Value;
        set => this.WithProperty("expiration_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// When enabled, users will be able to request extension of their access to this package before their access expires
    /// </summary>
    public bool? ExtensionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("extension_enabled")?.Value;
        set => this.WithProperty("extension_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
