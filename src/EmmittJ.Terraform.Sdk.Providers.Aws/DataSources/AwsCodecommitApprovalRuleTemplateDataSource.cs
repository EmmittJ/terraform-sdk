using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codecommit_approval_rule_template.
/// </summary>
public class AwsCodecommitApprovalRuleTemplateDataSource : TerraformDataSource
{
    public AwsCodecommitApprovalRuleTemplateDataSource(string name) : base("aws_codecommit_approval_rule_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("approval_rule_template_id");
        this.DeclareOutput("content");
        this.DeclareOutput("creation_date");
        this.DeclareOutput("description");
        this.DeclareOutput("last_modified_date");
        this.DeclareOutput("last_modified_user");
        this.DeclareOutput("rule_content_sha256");
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The approval_rule_template_id attribute.
    /// </summary>
    public TerraformExpression ApprovalRuleTemplateId => this["approval_rule_template_id"];

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformExpression Content => this["content"];

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

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
