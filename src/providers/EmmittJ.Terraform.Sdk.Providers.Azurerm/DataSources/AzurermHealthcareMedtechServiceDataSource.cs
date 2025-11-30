using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermHealthcareMedtechServiceDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_healthcare_medtech_service Terraform data source.
/// Retrieves information about a azurerm_healthcare_medtech_service.
/// </summary>
public partial class AzurermHealthcareMedtechServiceDataSource(string name) : TerraformDataSource("azurerm_healthcare_medtech_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The device_mapping_json attribute.
    /// </summary>
    public TerraformValue<string> DeviceMappingJson
    {
        get => new TerraformReference<string>(this, "device_mapping_json");
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    public TerraformValue<string> EventhubConsumerGroupName
    {
        get => new TerraformReference<string>(this, "eventhub_consumer_group_name");
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public TerraformValue<string> EventhubName
    {
        get => new TerraformReference<string>(this, "eventhub_name");
    }

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    public TerraformValue<string> EventhubNamespaceName
    {
        get => new TerraformReference<string>(this, "eventhub_namespace_name");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHealthcareMedtechServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHealthcareMedtechServiceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
