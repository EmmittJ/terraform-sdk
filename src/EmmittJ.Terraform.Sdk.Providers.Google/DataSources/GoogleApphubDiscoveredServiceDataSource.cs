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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    public string? ServiceUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_uri")?.Value;
        set => this.WithProperty("service_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
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
