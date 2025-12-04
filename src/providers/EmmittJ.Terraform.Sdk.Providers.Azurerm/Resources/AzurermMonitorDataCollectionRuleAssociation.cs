using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMonitorDataCollectionRuleAssociation.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDataCollectionRuleAssociationTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_monitor_data_collection_rule_association Terraform resource.
/// Manages a azurerm_monitor_data_collection_rule_association resource.
/// </summary>
public partial class AzurermMonitorDataCollectionRuleAssociation(string name) : TerraformResource("azurerm_monitor_data_collection_rule_association", name)
{
    /// <summary>
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? DataCollectionEndpointId
    {
        get => GetArgument<TerraformValue<string>>("data_collection_endpoint_id");
        set => SetArgument("data_collection_endpoint_id", value);
    }

    /// <summary>
    /// The data_collection_rule_id attribute.
    /// </summary>
    public TerraformValue<string>? DataCollectionRuleId
    {
        get => GetArgument<TerraformValue<string>>("data_collection_rule_id");
        set => SetArgument("data_collection_rule_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformValue<string> TargetResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorDataCollectionRuleAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorDataCollectionRuleAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
