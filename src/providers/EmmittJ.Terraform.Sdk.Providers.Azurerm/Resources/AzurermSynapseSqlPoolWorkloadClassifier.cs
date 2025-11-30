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
        get => new TerraformReference<string>(this, "context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string>? EndTime
    {
        get => new TerraformReference<string>(this, "end_time");
        set => SetArgument("end_time", value);
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
    /// The importance attribute.
    /// </summary>
    public TerraformValue<string>? Importance
    {
        get => new TerraformReference<string>(this, "importance");
        set => SetArgument("importance", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The member_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberName is required")]
    public required TerraformValue<string> MemberName
    {
        get => new TerraformReference<string>(this, "member_name");
        set => SetArgument("member_name", value);
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
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The workload_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadGroupId is required")]
    public required TerraformValue<string> WorkloadGroupId
    {
        get => new TerraformReference<string>(this, "workload_group_id");
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
