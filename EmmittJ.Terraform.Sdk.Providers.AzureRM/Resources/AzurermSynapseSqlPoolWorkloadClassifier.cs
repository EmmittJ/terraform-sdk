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
    public string? Context
    {
        get => GetProperty<TerraformLiteralProperty<string>>("context")?.Value;
        set => this.WithProperty("context", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public string? EndTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_time")?.Value;
        set => this.WithProperty("end_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The importance attribute.
    /// </summary>
    public string? Importance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("importance")?.Value;
        set => this.WithProperty("importance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public string? Label
    {
        get => GetProperty<TerraformLiteralProperty<string>>("label")?.Value;
        set => this.WithProperty("label", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The member_name attribute.
    /// </summary>
    public string? MemberName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member_name")?.Value;
        set => this.WithProperty("member_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public string? StartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_time")?.Value;
        set => this.WithProperty("start_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workload_group_id attribute.
    /// </summary>
    public string? WorkloadGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workload_group_id")?.Value;
        set => this.WithProperty("workload_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
