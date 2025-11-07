using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_automation_python3_package resource.
/// </summary>
public class AzurermAutomationPython3Package : TerraformResource
{
    public AzurermAutomationPython3Package(string name) : base("azurerm_automation_python3_package", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? AutomationAccountName
    {
        get => GetProperty<TerraformProperty<string>>("automation_account_name");
        set => this.WithProperty("automation_account_name", value);
    }

    /// <summary>
    /// The content_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ContentUri
    {
        get => GetProperty<TerraformProperty<string>>("content_uri");
        set => this.WithProperty("content_uri", value);
    }

    /// <summary>
    /// The content_version attribute.
    /// </summary>
    public TerraformProperty<string>? ContentVersion
    {
        get => GetProperty<TerraformProperty<string>>("content_version");
        set => this.WithProperty("content_version", value);
    }

    /// <summary>
    /// The hash_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? HashAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("hash_algorithm");
        set => this.WithProperty("hash_algorithm", value);
    }

    /// <summary>
    /// The hash_value attribute.
    /// </summary>
    public TerraformProperty<string>? HashValue
    {
        get => GetProperty<TerraformProperty<string>>("hash_value");
        set => this.WithProperty("hash_value", value);
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

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
