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
    public TerraformProperty<List<string>>? CustomDataIdentifierIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("custom_data_identifier_ids");
        set => this.WithProperty("custom_data_identifier_ids", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The initial_run attribute.
    /// </summary>
    public TerraformProperty<bool>? InitialRun
    {
        get => GetProperty<TerraformProperty<bool>>("initial_run");
        set => this.WithProperty("initial_run", value);
    }

    /// <summary>
    /// The job_status attribute.
    /// </summary>
    public TerraformProperty<string>? JobStatus
    {
        get => GetProperty<TerraformProperty<string>>("job_status");
        set => this.WithProperty("job_status", value);
    }

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    public TerraformProperty<string>? JobType
    {
        get => GetProperty<TerraformProperty<string>>("job_type");
        set => this.WithProperty("job_type", value);
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
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? SamplingPercentage
    {
        get => GetProperty<TerraformProperty<double>>("sampling_percentage");
        set => this.WithProperty("sampling_percentage", value);
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
