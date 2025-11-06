using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_macie2_classification_job resource.
/// </summary>
public class AwsMacie2ClassificationJob : TerraformResource
{
    public AwsMacie2ClassificationJob(string name) : base("aws_macie2_classification_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_at");
        this.DeclareOutput("job_arn");
        this.DeclareOutput("job_id");
        this.DeclareOutput("user_paused_details");
    }

    /// <summary>
    /// The custom_data_identifier_ids attribute.
    /// </summary>
    public List<string>? CustomDataIdentifierIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("custom_data_identifier_ids")?.Value;
        set => this.WithProperty("custom_data_identifier_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The initial_run attribute.
    /// </summary>
    public bool? InitialRun
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("initial_run")?.Value;
        set => this.WithProperty("initial_run", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The job_status attribute.
    /// </summary>
    public string? JobStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_status")?.Value;
        set => this.WithProperty("job_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    public string? JobType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_type")?.Value;
        set => this.WithProperty("job_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The sampling_percentage attribute.
    /// </summary>
    public double? SamplingPercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("sampling_percentage")?.Value;
        set => this.WithProperty("sampling_percentage", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The job_arn attribute.
    /// </summary>
    public TerraformExpression JobArn => this["job_arn"];

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformExpression JobId => this["job_id"];

    /// <summary>
    /// The user_paused_details attribute.
    /// </summary>
    public TerraformExpression UserPausedDetails => this["user_paused_details"];

}
