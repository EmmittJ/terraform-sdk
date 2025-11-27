using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_apigatewayv2_export Terraform data source.
/// Retrieves information about a aws_apigatewayv2_export.
/// </summary>
public partial class AwsApigatewayv2ExportDataSource(string name) : TerraformDataSource("aws_apigatewayv2_export", name)
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => new TerraformReference<string>(this, "api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The export_version attribute.
    /// </summary>
    public TerraformValue<string>? ExportVersion
    {
        get => new TerraformReference<string>(this, "export_version");
        set => SetArgument("export_version", value);
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
    /// The include_extensions attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeExtensions
    {
        get => new TerraformReference<bool>(this, "include_extensions");
        set => SetArgument("include_extensions", value);
    }

    /// <summary>
    /// The output_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputType is required")]
    public required TerraformValue<string> OutputType
    {
        get => new TerraformReference<string>(this, "output_type");
        set => SetArgument("output_type", value);
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
    /// The specification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Specification is required")]
    public required TerraformValue<string> Specification
    {
        get => new TerraformReference<string>(this, "specification");
        set => SetArgument("specification", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    public TerraformValue<string>? StageName
    {
        get => new TerraformReference<string>(this, "stage_name");
        set => SetArgument("stage_name", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformValue<string> Body
    {
        get => new TerraformReference<string>(this, "body");
    }

}
