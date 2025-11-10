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
        set => SetProperty("default_substitutions", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The html_part attribute.
    /// </summary>
    public TerraformProperty<string>? HtmlPart
    {
        set => SetProperty("html_part", value);
    }

    /// <summary>
    /// The recommender_id attribute.
    /// </summary>
    public TerraformProperty<string>? RecommenderId
    {
        set => SetProperty("recommender_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformProperty<string>? Subject
    {
        set => SetProperty("subject", value);
    }

    /// <summary>
    /// The text_part attribute.
    /// </summary>
    public TerraformProperty<string>? TextPart
    {
        set => SetProperty("text_part", value);
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
        SetOutput("arn");
        SetOutput("tags_all");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("template_name");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateName is required")]
    public required TerraformProperty<string> TemplateName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_name");
        set => SetProperty("template_name", value);
    }

    /// <summary>
    /// Block for email_template.
    /// Nesting mode: list
    /// </summary>
    public List<AwsPinpointEmailTemplateEmailTemplateBlock>? EmailTemplate
    {
        set => SetProperty("email_template", value);
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
