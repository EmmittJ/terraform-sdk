using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_code_signing_config.
/// </summary>
public class AwsLambdaCodeSigningConfigDataSource : TerraformDataSource
{
    public AwsLambdaCodeSigningConfigDataSource(string name) : base("aws_lambda_code_signing_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allowed_publishers");
        this.DeclareOutput("config_id");
        this.DeclareOutput("description");
        this.DeclareOutput("last_modified");
        this.DeclareOutput("policies");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
    /// The allowed_publishers attribute.
    /// </summary>
    public TerraformExpression AllowedPublishers => this["allowed_publishers"];

    /// <summary>
    /// The config_id attribute.
    /// </summary>
    public TerraformExpression ConfigId => this["config_id"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

    /// <summary>
    /// The policies attribute.
    /// </summary>
    public TerraformExpression Policies => this["policies"];

}
