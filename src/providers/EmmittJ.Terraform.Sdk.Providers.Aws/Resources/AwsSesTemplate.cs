using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ses_template Terraform resource.
/// Manages a aws_ses_template resource.
/// </summary>
public partial class AwsSesTemplate(string name) : TerraformResource("aws_ses_template", name)
{
    /// <summary>
    /// The html attribute.
    /// </summary>
    public TerraformValue<string>? Html
    {
        get => new TerraformReference<string>(this, "html");
        set => SetArgument("html", value);
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
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string>? Subject
    {
        get => new TerraformReference<string>(this, "subject");
        set => SetArgument("subject", value);
    }

    /// <summary>
    /// The text attribute.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => new TerraformReference<string>(this, "text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
