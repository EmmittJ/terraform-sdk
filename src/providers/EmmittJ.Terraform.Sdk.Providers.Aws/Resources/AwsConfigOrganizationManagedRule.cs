using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsConfigOrganizationManagedRuleTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_config_organization_managed_rule resource.
/// </summary>
public class AwsConfigOrganizationManagedRule : TerraformResource
{
    public AwsConfigOrganizationManagedRule(string name) : base("aws_config_organization_managed_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("description");
        SetOutput("excluded_accounts");
        SetOutput("id");
        SetOutput("input_parameters");
        SetOutput("maximum_execution_frequency");
        SetOutput("name");
        SetOutput("region");
        SetOutput("resource_id_scope");
        SetOutput("resource_types_scope");
        SetOutput("rule_identifier");
        SetOutput("tag_key_scope");
        SetOutput("tag_value_scope");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The excluded_accounts attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ExcludedAccounts
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("excluded_accounts");
        set => SetProperty("excluded_accounts", value);
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
    /// The input_parameters attribute.
    /// </summary>
    public TerraformProperty<string> InputParameters
    {
        get => GetRequiredOutput<TerraformProperty<string>>("input_parameters");
        set => SetProperty("input_parameters", value);
    }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    public TerraformProperty<string> MaximumExecutionFrequency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maximum_execution_frequency");
        set => SetProperty("maximum_execution_frequency", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The resource_id_scope attribute.
    /// </summary>
    public TerraformProperty<string> ResourceIdScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_id_scope");
        set => SetProperty("resource_id_scope", value);
    }

    /// <summary>
    /// The resource_types_scope attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ResourceTypesScope
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("resource_types_scope");
        set => SetProperty("resource_types_scope", value);
    }

    /// <summary>
    /// The rule_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleIdentifier is required")]
    public required TerraformProperty<string> RuleIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule_identifier");
        set => SetProperty("rule_identifier", value);
    }

    /// <summary>
    /// The tag_key_scope attribute.
    /// </summary>
    public TerraformProperty<string> TagKeyScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tag_key_scope");
        set => SetProperty("tag_key_scope", value);
    }

    /// <summary>
    /// The tag_value_scope attribute.
    /// </summary>
    public TerraformProperty<string> TagValueScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tag_value_scope");
        set => SetProperty("tag_value_scope", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsConfigOrganizationManagedRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
