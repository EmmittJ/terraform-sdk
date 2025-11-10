using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_export.
/// </summary>
public class AwsApiGatewayExportDataSource : TerraformDataSource
{
    public AwsApiGatewayExportDataSource(string name) : base("aws_api_gateway_export", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("body");
        SetOutput("content_disposition");
        SetOutput("content_type");
        SetOutput("accepts");
        SetOutput("export_type");
        SetOutput("id");
        SetOutput("parameters");
        SetOutput("region");
        SetOutput("rest_api_id");
        SetOutput("stage_name");
    }

    /// <summary>
    /// The accepts attribute.
    /// </summary>
    public TerraformProperty<string> Accepts
    {
        get => GetRequiredOutput<TerraformProperty<string>>("accepts");
        set => SetProperty("accepts", value);
    }

    /// <summary>
    /// The export_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportType is required")]
    public required TerraformProperty<string> ExportType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("export_type");
        set => SetProperty("export_type", value);
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
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
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rest_api_id");
        set => SetProperty("rest_api_id", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    public required TerraformProperty<string> StageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stage_name");
        set => SetProperty("stage_name", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformExpression Body => this["body"];

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public TerraformExpression ContentDisposition => this["content_disposition"];

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformExpression ContentType => this["content_type"];

}
