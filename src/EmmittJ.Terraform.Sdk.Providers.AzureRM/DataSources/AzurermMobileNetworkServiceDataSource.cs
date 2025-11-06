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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    public string? MobileNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mobile_network_id")?.Value;
        set => this.WithProperty("mobile_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
