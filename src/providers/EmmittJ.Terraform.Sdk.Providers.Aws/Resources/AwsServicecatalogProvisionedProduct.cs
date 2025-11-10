using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for provisioning_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsServicecatalogProvisionedProductProvisioningParametersBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The use_previous_value attribute.
    /// </summary>
    public TerraformProperty<bool>? UsePreviousValue
    {
        get => GetProperty<TerraformProperty<bool>>("use_previous_value");
        set => WithProperty("use_previous_value", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for stack_set_provisioning_preferences in .
/// Nesting mode: list
/// </summary>
public class AwsServicecatalogProvisionedProductStackSetProvisioningPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Accounts
    {
        get => GetProperty<List<TerraformProperty<string>>>("accounts");
        set => WithProperty("accounts", value);
    }

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    public TerraformProperty<double>? FailureToleranceCount
    {
        get => GetProperty<TerraformProperty<double>>("failure_tolerance_count");
        set => WithProperty("failure_tolerance_count", value);
    }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? FailureTolerancePercentage
    {
        get => GetProperty<TerraformProperty<double>>("failure_tolerance_percentage");
        set => WithProperty("failure_tolerance_percentage", value);
    }

    /// <summary>
    /// The max_concurrency_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrencyCount
    {
        get => GetProperty<TerraformProperty<double>>("max_concurrency_count");
        set => WithProperty("max_concurrency_count", value);
    }

    /// <summary>
    /// The max_concurrency_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrencyPercentage
    {
        get => GetProperty<TerraformProperty<double>>("max_concurrency_percentage");
        set => WithProperty("max_concurrency_percentage", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Regions
    {
        get => GetProperty<List<TerraformProperty<string>>>("regions");
        set => WithProperty("regions", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogProvisionedProductTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_servicecatalog_provisioned_product resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsServicecatalogProvisionedProduct : TerraformResource
{
    public AwsServicecatalogProvisionedProduct(string name) : base("aws_servicecatalog_provisioned_product", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("cloudwatch_dashboard_names");
        this.WithOutput("created_time");
        this.WithOutput("last_provisioning_record_id");
        this.WithOutput("last_record_id");
        this.WithOutput("last_successful_provisioning_record_id");
        this.WithOutput("launch_role_arn");
        this.WithOutput("outputs");
        this.WithOutput("status");
        this.WithOutput("status_message");
        this.WithOutput("type");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    public List<TerraformProperty<string>>? NotificationArns
    {
        get => GetProperty<List<TerraformProperty<string>>>("notification_arns");
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
    /// Block for provisioning_parameters.
    /// Nesting mode: list
    /// </summary>
    public List<AwsServicecatalogProvisionedProductProvisioningParametersBlock>? ProvisioningParameters
    {
        get => GetProperty<List<AwsServicecatalogProvisionedProductProvisioningParametersBlock>>("provisioning_parameters");
        set => this.WithProperty("provisioning_parameters", value);
    }

    /// <summary>
    /// Block for stack_set_provisioning_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StackSetProvisioningPreferences block(s) allowed")]
    public List<AwsServicecatalogProvisionedProductStackSetProvisioningPreferencesBlock>? StackSetProvisioningPreferences
    {
        get => GetProperty<List<AwsServicecatalogProvisionedProductStackSetProvisioningPreferencesBlock>>("stack_set_provisioning_preferences");
        set => this.WithProperty("stack_set_provisioning_preferences", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsServicecatalogProvisionedProductTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsServicecatalogProvisionedProductTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
