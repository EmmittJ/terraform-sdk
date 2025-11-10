using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for source in .
/// Nesting mode: set
/// </summary>
public class AwsSecuritylakeSubscriberSourceBlock : TerraformBlock
{
}

/// <summary>
/// Block type for subscriber_identity in .
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeSubscriberSubscriberIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    public required TerraformProperty<string> ExternalId
    {
        set => SetProperty("external_id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        set => SetProperty("principal", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSecuritylakeSubscriberTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_securitylake_subscriber resource.
/// </summary>
public class AwsSecuritylakeSubscriber : TerraformResource
{
    public AwsSecuritylakeSubscriber(string name) : base("aws_securitylake_subscriber", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("resource_share_arn");
        SetOutput("resource_share_name");
        SetOutput("role_arn");
        SetOutput("s3_bucket_arn");
        SetOutput("subscriber_endpoint");
        SetOutput("subscriber_status");
        SetOutput("tags_all");
        SetOutput("access_type");
        SetOutput("region");
        SetOutput("subscriber_description");
        SetOutput("subscriber_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The access_type attribute.
    /// </summary>
    public TerraformProperty<string> AccessType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_type");
        set => SetProperty("access_type", value);
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
    /// The subscriber_description attribute.
    /// </summary>
    public TerraformProperty<string> SubscriberDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscriber_description");
        set => SetProperty("subscriber_description", value);
    }

    /// <summary>
    /// The subscriber_name attribute.
    /// </summary>
    public TerraformProperty<string> SubscriberName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscriber_name");
        set => SetProperty("subscriber_name", value);
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
    /// Block for source.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSecuritylakeSubscriberSourceBlock>? Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// Block for subscriber_identity.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSecuritylakeSubscriberSubscriberIdentityBlock>? SubscriberIdentity
    {
        set => SetProperty("subscriber_identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSecuritylakeSubscriberTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The resource_share_arn attribute.
    /// </summary>
    public TerraformExpression ResourceShareArn => this["resource_share_arn"];

    /// <summary>
    /// The resource_share_name attribute.
    /// </summary>
    public TerraformExpression ResourceShareName => this["resource_share_name"];

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformExpression RoleArn => this["role_arn"];

    /// <summary>
    /// The s3_bucket_arn attribute.
    /// </summary>
    public TerraformExpression S3BucketArn => this["s3_bucket_arn"];

    /// <summary>
    /// The subscriber_endpoint attribute.
    /// </summary>
    public TerraformExpression SubscriberEndpoint => this["subscriber_endpoint"];

    /// <summary>
    /// The subscriber_status attribute.
    /// </summary>
    public TerraformExpression SubscriberStatus => this["subscriber_status"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
