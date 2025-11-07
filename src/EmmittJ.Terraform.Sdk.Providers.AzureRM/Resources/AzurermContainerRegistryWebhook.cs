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
    public TerraformLiteralProperty<HashSet<string>>? Actions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("actions");
        set => this.WithProperty("actions", value);
    }

    /// <summary>
    /// The custom_headers attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? CustomHeaders
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("custom_headers");
        set => this.WithProperty("custom_headers", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The registry_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RegistryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("registry_name");
        set => this.WithProperty("registry_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_uri");
        set => this.WithProperty("service_uri", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
