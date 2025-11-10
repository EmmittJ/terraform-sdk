using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseSqlPoolWorkloadClassifierTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_synapse_sql_pool_workload_classifier resource.
/// </summary>
public class AzurermSynapseSqlPoolWorkloadClassifier : TerraformResource
{
    public AzurermSynapseSqlPoolWorkloadClassifier(string name) : base("azurerm_synapse_sql_pool_workload_classifier", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("context");
        SetOutput("end_time");
        SetOutput("id");
        SetOutput("importance");
        SetOutput("label");
        SetOutput("member_name");
        SetOutput("name");
        SetOutput("start_time");
        SetOutput("workload_group_id");
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformProperty<string> Context
    {
        get => GetRequiredOutput<TerraformProperty<string>>("context");
        set => SetProperty("context", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformProperty<string> EndTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("end_time");
        set => SetProperty("end_time", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The importance attribute.
    /// </summary>
    public TerraformProperty<string> Importance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("importance");
        set => SetProperty("importance", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformProperty<string> Label
    {
        get => GetRequiredOutput<TerraformProperty<string>>("label");
        set => SetProperty("label", value);
    }

    /// <summary>
    /// The member_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberName is required")]
    public required TerraformProperty<string> MemberName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("member_name");
        set => SetProperty("member_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string> StartTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_time");
        set => SetProperty("start_time", value);
    }

    /// <summary>
    /// The workload_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadGroupId is required")]
    public required TerraformProperty<string> WorkloadGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workload_group_id");
        set => SetProperty("workload_group_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseSqlPoolWorkloadClassifierTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
