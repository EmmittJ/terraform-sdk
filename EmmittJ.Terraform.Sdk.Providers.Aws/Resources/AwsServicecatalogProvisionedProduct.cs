using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicecatalog_provisioned_product resource.
/// </summary>
public class AwsServicecatalogProvisionedProduct : TerraformResource
{
    public AwsServicecatalogProvisionedProduct(string name) : base("aws_servicecatalog_provisioned_product", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cloudwatch_dashboard_names");
        this.DeclareOutput("created_time");
        this.DeclareOutput("last_provisioning_record_id");
        this.DeclareOutput("last_record_id");
        this.DeclareOutput("last_successful_provisioning_record_id");
        this.DeclareOutput("launch_role_arn");
        this.DeclareOutput("outputs");
        this.DeclareOutput("status");
        this.DeclareOutput("status_message");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public string? AcceptLanguage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("accept_language")?.Value;
        set => this.WithProperty("accept_language", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ignore_errors attribute.
    /// </summary>
    public bool? IgnoreErrors
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_errors")?.Value;
        set => this.WithProperty("ignore_errors", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The notification_arns attribute.
    /// </summary>
    public List<string>? NotificationArns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("notification_arns")?.Value;
        set => this.WithProperty("notification_arns", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The path_id attribute.
    /// </summary>
    public string? PathId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path_id")?.Value;
        set => this.WithProperty("path_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The path_name attribute.
    /// </summary>
    public string? PathName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path_name")?.Value;
        set => this.WithProperty("path_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public string? ProductId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("product_id")?.Value;
        set => this.WithProperty("product_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    public string? ProductName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("product_name")?.Value;
        set => this.WithProperty("product_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    public string? ProvisioningArtifactId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provisioning_artifact_id")?.Value;
        set => this.WithProperty("provisioning_artifact_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The provisioning_artifact_name attribute.
    /// </summary>
    public string? ProvisioningArtifactName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provisioning_artifact_name")?.Value;
        set => this.WithProperty("provisioning_artifact_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The retain_physical_resources attribute.
    /// </summary>
    public bool? RetainPhysicalResources
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("retain_physical_resources")?.Value;
        set => this.WithProperty("retain_physical_resources", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cloudwatch_dashboard_names attribute.
    /// </summary>
    public TerraformExpression CloudwatchDashboardNames => this["cloudwatch_dashboard_names"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The last_provisioning_record_id attribute.
    /// </summary>
    public TerraformExpression LastProvisioningRecordId => this["last_provisioning_record_id"];

    /// <summary>
    /// The last_record_id attribute.
    /// </summary>
    public TerraformExpression LastRecordId => this["last_record_id"];

    /// <summary>
    /// The last_successful_provisioning_record_id attribute.
    /// </summary>
    public TerraformExpression LastSuccessfulProvisioningRecordId => this["last_successful_provisioning_record_id"];

    /// <summary>
    /// The launch_role_arn attribute.
    /// </summary>
    public TerraformExpression LaunchRoleArn => this["launch_role_arn"];

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformExpression Outputs => this["outputs"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformExpression StatusMessage => this["status_message"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
