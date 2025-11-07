using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_eventhub_sas.
/// </summary>
public class AzurermEventhubSasDataSource : TerraformDataSource
{
    public AzurermEventhubSasDataSource(string name) : base("azurerm_eventhub_sas", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("sas");
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_string");
        set => this.WithProperty("connection_string", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Expiry
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiry");
        set => this.WithProperty("expiry", value);
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
    /// The sas attribute.
    /// </summary>
    public TerraformExpression Sas => this["sas"];

}
