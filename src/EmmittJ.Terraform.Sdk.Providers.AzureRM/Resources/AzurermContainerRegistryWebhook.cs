using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_registry_webhook resource.
/// </summary>
public class AzurermContainerRegistryWebhook : TerraformResource
{
    public AzurermContainerRegistryWebhook(string name) : base("azurerm_container_registry_webhook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The actions attribute.
    /// </summary>
    public HashSet<string>? Actions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("actions")?.Value;
        set => this.WithProperty("actions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The custom_headers attribute.
    /// </summary>
    public Dictionary<string, string>? CustomHeaders
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("custom_headers")?.Value;
        set => this.WithProperty("custom_headers", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The registry_name attribute.
    /// </summary>
    public string? RegistryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("registry_name")?.Value;
        set => this.WithProperty("registry_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public string? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope")?.Value;
        set => this.WithProperty("scope", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
