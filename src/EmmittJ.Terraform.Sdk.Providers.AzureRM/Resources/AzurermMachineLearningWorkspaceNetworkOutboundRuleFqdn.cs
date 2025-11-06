using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_machine_learning_workspace_network_outbound_rule_fqdn resource.
/// </summary>
public class AzurermMachineLearningWorkspaceNetworkOutboundRuleFqdn : TerraformResource
{
    public AzurermMachineLearningWorkspaceNetworkOutboundRuleFqdn(string name) : base("azurerm_machine_learning_workspace_network_outbound_rule_fqdn", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The destination_fqdn attribute.
    /// </summary>
    public string? DestinationFqdn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_fqdn")?.Value;
        set => this.WithProperty("destination_fqdn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
