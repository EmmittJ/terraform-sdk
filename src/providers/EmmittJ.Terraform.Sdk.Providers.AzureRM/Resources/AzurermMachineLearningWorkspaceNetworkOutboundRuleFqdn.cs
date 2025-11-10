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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("destination_fqdn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The destination_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFqdn is required")]
    public required TerraformProperty<string> DestinationFqdn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_fqdn");
        set => SetProperty("destination_fqdn", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_id");
        set => SetProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMachineLearningWorkspaceNetworkOutboundRuleFqdnTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
