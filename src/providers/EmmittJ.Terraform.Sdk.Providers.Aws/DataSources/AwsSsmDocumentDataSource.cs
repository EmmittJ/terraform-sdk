using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssm_document Terraform data source.
/// Retrieves information about a aws_ssm_document.
/// </summary>
public partial class AwsSsmDocumentDataSource(string name) : TerraformDataSource("aws_ssm_document", name)
{
    /// <summary>
    /// The document_format attribute.
    /// </summary>
    public TerraformValue<string>? DocumentFormat
    {
        get => GetArgument<TerraformValue<string>>("document_format");
        set => SetArgument("document_format", value);
    }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public TerraformValue<string>? DocumentVersion
    {
        get => GetArgument<TerraformValue<string>>("document_version");
        set => SetArgument("document_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformValue<string> Content
        => CreateReference("content");

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    public TerraformValue<string> DocumentType
        => CreateReference("document_type");

}
