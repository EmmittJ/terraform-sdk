using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayRestApiEndpointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Types is required")]
    public List<TerraformProperty<string>>? Types
    {
        get => GetProperty<List<TerraformProperty<string>>>("types");
        set => WithProperty("types", value);
    }

    /// <summary>
    /// The vpc_endpoint_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcEndpointIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_endpoint_ids");
        set => WithProperty("vpc_endpoint_ids", value);
    }

}

/// <summary>
/// Manages a aws_api_gateway_rest_api resource.
/// </summary>
public class AwsApiGatewayRestApi : TerraformResource
{
    public AwsApiGatewayRestApi(string name) : base("aws_api_gateway_rest_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_date");
        this.DeclareOutput("execution_arn");
        this.DeclareOutput("root_resource_id");
    }

    /// <summary>
    /// The api_key_source attribute.
    /// </summary>
    public TerraformProperty<string>? ApiKeySource
    {
        get => GetProperty<TerraformProperty<string>>("api_key_source");
        set => this.WithProperty("api_key_source", value);
    }

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? BinaryMediaTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("binary_media_types");
        set => this.WithProperty("binary_media_types", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformProperty<string>? Body
    {
        get => GetProperty<TerraformProperty<string>>("body");
        set => this.WithProperty("body", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableExecuteApiEndpoint
    {
        get => GetProperty<TerraformProperty<bool>>("disable_execute_api_endpoint");
        set => this.WithProperty("disable_execute_api_endpoint", value);
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public TerraformProperty<bool>? FailOnWarnings
    {
        get => GetProperty<TerraformProperty<bool>>("fail_on_warnings");
        set => this.WithProperty("fail_on_warnings", value);
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
    /// The minimum_compression_size attribute.
    /// </summary>
    public TerraformProperty<string>? MinimumCompressionSize
    {
        get => GetProperty<TerraformProperty<string>>("minimum_compression_size");
        set => this.WithProperty("minimum_compression_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// The put_rest_api_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PutRestApiMode
    {
        get => GetProperty<TerraformProperty<string>>("put_rest_api_mode");
        set => this.WithProperty("put_rest_api_mode", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfiguration block(s) allowed")]
    public List<AwsApiGatewayRestApiEndpointConfigurationBlock>? EndpointConfiguration
    {
        get => GetProperty<List<AwsApiGatewayRestApiEndpointConfigurationBlock>>("endpoint_configuration");
        set => this.WithProperty("endpoint_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformExpression ExecutionArn => this["execution_arn"];

    /// <summary>
    /// The root_resource_id attribute.
    /// </summary>
    public TerraformExpression RootResourceId => this["root_resource_id"];

}
