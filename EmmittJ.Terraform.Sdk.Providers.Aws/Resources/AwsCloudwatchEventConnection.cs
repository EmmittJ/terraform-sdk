using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? AuthorizationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_type")?.Value;
        set => this.WithProperty("authorization_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public string? KmsKeyIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_identifier")?.Value;
        set => this.WithProperty("kms_key_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
