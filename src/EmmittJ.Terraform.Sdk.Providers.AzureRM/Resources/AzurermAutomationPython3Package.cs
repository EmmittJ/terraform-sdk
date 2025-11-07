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
    public TerraformLiteralProperty<string>? AutomationAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_account_name");
        set => this.WithProperty("automation_account_name", value);
    }

    /// <summary>
    /// The content_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_uri");
        set => this.WithProperty("content_uri", value);
    }

    /// <summary>
    /// The content_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_version");
        set => this.WithProperty("content_version", value);
    }

    /// <summary>
    /// The hash_algorithm attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HashAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hash_algorithm");
        set => this.WithProperty("hash_algorithm", value);
    }

    /// <summary>
    /// The hash_value attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HashValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hash_value");
        set => this.WithProperty("hash_value", value);
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

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
