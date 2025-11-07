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
    public TerraformLiteralProperty<string>? Context
    {
        get => GetProperty<TerraformLiteralProperty<string>>("context");
        set => this.WithProperty("context", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_time");
        set => this.WithProperty("end_time", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The importance attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Importance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("importance");
        set => this.WithProperty("importance", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Label
    {
        get => GetProperty<TerraformLiteralProperty<string>>("label");
        set => this.WithProperty("label", value);
    }

    /// <summary>
    /// The member_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MemberName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member_name");
        set => this.WithProperty("member_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_time");
        set => this.WithProperty("start_time", value);
    }

    /// <summary>
    /// The workload_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkloadGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workload_group_id");
        set => this.WithProperty("workload_group_id", value);
    }

}
