using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codecommit_approval_rule_template_association resource.
/// </summary>
public class AwsCodecommitApprovalRuleTemplateAssociation : TerraformResource
{
    public AwsCodecommitApprovalRuleTemplateAssociation(string name) : base("aws_codecommit_approval_rule_template_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The approval_rule_template_name attribute.
    /// </summary>
    public string? ApprovalRuleTemplateName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("approval_rule_template_name")?.Value;
        set => this.WithProperty("approval_rule_template_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The repository_name attribute.
    /// </summary>
    public string? RepositoryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_name")?.Value;
        set => this.WithProperty("repository_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
