using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_machine_learning_workspace_network_outbound_rule_service_tag resource.
/// </summary>
public class AzurermMachineLearningWorkspaceNetworkOutboundRuleServiceTag : TerraformResource
{
    public AzurermMachineLearningWorkspaceNetworkOutboundRuleServiceTag(string name) : base("azurerm_machine_learning_workspace_network_outbound_rule_service_tag", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The port_ranges attribute.
    /// </summary>
    public string? PortRanges
    {
        get => GetProperty<TerraformLiteralProperty<string>>("port_ranges")?.Value;
        set => this.WithProperty("port_ranges", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_tag attribute.
    /// </summary>
    public string? ServiceTag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_tag")?.Value;
        set => this.WithProperty("service_tag", value == null ? null : new TerraformLiteralProperty<string>(value));
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
