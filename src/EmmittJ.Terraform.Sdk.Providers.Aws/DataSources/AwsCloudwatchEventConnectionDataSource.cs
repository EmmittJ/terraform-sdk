using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudwatch_event_connection.
/// </summary>
public class AwsCloudwatchEventConnectionDataSource : TerraformDataSource
{
    public AwsCloudwatchEventConnectionDataSource(string name) : base("aws_cloudwatch_event_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("authorization_type");
        this.DeclareOutput("kms_key_identifier");
        this.DeclareOutput("secret_arn");
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
    public TerraformProperty<string>? Name
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public TerraformExpression AuthorizationType => this["authorization_type"];

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformExpression KmsKeyIdentifier => this["kms_key_identifier"];

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformExpression SecretArn => this["secret_arn"];

}
