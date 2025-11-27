using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_codecommit_approval_rule_template Terraform resource.
/// Manages a aws_codecommit_approval_rule_template resource.
/// </summary>
public partial class AwsCodecommitApprovalRuleTemplate(string name) : TerraformResource("aws_codecommit_approval_rule_template", name)
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The approval_rule_template_id attribute.
    /// </summary>
    public TerraformValue<string> ApprovalRuleTemplateId
    {
        get => new TerraformReference<string>(this, "approval_rule_template_id");
    }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
    {
        get => new TerraformReference<string>(this, "creation_date");
    }

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedDate
    {
        get => new TerraformReference<string>(this, "last_modified_date");
    }

    /// <summary>
    /// The last_modified_user attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedUser
    {
        get => new TerraformReference<string>(this, "last_modified_user");
    }

    /// <summary>
    /// The rule_content_sha256 attribute.
    /// </summary>
    public TerraformValue<string> RuleContentSha256
    {
        get => new TerraformReference<string>(this, "rule_content_sha256");
    }

}
