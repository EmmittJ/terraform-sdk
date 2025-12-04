using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSynapseSqlPoolWorkloadClassifier.
/// Nesting mode: single
/// </summary>
public class AzurermSynapseSqlPoolWorkloadClassifierTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_synapse_sql_pool_workload_classifier Terraform resource.
/// Manages a azurerm_synapse_sql_pool_workload_classifier resource.
/// </summary>
public partial class AzurermSynapseSqlPoolWorkloadClassifier(string name) : TerraformResource("azurerm_synapse_sql_pool_workload_classifier", name)
{
    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformValue<string>? Context
    {
        get => GetArgument<TerraformValue<string>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string>? EndTime
    {
        get => GetArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The importance attribute.
    /// </summary>
    public TerraformValue<string>? Importance
    {
        get => GetArgument<TerraformValue<string>>("importance");
        set => SetArgument("importance", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => GetArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The member_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberName is required")]
    public required TerraformValue<string> MemberName
    {
        get => GetArgument<TerraformValue<string>>("member_name");
        set => SetArgument("member_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The workload_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadGroupId is required")]
    public required TerraformValue<string> WorkloadGroupId
    {
        get => GetArgument<TerraformValue<string>>("workload_group_id");
        set => SetArgument("workload_group_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSynapseSqlPoolWorkloadClassifierTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSynapseSqlPoolWorkloadClassifierTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
