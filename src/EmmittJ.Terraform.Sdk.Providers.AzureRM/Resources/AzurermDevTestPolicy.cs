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
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The evaluator_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EvaluatorType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("evaluator_type");
        set => this.WithProperty("evaluator_type", value);
    }

    /// <summary>
    /// The fact_data attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FactData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fact_data");
        set => this.WithProperty("fact_data", value);
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
    /// The lab_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LabName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lab_name");
        set => this.WithProperty("lab_name", value);
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
    /// The policy_set_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicySetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_set_name");
        set => this.WithProperty("policy_set_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Threshold
    {
        get => GetProperty<TerraformLiteralProperty<string>>("threshold");
        set => this.WithProperty("threshold", value);
    }

}
