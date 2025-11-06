using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_event_subscription resource.
/// </summary>
public class AwsRedshiftEventSubscription : TerraformResource
{
    public AwsRedshiftEventSubscription(string name) : base("aws_redshift_event_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("customer_aws_id");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The event_categories attribute.
    /// </summary>
    public HashSet<string>? EventCategories
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("event_categories")?.Value;
        set => this.WithProperty("event_categories", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The severity attribute.
    /// </summary>
    public string? Severity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("severity")?.Value;
        set => this.WithProperty("severity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public string? SnsTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sns_topic_arn")?.Value;
        set => this.WithProperty("sns_topic_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_ids attribute.
    /// </summary>
    public HashSet<string>? SourceIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("source_ids")?.Value;
        set => this.WithProperty("source_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    public string? SourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_type")?.Value;
        set => this.WithProperty("source_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The customer_aws_id attribute.
    /// </summary>
    public TerraformExpression CustomerAwsId => this["customer_aws_id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
