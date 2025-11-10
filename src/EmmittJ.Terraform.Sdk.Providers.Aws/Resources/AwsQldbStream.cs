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
        get => GetProperty<TerraformProperty<bool>>("aggregation_enabled");
        set => WithProperty("aggregation_enabled", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamArn is required")]
    public required TerraformProperty<string> StreamArn
    {
        get => GetProperty<TerraformProperty<string>>("stream_arn");
        set => WithProperty("stream_arn", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
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
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The exclusive_end_time attribute.
    /// </summary>
    public TerraformProperty<string>? ExclusiveEndTime
    {
        get => GetProperty<TerraformProperty<string>>("exclusive_end_time");
        set => this.WithProperty("exclusive_end_time", value);
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
    /// The inclusive_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InclusiveStartTime is required")]
    public required TerraformProperty<string> InclusiveStartTime
    {
        get => GetProperty<TerraformProperty<string>>("inclusive_start_time");
        set => this.WithProperty("inclusive_start_time", value);
    }

    /// <summary>
    /// The ledger_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LedgerName is required")]
    public required TerraformProperty<string> LedgerName
    {
        get => GetProperty<TerraformProperty<string>>("ledger_name");
        set => this.WithProperty("ledger_name", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    public required TerraformProperty<string> StreamName
    {
        get => GetProperty<TerraformProperty<string>>("stream_name");
        set => this.WithProperty("stream_name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for kinesis_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KinesisConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisConfiguration block(s) allowed")]
    public List<AwsQldbStreamKinesisConfigurationBlock>? KinesisConfiguration
    {
        get => GetProperty<List<AwsQldbStreamKinesisConfigurationBlock>>("kinesis_configuration");
        set => this.WithProperty("kinesis_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsQldbStreamTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsQldbStreamTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
