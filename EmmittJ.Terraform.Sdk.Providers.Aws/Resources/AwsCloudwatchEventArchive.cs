using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_event_archive resource.
/// </summary>
public class AwsCloudwatchEventArchive : TerraformResource
{
    public AwsCloudwatchEventArchive(string name) : base("aws_cloudwatch_event_archive", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The event_pattern attribute.
    /// </summary>
    public string? EventPattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_pattern")?.Value;
        set => this.WithProperty("event_pattern", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_source_arn attribute.
    /// </summary>
    public string? EventSourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_source_arn")?.Value;
        set => this.WithProperty("event_source_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    public double? RetentionDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_days")?.Value;
        set => this.WithProperty("retention_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
