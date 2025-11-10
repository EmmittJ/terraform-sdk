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
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        set => SetProperty("priority", value);
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
        SetOutput("json");
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    public List<AwsEcrLifecyclePolicyDocumentDataSourceRuleBlock>? Rule
    {
        set => SetProperty("rule", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

}
