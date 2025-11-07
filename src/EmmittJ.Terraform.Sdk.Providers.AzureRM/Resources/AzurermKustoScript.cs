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
    public TerraformProperty<bool>? ContinueOnErrorsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("continue_on_errors_enabled");
        set => this.WithProperty("continue_on_errors_enabled", value);
    }

    /// <summary>
    /// The database_id attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("database_id");
        set => this.WithProperty("database_id", value);
    }

    /// <summary>
    /// The force_an_update_when_value_changed attribute.
    /// </summary>
    public TerraformProperty<string>? ForceAnUpdateWhenValueChanged
    {
        get => GetProperty<TerraformProperty<string>>("force_an_update_when_value_changed");
        set => this.WithProperty("force_an_update_when_value_changed", value);
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
    /// The sas_token attribute.
    /// </summary>
    public TerraformProperty<string>? SasToken
    {
        get => GetProperty<TerraformProperty<string>>("sas_token");
        set => this.WithProperty("sas_token", value);
    }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    public TerraformProperty<string>? ScriptContent
    {
        get => GetProperty<TerraformProperty<string>>("script_content");
        set => this.WithProperty("script_content", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => this.WithProperty("url", value);
    }

}
