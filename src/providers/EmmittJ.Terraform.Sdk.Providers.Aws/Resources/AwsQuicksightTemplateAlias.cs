using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_quicksight_template_alias Terraform resource.
/// Manages a aws_quicksight_template_alias resource.
/// </summary>
public partial class AwsQuicksightTemplateAlias(string name) : TerraformResource("aws_quicksight_template_alias", name)
{
    /// <summary>
    /// The alias_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AliasName is required")]
    public required TerraformValue<string> AliasName
    {
        get => new TerraformReference<string>(this, "alias_name");
        set => SetArgument("alias_name", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => new TerraformReference<string>(this, "aws_account_id");
        set => SetArgument("aws_account_id", value);
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
    /// The template_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateId is required")]
    public required TerraformValue<string> TemplateId
    {
        get => new TerraformReference<string>(this, "template_id");
        set => SetArgument("template_id", value);
    }

    /// <summary>
    /// The template_version_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateVersionNumber is required")]
    public required TerraformValue<double> TemplateVersionNumber
    {
        get => new TerraformReference<double>(this, "template_version_number");
        set => SetArgument("template_version_number", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

}
