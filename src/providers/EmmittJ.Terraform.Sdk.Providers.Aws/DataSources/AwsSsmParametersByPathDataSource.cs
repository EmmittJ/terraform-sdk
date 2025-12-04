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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetRequiredArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The recursive attribute.
    /// </summary>
    public TerraformValue<bool>? Recursive
    {
        get => GetArgument<TerraformValue<bool>>("recursive");
        set => SetArgument("recursive", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The with_decryption attribute.
    /// </summary>
    public TerraformValue<bool>? WithDecryption
    {
        get => GetArgument<TerraformValue<bool>>("with_decryption");
        set => SetArgument("with_decryption", value);
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformList<string> Arns
        => AsReference("arns");

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformList<string> Names
        => AsReference("names");

    /// <summary>
    /// The types attribute.
    /// </summary>
    public TerraformList<string> Types
        => AsReference("types");

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformList<string> ValuesAttribute
        => AsReference("values");

}
