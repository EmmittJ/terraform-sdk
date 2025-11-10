using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_template_alias resource.
/// </summary>
public class AwsQuicksightTemplateAlias : TerraformResource
{
    public AwsQuicksightTemplateAlias(string name) : base("aws_quicksight_template_alias", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("id");
    }

    /// <summary>
    /// The alias_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AliasName is required")]
    public required TerraformProperty<string> AliasName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("alias_name");
        set => this.WithProperty("alias_name", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
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
    /// The template_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateId is required")]
    public required TerraformProperty<string> TemplateId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("template_id");
        set => this.WithProperty("template_id", value);
    }

    /// <summary>
    /// The template_version_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateVersionNumber is required")]
    public required TerraformProperty<double> TemplateVersionNumber
    {
        get => GetRequiredProperty<TerraformProperty<double>>("template_version_number");
        set => this.WithProperty("template_version_number", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
