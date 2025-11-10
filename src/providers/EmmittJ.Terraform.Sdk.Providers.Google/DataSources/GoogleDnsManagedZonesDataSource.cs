using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dns_managed_zones.
/// </summary>
public class GoogleDnsManagedZonesDataSource : TerraformDataSource
{
    public GoogleDnsManagedZonesDataSource(string name) : base("google_dns_managed_zones", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("managed_zones");
        SetOutput("project");
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The managed_zones attribute.
    /// </summary>
    public TerraformExpression ManagedZones => this["managed_zones"];

}
