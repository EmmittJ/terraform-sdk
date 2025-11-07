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
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The base_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BasePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("base_path");
        set => this.WithProperty("base_path", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainNameId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name_id");
        set => this.WithProperty("domain_name_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stage_name");
        set => this.WithProperty("stage_name", value);
    }

}
