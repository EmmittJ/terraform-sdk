using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKustoScriptTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("continue_on_errors_enabled");
        SetOutput("database_id");
        SetOutput("force_an_update_when_value_changed");
        SetOutput("id");
        SetOutput("name");
        SetOutput("sas_token");
        SetOutput("script_content");
        SetOutput("url");
    }

    /// <summary>
    /// The continue_on_errors_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ContinueOnErrorsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("continue_on_errors_enabled");
        set => SetProperty("continue_on_errors_enabled", value);
    }

    /// <summary>
    /// The database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseId is required")]
    public required TerraformProperty<string> DatabaseId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_id");
        set => SetProperty("database_id", value);
    }

    /// <summary>
    /// The force_an_update_when_value_changed attribute.
    /// </summary>
    public TerraformProperty<string> ForceAnUpdateWhenValueChanged
    {
        get => GetRequiredOutput<TerraformProperty<string>>("force_an_update_when_value_changed");
        set => SetProperty("force_an_update_when_value_changed", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    public TerraformProperty<string> SasToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sas_token");
        set => SetProperty("sas_token", value);
    }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    public TerraformProperty<string> ScriptContent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("script_content");
        set => SetProperty("script_content", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string> Url
    {
        get => GetRequiredOutput<TerraformProperty<string>>("url");
        set => SetProperty("url", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKustoScriptTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
