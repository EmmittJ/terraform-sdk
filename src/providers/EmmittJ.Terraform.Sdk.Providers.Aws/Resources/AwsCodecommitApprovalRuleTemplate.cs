using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codecommit_approval_rule_template resource.
/// </summary>
public class AwsCodecommitApprovalRuleTemplate : TerraformResource
{
    public AwsCodecommitApprovalRuleTemplate(string name) : base("aws_codecommit_approval_rule_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputpproval_rule_template_id");
        this.WithOutputreation_date");
        this.WithOutputast_modified_date");
        this.WithOutputast_modified_user");
        this.WithOutputule_content_sha256");
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformProperty<string> Content
    {
        get => GetRequiredProperty<TerraformProperty<string>>("content");
        set => this.WithProperty("content", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The approval_rule_template_id attribute.
    /// </summary>
    public TerraformExpression ApprovalRuleTemplateId => this["approval_rule_template_id"];

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformExpression LastModifiedDate => this["last_modified_date"];

    /// <summary>
    /// The last_modified_user attribute.
    /// </summary>
    public TerraformExpression LastModifiedUser => this["last_modified_user"];

    /// <summary>
    /// The rule_content_sha256 attribute.
    /// </summary>
    public TerraformExpression RuleContentSha256 => this["rule_content_sha256"];

}
