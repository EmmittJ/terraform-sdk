using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_export Terraform data source.
/// Retrieves information about a aws_api_gateway_export.
/// </summary>
public partial class AwsApiGatewayExportDataSource(string name) : TerraformDataSource("aws_api_gateway_export", name)
{
    /// <summary>
    /// The accepts attribute.
    /// </summary>
    public TerraformValue<string>? Accepts
    {
        get => new TerraformReference<string>(this, "accepts");
        set => SetArgument("accepts", value);
    }

    /// <summary>
    /// The export_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportType is required")]
    public required TerraformValue<string> ExportType
    {
        get => new TerraformReference<string>(this, "export_type");
        set => SetArgument("export_type", value);
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
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
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
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformValue<string> RestApiId
    {
        get => new TerraformReference<string>(this, "rest_api_id");
        set => SetArgument("rest_api_id", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    public required TerraformValue<string> StageName
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

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public TerraformValue<string> ContentDisposition
    {
        get => new TerraformReference<string>(this, "content_disposition");
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformValue<string> ContentType
    {
        get => new TerraformReference<string>(this, "content_type");
    }

}
