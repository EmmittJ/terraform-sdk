using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_apigatewayv2_export.
/// </summary>
public class AwsApigatewayv2ExportDataSource : TerraformDataSource
{
    public AwsApigatewayv2ExportDataSource(string name) : base("aws_apigatewayv2_export", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("body");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The export_version attribute.
    /// </summary>
    public TerraformProperty<string>? ExportVersion
    {
        get => GetProperty<TerraformProperty<string>>("export_version");
        set => this.WithProperty("export_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The include_extensions attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeExtensions
    {
        get => GetProperty<TerraformProperty<bool>>("include_extensions");
        set => this.WithProperty("include_extensions", value);
    }

    /// <summary>
    /// The output_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputType is required")]
    public required TerraformProperty<string> OutputType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("output_type");
        set => this.WithProperty("output_type", value);
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
    /// The specification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Specification is required")]
    public required TerraformProperty<string> Specification
    {
        get => GetRequiredProperty<TerraformProperty<string>>("specification");
        set => this.WithProperty("specification", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    public TerraformProperty<string>? StageName
    {
        get => GetProperty<TerraformProperty<string>>("stage_name");
        set => this.WithProperty("stage_name", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformExpression Body => this["body"];

}
