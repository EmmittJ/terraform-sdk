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
        this.WithOutput("allowed_publishers");
        this.WithOutput("config_id");
        this.WithOutput("description");
        this.WithOutput("last_modified");
        this.WithOutput("policies");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
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
