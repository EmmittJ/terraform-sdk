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
        SetOutput("body");
        SetOutput("api_id");
        SetOutput("export_version");
        SetOutput("id");
        SetOutput("include_extensions");
        SetOutput("output_type");
        SetOutput("region");
        SetOutput("specification");
        SetOutput("stage_name");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_id");
        set => SetProperty("api_id", value);
    }

    /// <summary>
    /// The export_version attribute.
    /// </summary>
    public TerraformProperty<string> ExportVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("export_version");
        set => SetProperty("export_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The include_extensions attribute.
    /// </summary>
    public TerraformProperty<bool> IncludeExtensions
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_extensions");
        set => SetProperty("include_extensions", value);
    }

    /// <summary>
    /// The output_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputType is required")]
    public required TerraformProperty<string> OutputType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("output_type");
        set => SetProperty("output_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The specification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Specification is required")]
    public required TerraformProperty<string> Specification
    {
        get => GetRequiredOutput<TerraformProperty<string>>("specification");
        set => SetProperty("specification", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    public TerraformProperty<string> StageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stage_name");
        set => SetProperty("stage_name", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformExpression Body => this["body"];

}
