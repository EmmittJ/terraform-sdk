using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevTestPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The evaluator_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluatorType is required")]
    public required TerraformProperty<string> EvaluatorType
    {
        get => GetProperty<TerraformProperty<string>>("evaluator_type");
        set => this.WithProperty("evaluator_type", value);
    }

    /// <summary>
    /// The fact_data attribute.
    /// </summary>
    public TerraformProperty<string>? FactData
    {
        get => GetProperty<TerraformProperty<string>>("fact_data");
        set => this.WithProperty("fact_data", value);
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
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    public required TerraformProperty<string> LabName
    {
        get => GetProperty<TerraformProperty<string>>("lab_name");
        set => this.WithProperty("lab_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The policy_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicySetName is required")]
    public required TerraformProperty<string> PolicySetName
    {
        get => GetProperty<TerraformProperty<string>>("policy_set_name");
        set => this.WithProperty("policy_set_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformProperty<string> Threshold
    {
        get => GetProperty<TerraformProperty<string>>("threshold");
        set => this.WithProperty("threshold", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDevTestPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDevTestPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
