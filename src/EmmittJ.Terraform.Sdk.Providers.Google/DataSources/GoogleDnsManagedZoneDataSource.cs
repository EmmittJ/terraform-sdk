using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dns_managed_zone.
/// </summary>
public class GoogleDnsManagedZoneDataSource : TerraformDataSource
{
    public GoogleDnsManagedZoneDataSource(string name) : base("google_dns_managed_zone", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("id");
        this.DeclareOutput("managed_zone_id");
        this.DeclareOutput("name_servers");
        this.DeclareOutput("visibility");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The managed_zone_id attribute.
    /// </summary>
    public TerraformExpression ManagedZoneId => this["managed_zone_id"];

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    public TerraformExpression NameServers => this["name_servers"];

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformExpression Visibility => this["visibility"];

}
