using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dev_test_policy resource.
/// </summary>
public class AzurermDevTestPolicy : TerraformResource
{
    public AzurermDevTestPolicy(string name) : base("azurerm_dev_test_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The evaluator_type attribute.
    /// </summary>
    public string? EvaluatorType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("evaluator_type")?.Value;
        set => this.WithProperty("evaluator_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fact_data attribute.
    /// </summary>
    public string? FactData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fact_data")?.Value;
        set => this.WithProperty("fact_data", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The lab_name attribute.
    /// </summary>
    public string? LabName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lab_name")?.Value;
        set => this.WithProperty("lab_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The policy_set_name attribute.
    /// </summary>
    public string? PolicySetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_set_name")?.Value;
        set => this.WithProperty("policy_set_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    public string? Threshold
    {
        get => GetProperty<TerraformLiteralProperty<string>>("threshold")?.Value;
        set => this.WithProperty("threshold", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
