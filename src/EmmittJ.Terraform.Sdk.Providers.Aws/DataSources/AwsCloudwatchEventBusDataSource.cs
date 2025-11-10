using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudwatch_event_bus.
/// </summary>
public class AwsCloudwatchEventBusDataSource : TerraformDataSource
{
    public AwsCloudwatchEventBusDataSource(string name) : base("aws_cloudwatch_event_bus", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("dead_letter_config");
        this.DeclareOutput("description");
        this.DeclareOutput("kms_key_identifier");
        this.DeclareOutput("log_config");
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
    /// The dead_letter_config attribute.
    /// </summary>
    public TerraformExpression DeadLetterConfig => this["dead_letter_config"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformExpression KmsKeyIdentifier => this["kms_key_identifier"];

    /// <summary>
    /// The log_config attribute.
    /// </summary>
    public TerraformExpression LogConfig => this["log_config"];

}
