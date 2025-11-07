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
    public TerraformLiteralProperty<string>? AcceptLanguage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("accept_language");
        set => this.WithProperty("accept_language", value);
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
    /// The ignore_errors attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IgnoreErrors
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_errors");
        set => this.WithProperty("ignore_errors", value);
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
    /// The notification_arns attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? NotificationArns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("notification_arns");
        set => this.WithProperty("notification_arns", value);
    }

    /// <summary>
    /// The path_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PathId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path_id");
        set => this.WithProperty("path_id", value);
    }

    /// <summary>
    /// The path_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PathName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path_name");
        set => this.WithProperty("path_name", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProductId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("product_id");
        set => this.WithProperty("product_id", value);
    }

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProductName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("product_name");
        set => this.WithProperty("product_name", value);
    }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProvisioningArtifactId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provisioning_artifact_id");
        set => this.WithProperty("provisioning_artifact_id", value);
    }

    /// <summary>
    /// The provisioning_artifact_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProvisioningArtifactName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provisioning_artifact_name");
        set => this.WithProperty("provisioning_artifact_name", value);
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
    /// The retain_physical_resources attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RetainPhysicalResources
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("retain_physical_resources");
        set => this.WithProperty("retain_physical_resources", value);
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
