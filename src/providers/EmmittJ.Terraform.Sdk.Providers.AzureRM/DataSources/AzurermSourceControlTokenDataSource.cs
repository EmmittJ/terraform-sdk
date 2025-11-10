using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSourceControlTokenDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_source_control_token.
/// </summary>
public class AzurermSourceControlTokenDataSource : TerraformDataSource
{
    public AzurermSourceControlTokenDataSource(string name) : base("azurerm_source_control_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("token");
        SetOutput("token_secret");
        SetOutput("id");
        SetOutput("type");
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSourceControlTokenDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    public TerraformExpression Token => this["token"];

    /// <summary>
    /// The token_secret attribute.
    /// </summary>
    public TerraformExpression TokenSecret => this["token_secret"];

}
