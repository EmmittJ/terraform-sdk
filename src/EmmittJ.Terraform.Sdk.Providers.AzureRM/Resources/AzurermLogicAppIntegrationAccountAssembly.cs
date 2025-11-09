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
    public TerraformProperty<string>? AssemblyName
    {
        get => GetProperty<TerraformProperty<string>>("assembly_name");
        set => this.WithProperty("assembly_name", value);
    }

    /// <summary>
    /// The assembly_version attribute.
    /// </summary>
    public TerraformProperty<string>? AssemblyVersion
    {
        get => GetProperty<TerraformProperty<string>>("assembly_version");
        set => this.WithProperty("assembly_version", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformProperty<string>? Content
    {
        get => GetProperty<TerraformProperty<string>>("content");
        set => this.WithProperty("content", value);
    }

    /// <summary>
    /// The content_link_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ContentLinkUri
    {
        get => GetProperty<TerraformProperty<string>>("content_link_uri");
        set => this.WithProperty("content_link_uri", value);
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
    /// The integration_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationAccountName
    {
        get => GetProperty<TerraformProperty<string>>("integration_account_name");
        set => this.WithProperty("integration_account_name", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMapProperty<string>? Metadata
    {
        get => GetProperty<TerraformMapProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
