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
        get => new TerraformReference<string>(this, "data_collection_endpoint_id");
        set => SetArgument("data_collection_endpoint_id", value);
    }

    /// <summary>
    /// The data_collection_rule_id attribute.
    /// </summary>
    public TerraformValue<string>? DataCollectionRuleId
    {
        get => new TerraformReference<string>(this, "data_collection_rule_id");
        set => SetArgument("data_collection_rule_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformValue<string> TargetResourceId
    {
        get => new TerraformReference<string>(this, "target_resource_id");
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
