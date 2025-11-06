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
    public string? AutomationAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_account_name")?.Value;
        set => this.WithProperty("automation_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_uri attribute.
    /// </summary>
    public string? ContentUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_uri")?.Value;
        set => this.WithProperty("content_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_version attribute.
    /// </summary>
    public string? ContentVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_version")?.Value;
        set => this.WithProperty("content_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hash_algorithm attribute.
    /// </summary>
    public string? HashAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hash_algorithm")?.Value;
        set => this.WithProperty("hash_algorithm", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hash_value attribute.
    /// </summary>
    public string? HashValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hash_value")?.Value;
        set => this.WithProperty("hash_value", value == null ? null : new TerraformLiteralProperty<string>(value));
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

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
