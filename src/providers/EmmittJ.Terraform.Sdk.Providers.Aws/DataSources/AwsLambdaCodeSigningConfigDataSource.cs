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
        SetOutput("allowed_publishers");
        SetOutput("config_id");
        SetOutput("description");
        SetOutput("last_modified");
        SetOutput("policies");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
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
