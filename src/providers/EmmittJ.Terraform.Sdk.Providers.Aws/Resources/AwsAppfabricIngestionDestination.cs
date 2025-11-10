using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAppfabricIngestionDestinationDestinationConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for processing_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAppfabricIngestionDestinationProcessingConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAppfabricIngestionDestinationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_appfabric_ingestion_destination resource.
/// </summary>
public class AwsAppfabricIngestionDestination : TerraformResource
{
    public AwsAppfabricIngestionDestination(string name) : base("aws_appfabric_ingestion_destination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("id");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBundleArn is required")]
    public required TerraformProperty<string> AppBundleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("app_bundle_arn");
        set => this.WithProperty("app_bundle_arn", value);
    }

    /// <summary>
    /// The ingestion_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionArn is required")]
    public required TerraformProperty<string> IngestionArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ingestion_arn");
        set => this.WithProperty("ingestion_arn", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for destination_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAppfabricIngestionDestinationDestinationConfigurationBlock>? DestinationConfiguration
    {
        get => GetProperty<List<AwsAppfabricIngestionDestinationDestinationConfigurationBlock>>("destination_configuration");
        set => this.WithProperty("destination_configuration", value);
    }

    /// <summary>
    /// Block for processing_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAppfabricIngestionDestinationProcessingConfigurationBlock>? ProcessingConfiguration
    {
        get => GetProperty<List<AwsAppfabricIngestionDestinationProcessingConfigurationBlock>>("processing_configuration");
        set => this.WithProperty("processing_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAppfabricIngestionDestinationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsAppfabricIngestionDestinationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
