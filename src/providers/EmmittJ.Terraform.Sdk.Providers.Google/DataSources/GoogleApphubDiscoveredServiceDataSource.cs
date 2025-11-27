using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_apphub_discovered_service Terraform data source.
/// Retrieves information about a google_apphub_discovered_service.
/// </summary>
public partial class GoogleApphubDiscoveredServiceDataSource(string name) : TerraformDataSource("google_apphub_discovered_service", name)
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    public required TerraformValue<string> ServiceUri
    {
        get => new TerraformReference<string>(this, "service_uri");
        set => SetArgument("service_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The service_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceProperties
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "service_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_reference attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceReference
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "service_reference").ResolveNodes(ctx));
    }

}
