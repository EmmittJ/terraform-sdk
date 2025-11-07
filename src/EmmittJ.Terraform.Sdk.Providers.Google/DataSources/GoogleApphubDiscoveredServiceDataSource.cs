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
        this.DeclareOutput("name");
        this.DeclareOutput("service_properties");
        this.DeclareOutput("service_reference");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The service_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceUri
    {
        get => GetProperty<TerraformProperty<string>>("service_uri");
        set => this.WithProperty("service_uri", value);
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
