using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRedshiftEventSubscriptionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("arn");
        SetOutput("customer_aws_id");
        SetOutput("status");
        SetOutput("enabled");
        SetOutput("event_categories");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("severity");
        SetOutput("sns_topic_arn");
        SetOutput("source_ids");
        SetOutput("source_type");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The event_categories attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> EventCategories
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("event_categories");
        set => SetProperty("event_categories", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The severity attribute.
    /// </summary>
    public TerraformProperty<string> Severity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("severity");
        set => SetProperty("severity", value);
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnsTopicArn is required")]
    public required TerraformProperty<string> SnsTopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sns_topic_arn");
        set => SetProperty("sns_topic_arn", value);
    }

    /// <summary>
    /// The source_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SourceIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("source_ids");
        set => SetProperty("source_ids", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    public TerraformProperty<string> SourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_type");
        set => SetProperty("source_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRedshiftEventSubscriptionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
