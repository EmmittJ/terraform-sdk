using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_apphub_discovered_service.
/// </summary>
public class GoogleApphubDiscoveredServiceDataSource : TerraformDataSource
{
    public GoogleApphubDiscoveredServiceDataSource(string name) : base("google_apphub_discovered_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("service_properties");
        SetOutput("service_reference");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
        SetOutput("service_uri");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    public required TerraformProperty<string> ServiceUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_uri");
        set => SetProperty("service_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The service_properties attribute.
    /// </summary>
    public TerraformExpression ServiceProperties => this["service_properties"];

    /// <summary>
    /// The service_reference attribute.
    /// </summary>
    public TerraformExpression ServiceReference => this["service_reference"];

}
