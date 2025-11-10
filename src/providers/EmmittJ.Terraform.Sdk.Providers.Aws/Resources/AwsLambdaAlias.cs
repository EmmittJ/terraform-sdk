using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for routing_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaAliasRoutingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The additional_version_weights attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<double>>? AdditionalVersionWeights
    {
        get => GetProperty<Dictionary<string, TerraformProperty<double>>>("additional_version_weights");
        set => WithProperty("additional_version_weights", value);
    }

}

/// <summary>
/// Manages a aws_lambda_alias resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLambdaAlias : TerraformResource
{
    public AwsLambdaAlias(string name) : base("aws_lambda_alias", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("invoke_arn");
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
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
    }

    /// <summary>
    /// The function_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionVersion is required")]
    public required TerraformProperty<string> FunctionVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("function_version");
        set => this.WithProperty("function_version", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for routing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RoutingConfig block(s) allowed")]
    public List<AwsLambdaAliasRoutingConfigBlock>? RoutingConfig
    {
        get => GetProperty<List<AwsLambdaAliasRoutingConfigBlock>>("routing_config");
        set => this.WithProperty("routing_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    public TerraformExpression InvokeArn => this["invoke_arn"];

}
