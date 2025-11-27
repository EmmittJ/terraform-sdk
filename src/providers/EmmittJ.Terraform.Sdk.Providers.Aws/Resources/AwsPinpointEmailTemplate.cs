using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for email_template in AwsPinpointEmailTemplate.
/// Nesting mode: list
/// </summary>
public class AwsPinpointEmailTemplateEmailTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "email_template";

    /// <summary>
    /// The default_substitutions attribute.
    /// </summary>
    public TerraformValue<string>? DefaultSubstitutions
    {
        get => new TerraformReference<string>(this, "default_substitutions");
        set => SetArgument("default_substitutions", value);
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
    /// The html_part attribute.
    /// </summary>
    public TerraformValue<string>? HtmlPart
    {
        get => new TerraformReference<string>(this, "html_part");
        set => SetArgument("html_part", value);
    }

    /// <summary>
    /// The recommender_id attribute.
    /// </summary>
    public TerraformValue<string>? RecommenderId
    {
        get => new TerraformReference<string>(this, "recommender_id");
        set => SetArgument("recommender_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string>? Subject
    {
        get => new TerraformReference<string>(this, "subject");
        set => SetArgument("subject", value);
    }

    /// <summary>
    /// The text_part attribute.
    /// </summary>
    public TerraformValue<string>? TextPart
    {
        get => new TerraformReference<string>(this, "text_part");
        set => SetArgument("text_part", value);
    }

    /// <summary>
    /// Header block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPinpointEmailTemplateEmailTemplateBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AwsPinpointEmailTemplateEmailTemplateBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

}

/// <summary>
/// Block type for header in AwsPinpointEmailTemplateEmailTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AwsPinpointEmailTemplateEmailTemplateBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_pinpoint_email_template Terraform resource.
/// Manages a aws_pinpoint_email_template resource.
/// </summary>
public partial class AwsPinpointEmailTemplate(string name) : TerraformResource("aws_pinpoint_email_template", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateName is required")]
    public required TerraformValue<string> TemplateName
    {
        get => new TerraformReference<string>(this, "template_name");
        set => SetArgument("template_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// EmailTemplate block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPinpointEmailTemplateEmailTemplateBlock>? EmailTemplate
    {
        get => GetArgument<TerraformList<AwsPinpointEmailTemplateEmailTemplateBlock>>("email_template");
        set => SetArgument("email_template", value);
    }

}
