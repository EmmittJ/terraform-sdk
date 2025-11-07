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
    public TerraformProperty<string>? AcceptLanguage
    {
        get => GetProperty<TerraformProperty<string>>("accept_language");
        set => this.WithProperty("accept_language", value);
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
    /// The ignore_errors attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnoreErrors
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_errors");
        set => this.WithProperty("ignore_errors", value);
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
    /// The notification_arns attribute.
    /// </summary>
    public TerraformProperty<List<string>>? NotificationArns
    {
        get => GetProperty<TerraformProperty<List<string>>>("notification_arns");
        set => this.WithProperty("notification_arns", value);
    }

    /// <summary>
    /// The path_id attribute.
    /// </summary>
    public TerraformProperty<string>? PathId
    {
        get => GetProperty<TerraformProperty<string>>("path_id");
        set => this.WithProperty("path_id", value);
    }

    /// <summary>
    /// The path_name attribute.
    /// </summary>
    public TerraformProperty<string>? PathName
    {
        get => GetProperty<TerraformProperty<string>>("path_name");
        set => this.WithProperty("path_name", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProductId
    {
        get => GetProperty<TerraformProperty<string>>("product_id");
        set => this.WithProperty("product_id", value);
    }

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    public TerraformProperty<string>? ProductName
    {
        get => GetProperty<TerraformProperty<string>>("product_name");
        set => this.WithProperty("product_name", value);
    }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProvisioningArtifactId
    {
        get => GetProperty<TerraformProperty<string>>("provisioning_artifact_id");
        set => this.WithProperty("provisioning_artifact_id", value);
    }

    /// <summary>
    /// The provisioning_artifact_name attribute.
    /// </summary>
    public TerraformProperty<string>? ProvisioningArtifactName
    {
        get => GetProperty<TerraformProperty<string>>("provisioning_artifact_name");
        set => this.WithProperty("provisioning_artifact_name", value);
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
    /// The retain_physical_resources attribute.
    /// </summary>
    public TerraformProperty<bool>? RetainPhysicalResources
    {
        get => GetProperty<TerraformProperty<bool>>("retain_physical_resources");
        set => this.WithProperty("retain_physical_resources", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
