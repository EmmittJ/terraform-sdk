using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kinesis_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsQldbStreamKinesisConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The aggregation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AggregationEnabled
    {
        set => SetProperty("aggregation_enabled", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamArn is required")]
    public required TerraformProperty<string> StreamArn
    {
        set => SetProperty("stream_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsQldbStreamTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a aws_qldb_stream resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsQldbStream : TerraformResource
{
    public AwsQldbStream(string name) : base("aws_qldb_stream", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("exclusive_end_time");
        SetOutput("id");
        SetOutput("inclusive_start_time");
        SetOutput("ledger_name");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("stream_name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The exclusive_end_time attribute.
    /// </summary>
    public TerraformProperty<string> ExclusiveEndTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("exclusive_end_time");
        set => SetProperty("exclusive_end_time", value);
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
    /// The inclusive_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InclusiveStartTime is required")]
    public required TerraformProperty<string> InclusiveStartTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("inclusive_start_time");
        set => SetProperty("inclusive_start_time", value);
    }

    /// <summary>
    /// The ledger_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LedgerName is required")]
    public required TerraformProperty<string> LedgerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ledger_name");
        set => SetProperty("ledger_name", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    public required TerraformProperty<string> StreamName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_name");
        set => SetProperty("stream_name", value);
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
    /// Block for kinesis_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KinesisConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KinesisConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisConfiguration block(s) allowed")]
    public List<AwsQldbStreamKinesisConfigurationBlock>? KinesisConfiguration
    {
        set => SetProperty("kinesis_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsQldbStreamTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
