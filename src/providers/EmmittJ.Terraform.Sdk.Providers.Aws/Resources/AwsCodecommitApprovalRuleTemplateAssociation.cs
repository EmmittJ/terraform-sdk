using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_codecommit_approval_rule_template_association Terraform resource.
/// Manages a aws_codecommit_approval_rule_template_association resource.
/// </summary>
public partial class AwsCodecommitApprovalRuleTemplateAssociation(string name) : TerraformResource("aws_codecommit_approval_rule_template_association", name)
{
    /// <summary>
    /// The approval_rule_template_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApprovalRuleTemplateName is required")]
    public required TerraformValue<string> ApprovalRuleTemplateName
    {
        get => GetArgument<TerraformValue<string>>("approval_rule_template_name");
        set => SetArgument("approval_rule_template_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => GetArgument<TerraformValue<string>>("repository_name");
        set => SetArgument("repository_name", value);
    }

}
