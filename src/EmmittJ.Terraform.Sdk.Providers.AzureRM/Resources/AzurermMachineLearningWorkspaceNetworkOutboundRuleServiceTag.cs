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
    /// The port_ranges attribute.
    /// </summary>
    public TerraformProperty<string>? PortRanges
    {
        get => GetProperty<TerraformProperty<string>>("port_ranges");
        set => this.WithProperty("port_ranges", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The service_tag attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceTag
    {
        get => GetProperty<TerraformProperty<string>>("service_tag");
        set => this.WithProperty("service_tag", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

}
