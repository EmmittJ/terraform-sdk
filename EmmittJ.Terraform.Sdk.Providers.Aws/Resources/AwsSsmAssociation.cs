using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_association resource.
/// </summary>
public class AwsSsmAssociation : TerraformResource
{
    public AwsSsmAssociation(string name) : base("aws_ssm_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("association_id");
    }

    /// <summary>
    /// The apply_only_at_cron_interval attribute.
    /// </summary>
    public bool? ApplyOnlyAtCronInterval
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("apply_only_at_cron_interval")?.Value;
        set => this.WithProperty("apply_only_at_cron_interval", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The association_name attribute.
    /// </summary>
    public string? AssociationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("association_name")?.Value;
        set => this.WithProperty("association_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The automation_target_parameter_name attribute.
    /// </summary>
    public string? AutomationTargetParameterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_target_parameter_name")?.Value;
        set => this.WithProperty("automation_target_parameter_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The compliance_severity attribute.
    /// </summary>
    public string? ComplianceSeverity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compliance_severity")?.Value;
        set => this.WithProperty("compliance_severity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public string? DocumentVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("document_version")?.Value;
        set => this.WithProperty("document_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The max_concurrency attribute.
    /// </summary>
    public string? MaxConcurrency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("max_concurrency")?.Value;
        set => this.WithProperty("max_concurrency", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    public string? MaxErrors
    {
        get => GetProperty<TerraformLiteralProperty<string>>("max_errors")?.Value;
        set => this.WithProperty("max_errors", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The schedule_expression attribute.
    /// </summary>
    public string? ScheduleExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schedule_expression")?.Value;
        set => this.WithProperty("schedule_expression", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sync_compliance attribute.
    /// </summary>
    public string? SyncCompliance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sync_compliance")?.Value;
        set => this.WithProperty("sync_compliance", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The wait_for_success_timeout_seconds attribute.
    /// </summary>
    public double? WaitForSuccessTimeoutSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("wait_for_success_timeout_seconds")?.Value;
        set => this.WithProperty("wait_for_success_timeout_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

}
