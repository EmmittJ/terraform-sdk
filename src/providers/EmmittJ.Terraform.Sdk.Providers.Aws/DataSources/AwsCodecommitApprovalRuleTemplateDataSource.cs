using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_codecommit_approval_rule_template Terraform data source.
/// Retrieves information about a aws_codecommit_approval_rule_template.
/// </summary>
public partial class AwsCodecommitApprovalRuleTemplateDataSource(string name) : TerraformDataSource("aws_codecommit_approval_rule_template", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The approval_rule_template_id attribute.
    /// </summary>
    public TerraformValue<string> ApprovalRuleTemplateId
        => AsReference("approval_rule_template_id");

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformValue<string> Content
        => AsReference("content");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
        => AsReference("creation_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedDate
        => AsReference("last_modified_date");

    /// <summary>
    /// The last_modified_user attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedUser
        => AsReference("last_modified_user");

    /// <summary>
    /// The rule_content_sha256 attribute.
    /// </summary>
    public TerraformValue<string> RuleContentSha256
        => AsReference("rule_content_sha256");

}
