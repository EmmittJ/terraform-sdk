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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    public required TerraformValue<string> ServiceUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_uri");
        set => SetArgument("service_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The service_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceProperties
        => CreateReference("service_properties");

    /// <summary>
    /// The service_reference attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceReference
        => CreateReference("service_reference");

}
