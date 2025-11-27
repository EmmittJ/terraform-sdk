using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_dns_managed_zone Terraform data source.
/// Retrieves information about a google_dns_managed_zone.
/// </summary>
public partial class GoogleDnsManagedZoneDataSource(string name) : TerraformDataSource("google_dns_managed_zone", name)
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The managed_zone_id attribute.
    /// </summary>
    public TerraformValue<double> ManagedZoneId
    {
        get => new TerraformReference<double>(this, "managed_zone_id");
    }

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    public TerraformList<string> NameServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "name_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformValue<string> Visibility
    {
        get => new TerraformReference<string>(this, "visibility");
    }

}
