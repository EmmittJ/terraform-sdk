using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for buffer_options in .
/// Nesting mode: list
/// </summary>
public class AwsOsisPipelineBufferOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The persistent_buffer_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PersistentBufferEnabled is required")]
    public required TerraformProperty<bool> PersistentBufferEnabled
    {
        set => SetProperty("persistent_buffer_enabled", value);
    }

}

/// <summary>
/// Block type for encryption_at_rest_options in .
/// Nesting mode: list
/// </summary>
public class AwsOsisPipelineEncryptionAtRestOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyArn is required")]
    public required TerraformProperty<string> KmsKeyArn
    {
        set => SetProperty("kms_key_arn", value);
    }

}

/// <summary>
/// Block type for log_publishing_options in .
/// Nesting mode: list
/// </summary>
public class AwsOsisPipelineLogPublishingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The is_logging_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IsLoggingEnabled
    {
        set => SetProperty("is_logging_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOsisPipelineTimeoutsBlock : TerraformBlock
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
/// Block type for vpc_options in .
/// Nesting mode: list
/// </summary>
public class AwsOsisPipelineVpcOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_endpoint_management attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointManagement
    {
        set => SetProperty("vpc_endpoint_management", value);
    }

}

/// <summary>
/// Manages a aws_osis_pipeline resource.
/// </summary>
public class AwsOsisPipeline : TerraformResource
{
    public AwsOsisPipeline(string name) : base("aws_osis_pipeline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("ingest_endpoint_urls");
        SetOutput("pipeline_arn");
        SetOutput("tags_all");
        SetOutput("max_units");
        SetOutput("min_units");
        SetOutput("pipeline_configuration_body");
        SetOutput("pipeline_name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The max_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnits is required")]
    public required TerraformProperty<double> MaxUnits
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_units");
        set => SetProperty("max_units", value);
    }

    /// <summary>
    /// The min_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinUnits is required")]
    public required TerraformProperty<double> MinUnits
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_units");
        set => SetProperty("min_units", value);
    }

    /// <summary>
    /// The pipeline_configuration_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineConfigurationBody is required")]
    public required TerraformProperty<string> PipelineConfigurationBody
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pipeline_configuration_body");
        set => SetProperty("pipeline_configuration_body", value);
    }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineName is required")]
    public required TerraformProperty<string> PipelineName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pipeline_name");
        set => SetProperty("pipeline_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for buffer_options.
    /// Nesting mode: list
    /// </summary>
    public List<AwsOsisPipelineBufferOptionsBlock>? BufferOptions
    {
        set => SetProperty("buffer_options", value);
    }

    /// <summary>
    /// Block for encryption_at_rest_options.
    /// Nesting mode: list
    /// </summary>
    public List<AwsOsisPipelineEncryptionAtRestOptionsBlock>? EncryptionAtRestOptions
    {
        set => SetProperty("encryption_at_rest_options", value);
    }

    /// <summary>
    /// Block for log_publishing_options.
    /// Nesting mode: list
    /// </summary>
    public List<AwsOsisPipelineLogPublishingOptionsBlock>? LogPublishingOptions
    {
        set => SetProperty("log_publishing_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOsisPipelineTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_options.
    /// Nesting mode: list
    /// </summary>
    public List<AwsOsisPipelineVpcOptionsBlock>? VpcOptions
    {
        set => SetProperty("vpc_options", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The ingest_endpoint_urls attribute.
    /// </summary>
    public TerraformExpression IngestEndpointUrls => this["ingest_endpoint_urls"];

    /// <summary>
    /// The pipeline_arn attribute.
    /// </summary>
    public TerraformExpression PipelineArn => this["pipeline_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
