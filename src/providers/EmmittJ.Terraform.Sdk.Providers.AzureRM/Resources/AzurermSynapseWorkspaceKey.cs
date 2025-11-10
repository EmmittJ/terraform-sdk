using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseWorkspaceKeyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_synapse_workspace_key resource.
/// </summary>
public class AzurermSynapseWorkspaceKey : TerraformResource
{
    public AzurermSynapseWorkspaceKey(string name) : base("azurerm_synapse_workspace_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("active");
        SetOutput("customer_managed_key_name");
        SetOutput("customer_managed_key_versionless_id");
        SetOutput("id");
        SetOutput("synapse_workspace_id");
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Active is required")]
    public required TerraformProperty<bool> Active
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("active");
        set => SetProperty("active", value);
    }

    /// <summary>
    /// The customer_managed_key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerManagedKeyName is required")]
    public required TerraformProperty<string> CustomerManagedKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_managed_key_name");
        set => SetProperty("customer_managed_key_name", value);
    }

    /// <summary>
    /// The customer_managed_key_versionless_id attribute.
    /// </summary>
    public TerraformProperty<string> CustomerManagedKeyVersionlessId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_managed_key_versionless_id");
        set => SetProperty("customer_managed_key_versionless_id", value);
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
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    public required TerraformProperty<string> SynapseWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("synapse_workspace_id");
        set => SetProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseWorkspaceKeyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
