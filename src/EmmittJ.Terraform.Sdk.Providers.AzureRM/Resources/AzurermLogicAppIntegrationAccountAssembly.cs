using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppIntegrationAccountAssemblyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssemblyName is required")]
    public required TerraformProperty<string> AssemblyName
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationAccountName is required")]
    public required TerraformProperty<string> IntegrationAccountName
    {
        get => GetProperty<TerraformProperty<string>>("integration_account_name");
        set => this.WithProperty("integration_account_name", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogicAppIntegrationAccountAssemblyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLogicAppIntegrationAccountAssemblyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
