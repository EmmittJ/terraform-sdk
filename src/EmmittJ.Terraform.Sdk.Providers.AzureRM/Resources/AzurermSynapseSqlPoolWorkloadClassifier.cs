using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformProperty<string>? Context
    {
        get => GetProperty<TerraformProperty<string>>("context");
        set => this.WithProperty("context", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformProperty<string>? EndTime
    {
        get => GetProperty<TerraformProperty<string>>("end_time");
        set => this.WithProperty("end_time", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The importance attribute.
    /// </summary>
    public TerraformProperty<string>? Importance
    {
        get => GetProperty<TerraformProperty<string>>("importance");
        set => this.WithProperty("importance", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformProperty<string>? Label
    {
        get => GetProperty<TerraformProperty<string>>("label");
        set => this.WithProperty("label", value);
    }

    /// <summary>
    /// The member_name attribute.
    /// </summary>
    public TerraformProperty<string>? MemberName
    {
        get => GetProperty<TerraformProperty<string>>("member_name");
        set => this.WithProperty("member_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => this.WithProperty("start_time", value);
    }

    /// <summary>
    /// The workload_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkloadGroupId
    {
        get => GetProperty<TerraformProperty<string>>("workload_group_id");
        set => this.WithProperty("workload_group_id", value);
    }

}
