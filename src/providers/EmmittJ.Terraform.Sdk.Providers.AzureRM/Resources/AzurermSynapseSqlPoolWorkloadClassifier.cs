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
public class AzurermSynapseSqlPoolWorkloadClassifierTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_synapse_sql_pool_workload_classifier resource.
/// </summary>
public class AzurermSynapseSqlPoolWorkloadClassifier : TerraformResource
{
    public AzurermSynapseSqlPoolWorkloadClassifier(string name) : base("azurerm_synapse_sql_pool_workload_classifier", name)
    {
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    [TerraformArgument("context")]
    public TerraformValue<string>? Context
    {
        get => new TerraformReference<string>(this, "context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformArgument("end_time")]
    public TerraformValue<string>? EndTime
    {
        get => new TerraformReference<string>(this, "end_time");
        set => SetArgument("end_time", value);
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
    /// The importance attribute.
    /// </summary>
    [TerraformArgument("importance")]
    public TerraformValue<string>? Importance
    {
        get => new TerraformReference<string>(this, "importance");
        set => SetArgument("importance", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformArgument("label")]
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The member_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberName is required")]
    [TerraformArgument("member_name")]
    public required TerraformValue<string> MemberName
    {
        get => new TerraformReference<string>(this, "member_name");
        set => SetArgument("member_name", value);
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
    /// The start_time attribute.
    /// </summary>
    [TerraformArgument("start_time")]
    public TerraformValue<string>? StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The workload_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadGroupId is required")]
    [TerraformArgument("workload_group_id")]
    public required TerraformValue<string> WorkloadGroupId
    {
        get => new TerraformReference<string>(this, "workload_group_id");
        set => SetArgument("workload_group_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSynapseSqlPoolWorkloadClassifierTimeoutsBlock Timeouts { get; set; } = new();

}
