using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningWorkspaceNetworkOutboundRuleFqdnTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFqdn is required")]
    public required TerraformProperty<string> DestinationFqdn
    {
        get => GetProperty<TerraformProperty<string>>("destination_fqdn");
        set => this.WithProperty("destination_fqdn", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMachineLearningWorkspaceNetworkOutboundRuleFqdnTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMachineLearningWorkspaceNetworkOutboundRuleFqdnTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
