using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_base_path_mapping resource.
/// </summary>
public class AwsApiGatewayBasePathMapping : TerraformResource
{
    public AwsApiGatewayBasePathMapping(string name) : base("aws_api_gateway_base_path_mapping", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_id");
        SetOutput("base_path");
        SetOutput("domain_name");
        SetOutput("domain_name_id");
        SetOutput("id");
        SetOutput("region");
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
    /// The base_path attribute.
    /// </summary>
    public TerraformProperty<string> BasePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("base_path");
        set => SetProperty("base_path", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    public TerraformProperty<string> DomainNameId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name_id");
        set => SetProperty("domain_name_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    public TerraformProperty<string> StageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stage_name");
        set => SetProperty("stage_name", value);
    }

}
