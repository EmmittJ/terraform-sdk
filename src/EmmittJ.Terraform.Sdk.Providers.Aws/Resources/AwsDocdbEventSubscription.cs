using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_docdb_event_subscription resource.
/// </summary>
public class AwsDocdbEventSubscription : TerraformResource
{
    public AwsDocdbEventSubscription(string name) : base("aws_docdb_event_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("customer_aws_id");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The event_categories attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? EventCategories
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("event_categories");
        set => this.WithProperty("event_categories", value);
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
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
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
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SnsTopicArn
    {
        get => GetProperty<TerraformProperty<string>>("sns_topic_arn");
        set => this.WithProperty("sns_topic_arn", value);
    }

    /// <summary>
    /// The source_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SourceIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("source_ids");
        set => this.WithProperty("source_ids", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    public TerraformProperty<string>? SourceType
    {
        get => GetProperty<TerraformProperty<string>>("source_type");
        set => this.WithProperty("source_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The customer_aws_id attribute.
    /// </summary>
    public TerraformExpression CustomerAwsId => this["customer_aws_id"];

}
