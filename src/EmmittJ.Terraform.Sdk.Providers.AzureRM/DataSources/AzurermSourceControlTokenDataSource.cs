using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("token");
        this.DeclareOutput("token_secret");
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
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
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
