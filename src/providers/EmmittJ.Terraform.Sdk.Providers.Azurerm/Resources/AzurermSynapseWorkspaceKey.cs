using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSynapseWorkspaceKey.
/// Nesting mode: single
/// </summary>
public class AzurermSynapseWorkspaceKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_synapse_workspace_key Terraform resource.
/// Manages a azurerm_synapse_workspace_key resource.
/// </summary>
public partial class AzurermSynapseWorkspaceKey(string name) : TerraformResource("azurerm_synapse_workspace_key", name)
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Active is required")]
    public required TerraformValue<bool> Active
    {
        get => new TerraformReference<bool>(this, "active");
        set => SetArgument("active", value);
    }

    /// <summary>
    /// The customer_managed_key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerManagedKeyName is required")]
    public required TerraformValue<string> CustomerManagedKeyName
    {
        get => new TerraformReference<string>(this, "customer_managed_key_name");
        set => SetArgument("customer_managed_key_name", value);
    }

    /// <summary>
    /// The customer_managed_key_versionless_id attribute.
    /// </summary>
    public TerraformValue<string>? CustomerManagedKeyVersionlessId
    {
        get => new TerraformReference<string>(this, "customer_managed_key_versionless_id");
        set => SetArgument("customer_managed_key_versionless_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    public required TerraformValue<string> SynapseWorkspaceId
    {
        get => new TerraformReference<string>(this, "synapse_workspace_id");
        set => SetArgument("synapse_workspace_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSynapseWorkspaceKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSynapseWorkspaceKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
