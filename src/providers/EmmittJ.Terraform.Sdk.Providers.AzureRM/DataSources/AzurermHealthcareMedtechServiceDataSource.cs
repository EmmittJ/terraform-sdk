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
public class AzurermHealthcareMedtechServiceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_healthcare_medtech_service.
/// </summary>
public class AzurermHealthcareMedtechServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareMedtechServiceDataSource(string name) : base("azurerm_healthcare_medtech_service", name)
    {
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
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformArgument("workspace_id")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermHealthcareMedtechServiceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The device_mapping_json attribute.
    /// </summary>
    [TerraformArgument("device_mapping_json")]
    public TerraformValue<string> DeviceMappingJson
    {
        get => new TerraformReference<string>(this, "device_mapping_json");
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [TerraformArgument("eventhub_consumer_group_name")]
    public TerraformValue<string> EventhubConsumerGroupName
    {
        get => new TerraformReference<string>(this, "eventhub_consumer_group_name");
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [TerraformArgument("eventhub_name")]
    public TerraformValue<string> EventhubName
    {
        get => new TerraformReference<string>(this, "eventhub_name");
    }

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    [TerraformArgument("eventhub_namespace_name")]
    public TerraformValue<string> EventhubNamespaceName
    {
        get => new TerraformReference<string>(this, "eventhub_namespace_name");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

}
