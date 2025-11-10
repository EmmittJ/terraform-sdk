using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auth_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlock : TerraformBlock
{
}

/// <summary>
/// Block type for invocation_connectivity_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionInvocationConnectivityParametersBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_cloudwatch_event_connection resource.
/// </summary>
public class AwsCloudwatchEventConnection : TerraformResource
{
    public AwsCloudwatchEventConnection(string name) : base("aws_cloudwatch_event_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("secret_arn");
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationType is required")]
    public required TerraformProperty<string> AuthorizationType
    {
        get => GetProperty<TerraformProperty<string>>("authorization_type");
        set => this.WithProperty("authorization_type", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_identifier");
        set => this.WithProperty("kms_key_identifier", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for auth_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthParameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthParameters block(s) allowed")]
    public List<AwsCloudwatchEventConnectionAuthParametersBlock>? AuthParameters
    {
        get => GetProperty<List<AwsCloudwatchEventConnectionAuthParametersBlock>>("auth_parameters");
        set => this.WithProperty("auth_parameters", value);
    }

    /// <summary>
    /// Block for invocation_connectivity_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InvocationConnectivityParameters block(s) allowed")]
    public List<AwsCloudwatchEventConnectionInvocationConnectivityParametersBlock>? InvocationConnectivityParameters
    {
        get => GetProperty<List<AwsCloudwatchEventConnectionInvocationConnectivityParametersBlock>>("invocation_connectivity_parameters");
        set => this.WithProperty("invocation_connectivity_parameters", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformExpression SecretArn => this["secret_arn"];

}
