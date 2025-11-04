using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kusto_script resource.
/// </summary>
public class AzurermKustoScript : TerraformResource
{
    public AzurermKustoScript(string name) : base("azurerm_kusto_script", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The continue_on_errors_enabled attribute.
    /// </summary>
    public bool? ContinueOnErrorsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("continue_on_errors_enabled")?.Value;
        set => this.WithProperty("continue_on_errors_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The database_id attribute.
    /// </summary>
    public string? DatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_id")?.Value;
        set => this.WithProperty("database_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The force_an_update_when_value_changed attribute.
    /// </summary>
    public string? ForceAnUpdateWhenValueChanged
    {
        get => GetProperty<TerraformLiteralProperty<string>>("force_an_update_when_value_changed")?.Value;
        set => this.WithProperty("force_an_update_when_value_changed", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The sas_token attribute.
    /// </summary>
    public string? SasToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sas_token")?.Value;
        set => this.WithProperty("sas_token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    public string? ScriptContent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("script_content")?.Value;
        set => this.WithProperty("script_content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public string? Url
    {
        get => GetProperty<TerraformLiteralProperty<string>>("url")?.Value;
        set => this.WithProperty("url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
