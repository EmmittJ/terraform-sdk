using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssm_parameters_by_path Terraform data source.
/// Retrieves information about a aws_ssm_parameters_by_path.
/// </summary>
public partial class AwsSsmParametersByPathDataSource(string name) : TerraformDataSource("aws_ssm_parameters_by_path", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The recursive attribute.
    /// </summary>
    public TerraformValue<bool>? Recursive
    {
        get => new TerraformReference<bool>(this, "recursive");
        set => SetArgument("recursive", value);
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
    /// The with_decryption attribute.
    /// </summary>
    public TerraformValue<bool>? WithDecryption
    {
        get => new TerraformReference<bool>(this, "with_decryption");
        set => SetArgument("with_decryption", value);
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformList<string> Arns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformList<string> Names
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The types attribute.
    /// </summary>
    public TerraformList<string> Types
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformList<string> ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
    }

}
