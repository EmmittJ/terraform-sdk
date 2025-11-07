using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_client_config.
/// </summary>
public class AzurermClientConfigDataSource : TerraformDataSource
{
    public AzurermClientConfigDataSource(string name) : base("azurerm_client_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("client_id");
        this.DeclareOutput("object_id");
        this.DeclareOutput("subscription_id");
        this.DeclareOutput("tenant_id");
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
    /// The client_id attribute.
    /// </summary>
    public TerraformExpression ClientId => this["client_id"];

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformExpression SubscriptionId => this["subscription_id"];

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

}
