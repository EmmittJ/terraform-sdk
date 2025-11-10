using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public class AwsEcrLifecyclePolicyDocumentDataSourceRuleBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

}

/// <summary>
/// Retrieves information about a aws_ecr_lifecycle_policy_document.
/// </summary>
public class AwsEcrLifecyclePolicyDocumentDataSource : TerraformDataSource
{
    public AwsEcrLifecyclePolicyDocumentDataSource(string name) : base("aws_ecr_lifecycle_policy_document", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("json");
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    public List<AwsEcrLifecyclePolicyDocumentDataSourceRuleBlock>? Rule
    {
        get => GetProperty<List<AwsEcrLifecyclePolicyDocumentDataSourceRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

}
