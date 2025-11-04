using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_logic_app_integration_account_assembly resource.
/// </summary>
public class AzurermLogicAppIntegrationAccountAssembly : TerraformResource
{
    public AzurermLogicAppIntegrationAccountAssembly(string name) : base("azurerm_logic_app_integration_account_assembly", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The assembly_name attribute.
    /// </summary>
    public string? AssemblyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assembly_name")?.Value;
        set => this.WithProperty("assembly_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The assembly_version attribute.
    /// </summary>
    public string? AssemblyVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assembly_version")?.Value;
        set => this.WithProperty("assembly_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public string? Content
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content")?.Value;
        set => this.WithProperty("content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_link_uri attribute.
    /// </summary>
    public string? ContentLinkUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_link_uri")?.Value;
        set => this.WithProperty("content_link_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The integration_account_name attribute.
    /// </summary>
    public string? IntegrationAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_account_name")?.Value;
        set => this.WithProperty("integration_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata")?.Value;
        set => this.WithProperty("metadata", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
