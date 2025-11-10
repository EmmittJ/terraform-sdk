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
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The use_previous_value attribute.
    /// </summary>
    public TerraformProperty<bool>? UsePreviousValue
    {
        set => SetProperty("use_previous_value", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("accounts", value);
    }

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    public TerraformProperty<double>? FailureToleranceCount
    {
        set => SetProperty("failure_tolerance_count", value);
    }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? FailureTolerancePercentage
    {
        set => SetProperty("failure_tolerance_percentage", value);
    }

    /// <summary>
    /// The max_concurrency_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrencyCount
    {
        set => SetProperty("max_concurrency_count", value);
    }

    /// <summary>
    /// The max_concurrency_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrencyPercentage
    {
        set => SetProperty("max_concurrency_percentage", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Regions
    {
        set => SetProperty("regions", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("cloudwatch_dashboard_names");
        SetOutput("created_time");
        SetOutput("last_provisioning_record_id");
        SetOutput("last_record_id");
        SetOutput("last_successful_provisioning_record_id");
        SetOutput("launch_role_arn");
        SetOutput("outputs");
        SetOutput("status");
        SetOutput("status_message");
        SetOutput("type");
        SetOutput("accept_language");
        SetOutput("id");
        SetOutput("ignore_errors");
        SetOutput("name");
        SetOutput("notification_arns");
        SetOutput("path_id");
        SetOutput("path_name");
        SetOutput("product_id");
        SetOutput("product_name");
        SetOutput("provisioning_artifact_id");
        SetOutput("provisioning_artifact_name");
        SetOutput("region");
        SetOutput("retain_physical_resources");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public TerraformProperty<string> AcceptLanguage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("accept_language");
        set => SetProperty("accept_language", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ignore_errors attribute.
    /// </summary>
    public TerraformProperty<bool> IgnoreErrors
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_errors");
        set => SetProperty("ignore_errors", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    public List<TerraformProperty<string>> NotificationArns
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("notification_arns");
        set => SetProperty("notification_arns", value);
    }

    /// <summary>
    /// The path_id attribute.
    /// </summary>
    public TerraformProperty<string> PathId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path_id");
        set => SetProperty("path_id", value);
    }

    /// <summary>
    /// The path_name attribute.
    /// </summary>
    public TerraformProperty<string> PathName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path_name");
        set => SetProperty("path_name", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public TerraformProperty<string> ProductId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("product_id");
        set => SetProperty("product_id", value);
    }

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    public TerraformProperty<string> ProductName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("product_name");
        set => SetProperty("product_name", value);
    }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    public TerraformProperty<string> ProvisioningArtifactId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("provisioning_artifact_id");
        set => SetProperty("provisioning_artifact_id", value);
    }

    /// <summary>
    /// The provisioning_artifact_name attribute.
    /// </summary>
    public TerraformProperty<string> ProvisioningArtifactName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("provisioning_artifact_name");
        set => SetProperty("provisioning_artifact_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The retain_physical_resources attribute.
    /// </summary>
    public TerraformProperty<bool> RetainPhysicalResources
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("retain_physical_resources");
        set => SetProperty("retain_physical_resources", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for provisioning_parameters.
    /// Nesting mode: list
    /// </summary>
    public List<AwsServicecatalogProvisionedProductProvisioningParametersBlock>? ProvisioningParameters
    {
        set => SetProperty("provisioning_parameters", value);
    }

    /// <summary>
    /// Block for stack_set_provisioning_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StackSetProvisioningPreferences block(s) allowed")]
    public List<AwsServicecatalogProvisionedProductStackSetProvisioningPreferencesBlock>? StackSetProvisioningPreferences
    {
        set => SetProperty("stack_set_provisioning_preferences", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsServicecatalogProvisionedProductTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
