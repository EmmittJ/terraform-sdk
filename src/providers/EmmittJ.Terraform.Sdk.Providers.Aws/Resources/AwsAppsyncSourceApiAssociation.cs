using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAppsyncSourceApiAssociationTimeoutsBlock : TerraformBlock
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
/// Manages a aws_appsync_source_api_association resource.
/// </summary>
public class AwsAppsyncSourceApiAssociation : TerraformResource
{
    public AwsAppsyncSourceApiAssociation(string name) : base("aws_appsync_source_api_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("association_id");
        SetOutput("id");
        SetOutput("description");
        SetOutput("merged_api_arn");
        SetOutput("merged_api_id");
        SetOutput("region");
        SetOutput("source_api_arn");
        SetOutput("source_api_association_config");
        SetOutput("source_api_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The merged_api_arn attribute.
    /// </summary>
    public TerraformProperty<string> MergedApiArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("merged_api_arn");
        set => SetProperty("merged_api_arn", value);
    }

    /// <summary>
    /// The merged_api_id attribute.
    /// </summary>
    public TerraformProperty<string> MergedApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("merged_api_id");
        set => SetProperty("merged_api_id", value);
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
    /// The source_api_arn attribute.
    /// </summary>
    public TerraformProperty<string> SourceApiArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_api_arn");
        set => SetProperty("source_api_arn", value);
    }

    /// <summary>
    /// The source_api_association_config attribute.
    /// </summary>
    public List<TerraformProperty<object>> SourceApiAssociationConfig
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("source_api_association_config");
        set => SetProperty("source_api_association_config", value);
    }

    /// <summary>
    /// The source_api_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_api_id");
        set => SetProperty("source_api_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAppsyncSourceApiAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
