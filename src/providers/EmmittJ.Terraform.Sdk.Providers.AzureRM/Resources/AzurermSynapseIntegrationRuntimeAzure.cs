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
public class AzurermSynapseIntegrationRuntimeAzureTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_synapse_integration_runtime_azure resource.
/// </summary>
public class AzurermSynapseIntegrationRuntimeAzure : TerraformResource
{
    public AzurermSynapseIntegrationRuntimeAzure(string name) : base("azurerm_synapse_integration_runtime_azure", name)
    {
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [TerraformArgument("compute_type")]
    public TerraformValue<string>? ComputeType
    {
        get => new TerraformReference<string>(this, "compute_type");
        set => SetArgument("compute_type", value);
    }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    [TerraformArgument("core_count")]
    public TerraformValue<double>? CoreCount
    {
        get => new TerraformReference<double>(this, "core_count");
        set => SetArgument("core_count", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The time_to_live_min attribute.
    /// </summary>
    [TerraformArgument("time_to_live_min")]
    public TerraformValue<double>? TimeToLiveMin
    {
        get => new TerraformReference<double>(this, "time_to_live_min");
        set => SetArgument("time_to_live_min", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSynapseIntegrationRuntimeAzureTimeoutsBlock Timeouts { get; set; } = new();

}
