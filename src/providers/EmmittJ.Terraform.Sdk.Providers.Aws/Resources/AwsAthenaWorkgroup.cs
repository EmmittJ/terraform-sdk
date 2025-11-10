using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAthenaWorkgroupConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The bytes_scanned_cutoff_per_query attribute.
    /// </summary>
    public TerraformProperty<double>? BytesScannedCutoffPerQuery
    {
        get => GetProperty<TerraformProperty<double>>("bytes_scanned_cutoff_per_query");
        set => WithProperty("bytes_scanned_cutoff_per_query", value);
    }

    /// <summary>
    /// The enforce_workgroup_configuration attribute.
    /// </summary>
    public TerraformProperty<bool>? EnforceWorkgroupConfiguration
    {
        get => GetProperty<TerraformProperty<bool>>("enforce_workgroup_configuration");
        set => WithProperty("enforce_workgroup_configuration", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRole
    {
        get => GetProperty<TerraformProperty<string>>("execution_role");
        set => WithProperty("execution_role", value);
    }

    /// <summary>
    /// The publish_cloudwatch_metrics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublishCloudwatchMetricsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("publish_cloudwatch_metrics_enabled");
        set => WithProperty("publish_cloudwatch_metrics_enabled", value);
    }

    /// <summary>
    /// The requester_pays_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RequesterPaysEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("requester_pays_enabled");
        set => WithProperty("requester_pays_enabled", value);
    }

}

/// <summary>
/// Manages a aws_athena_workgroup resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAthenaWorkgroup : TerraformResource
{
    public AwsAthenaWorkgroup(string name) : base("aws_athena_workgroup", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
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
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
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
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public List<AwsAthenaWorkgroupConfigurationBlock>? Configuration
    {
        get => GetProperty<List<AwsAthenaWorkgroupConfigurationBlock>>("configuration");
        set => this.WithProperty("configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
