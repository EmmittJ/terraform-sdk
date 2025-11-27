using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_service_networking_peered_dns_domain Terraform data source.
/// Retrieves information about a google_service_networking_peered_dns_domain.
/// </summary>
public partial class GoogleServiceNetworkingPeeredDnsDomainDataSource(string name) : TerraformDataSource("google_service_networking_peered_dns_domain", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

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
    /// The network attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    public TerraformValue<string> DnsSuffix
    {
        get => new TerraformReference<string>(this, "dns_suffix");
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    public TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
    }

}
