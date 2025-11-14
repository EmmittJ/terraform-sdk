using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_synapse_workspace_key resource.
/// </summary>
public class AzurermSynapseWorkspaceKey : TerraformResource
{
    public AzurermSynapseWorkspaceKey(string name) : base("azurerm_synapse_workspace_key", name)
    {
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Active is required")]
    [TerraformArgument("active")]
    public required TerraformValue<bool> Active
    {
        get => new TerraformReference<bool>(this, "active");
        set => SetArgument("active", value);
    }

    /// <summary>
    /// The customer_managed_key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerManagedKeyName is required")]
    [TerraformArgument("customer_managed_key_name")]
    public required TerraformValue<string> CustomerManagedKeyName
    {
        get => new TerraformReference<string>(this, "customer_managed_key_name");
        set => SetArgument("customer_managed_key_name", value);
    }

    /// <summary>
    /// The customer_managed_key_versionless_id attribute.
    /// </summary>
    [TerraformArgument("customer_managed_key_versionless_id")]
    public TerraformValue<string>? CustomerManagedKeyVersionlessId
    {
        get => new TerraformReference<string>(this, "customer_managed_key_versionless_id");
        set => SetArgument("customer_managed_key_versionless_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    [TerraformArgument("synapse_workspace_id")]
    public required TerraformValue<string> SynapseWorkspaceId
    {
        get => new TerraformReference<string>(this, "synapse_workspace_id");
        set => SetArgument("synapse_workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSynapseWorkspaceKeyTimeoutsBlock Timeouts { get; set; } = new();

}
