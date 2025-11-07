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
    public TerraformLiteralProperty<string>? AssemblyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assembly_name");
        set => this.WithProperty("assembly_name", value);
    }

    /// <summary>
    /// The assembly_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AssemblyVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assembly_version");
        set => this.WithProperty("assembly_version", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Content
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content");
        set => this.WithProperty("content", value);
    }

    /// <summary>
    /// The content_link_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentLinkUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_link_uri");
        set => this.WithProperty("content_link_uri", value);
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
    /// The integration_account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IntegrationAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_account_name");
        set => this.WithProperty("integration_account_name", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata");
        set => this.WithProperty("metadata", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
