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
        set => SetProperty("ip_address_type", value);
    }

    /// <summary>
    /// The types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Types is required")]
    public List<TerraformProperty<string>>? Types
    {
        set => SetProperty("types", value);
    }

    /// <summary>
    /// The vpc_endpoint_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcEndpointIds
    {
        set => SetProperty("vpc_endpoint_ids", value);
    }

}

/// <summary>
/// Manages a aws_api_gateway_rest_api resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApiGatewayRestApi : TerraformResource
{
    public AwsApiGatewayRestApi(string name) : base("aws_api_gateway_rest_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_date");
        SetOutput("execution_arn");
        SetOutput("root_resource_id");
        SetOutput("api_key_source");
        SetOutput("binary_media_types");
        SetOutput("body");
        SetOutput("description");
        SetOutput("disable_execute_api_endpoint");
        SetOutput("fail_on_warnings");
        SetOutput("id");
        SetOutput("minimum_compression_size");
        SetOutput("name");
        SetOutput("parameters");
        SetOutput("policy");
        SetOutput("put_rest_api_mode");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The api_key_source attribute.
    /// </summary>
    public TerraformProperty<string> ApiKeySource
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_key_source");
        set => SetProperty("api_key_source", value);
    }

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    public List<TerraformProperty<string>> BinaryMediaTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("binary_media_types");
        set => SetProperty("binary_media_types", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformProperty<string> Body
    {
        get => GetRequiredOutput<TerraformProperty<string>>("body");
        set => SetProperty("body", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformProperty<bool> DisableExecuteApiEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_execute_api_endpoint");
        set => SetProperty("disable_execute_api_endpoint", value);
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public TerraformProperty<bool> FailOnWarnings
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("fail_on_warnings");
        set => SetProperty("fail_on_warnings", value);
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
    /// The minimum_compression_size attribute.
    /// </summary>
    public TerraformProperty<string> MinimumCompressionSize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("minimum_compression_size");
        set => SetProperty("minimum_compression_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string> Policy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy");
        set => SetProperty("policy", value);
    }

    /// <summary>
    /// The put_rest_api_mode attribute.
    /// </summary>
    public TerraformProperty<string> PutRestApiMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("put_rest_api_mode");
        set => SetProperty("put_rest_api_mode", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfiguration block(s) allowed")]
    public List<AwsApiGatewayRestApiEndpointConfigurationBlock>? EndpointConfiguration
    {
        set => SetProperty("endpoint_configuration", value);
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
