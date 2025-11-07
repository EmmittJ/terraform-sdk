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
    public TerraformLiteralProperty<bool>? ApplyOnlyAtCronInterval
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("apply_only_at_cron_interval");
        set => this.WithProperty("apply_only_at_cron_interval", value);
    }

    /// <summary>
    /// The association_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AssociationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("association_name");
        set => this.WithProperty("association_name", value);
    }

    /// <summary>
    /// The automation_target_parameter_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AutomationTargetParameterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_target_parameter_name");
        set => this.WithProperty("automation_target_parameter_name", value);
    }

    /// <summary>
    /// The compliance_severity attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ComplianceSeverity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compliance_severity");
        set => this.WithProperty("compliance_severity", value);
    }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DocumentVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("document_version");
        set => this.WithProperty("document_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MaxConcurrency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("max_concurrency");
        set => this.WithProperty("max_concurrency", value);
    }

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MaxErrors
    {
        get => GetProperty<TerraformLiteralProperty<string>>("max_errors");
        set => this.WithProperty("max_errors", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScheduleExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schedule_expression");
        set => this.WithProperty("schedule_expression", value);
    }

    /// <summary>
    /// The sync_compliance attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SyncCompliance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sync_compliance");
        set => this.WithProperty("sync_compliance", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The wait_for_success_timeout_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? WaitForSuccessTimeoutSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("wait_for_success_timeout_seconds");
        set => this.WithProperty("wait_for_success_timeout_seconds", value);
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
