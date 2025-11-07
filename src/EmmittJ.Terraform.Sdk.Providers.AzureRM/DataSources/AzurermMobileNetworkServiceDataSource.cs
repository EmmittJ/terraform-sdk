using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_mobile_network_service.
/// </summary>
public class AzurermMobileNetworkServiceDataSource : TerraformDataSource
{
    public AzurermMobileNetworkServiceDataSource(string name) : base("azurerm_mobile_network_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("location");
        this.DeclareOutput("pcc_rule");
        this.DeclareOutput("service_precedence");
        this.DeclareOutput("service_qos_policy");
        this.DeclareOutput("tags");
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
    /// The mobile_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? MobileNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("mobile_network_id");
        set => this.WithProperty("mobile_network_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The pcc_rule attribute.
    /// </summary>
    public TerraformExpression PccRule => this["pcc_rule"];

    /// <summary>
    /// The service_precedence attribute.
    /// </summary>
    public TerraformExpression ServicePrecedence => this["service_precedence"];

    /// <summary>
    /// The service_qos_policy attribute.
    /// </summary>
    public TerraformExpression ServiceQosPolicy => this["service_qos_policy"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
