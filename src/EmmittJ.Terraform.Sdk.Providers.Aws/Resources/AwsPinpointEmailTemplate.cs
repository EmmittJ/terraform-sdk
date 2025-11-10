using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for email_template in .
/// Nesting mode: list
/// </summary>
public class AwsPinpointEmailTemplateEmailTemplateBlock : TerraformBlock
{
    /// <summary>
    /// The default_substitutions attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultSubstitutions
    {
        get => GetProperty<TerraformProperty<string>>("default_substitutions");
        set => WithProperty("default_substitutions", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The html_part attribute.
    /// </summary>
    public TerraformProperty<string>? HtmlPart
    {
        get => GetProperty<TerraformProperty<string>>("html_part");
        set => WithProperty("html_part", value);
    }

    /// <summary>
    /// The recommender_id attribute.
    /// </summary>
    public TerraformProperty<string>? RecommenderId
    {
        get => GetProperty<TerraformProperty<string>>("recommender_id");
        set => WithProperty("recommender_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformProperty<string>? Subject
    {
        get => GetProperty<TerraformProperty<string>>("subject");
        set => WithProperty("subject", value);
    }

    /// <summary>
    /// The text_part attribute.
    /// </summary>
    public TerraformProperty<string>? TextPart
    {
        get => GetProperty<TerraformProperty<string>>("text_part");
        set => WithProperty("text_part", value);
    }

}

/// <summary>
/// Manages a aws_pinpoint_email_template resource.
/// </summary>
public class AwsPinpointEmailTemplate : TerraformResource
{
    public AwsPinpointEmailTemplate(string name) : base("aws_pinpoint_email_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("tags_all");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateName is required")]
    public required TerraformProperty<string> TemplateName
    {
        get => GetProperty<TerraformProperty<string>>("template_name");
        set => this.WithProperty("template_name", value);
    }

    /// <summary>
    /// Block for email_template.
    /// Nesting mode: list
    /// </summary>
    public List<AwsPinpointEmailTemplateEmailTemplateBlock>? EmailTemplate
    {
        get => GetProperty<List<AwsPinpointEmailTemplateEmailTemplateBlock>>("email_template");
        set => this.WithProperty("email_template", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
