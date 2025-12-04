using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for provisioning_parameters in AwsServicecatalogProvisionedProduct.
/// Nesting mode: list
/// </summary>
public class AwsServicecatalogProvisionedProductProvisioningParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "provisioning_parameters";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The use_previous_value attribute.
    /// </summary>
    public TerraformValue<bool>? UsePreviousValue
    {
        get => GetArgument<TerraformValue<bool>>("use_previous_value");
        set => SetArgument("use_previous_value", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for stack_set_provisioning_preferences in AwsServicecatalogProvisionedProduct.
/// Nesting mode: list
/// </summary>
public class AwsServicecatalogProvisionedProductStackSetProvisioningPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stack_set_provisioning_preferences";

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformList<string>? Accounts
    {
        get => GetArgument<TerraformList<string>>("accounts");
        set => SetArgument("accounts", value);
    }

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    public TerraformValue<double>? FailureToleranceCount
    {
        get => GetArgument<TerraformValue<double>>("failure_tolerance_count");
        set => SetArgument("failure_tolerance_count", value);
    }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    public TerraformValue<double>? FailureTolerancePercentage
    {
        get => GetArgument<TerraformValue<double>>("failure_tolerance_percentage");
        set => SetArgument("failure_tolerance_percentage", value);
    }

    /// <summary>
    /// The max_concurrency_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrencyCount
    {
        get => GetArgument<TerraformValue<double>>("max_concurrency_count");
        set => SetArgument("max_concurrency_count", value);
    }

    /// <summary>
    /// The max_concurrency_percentage attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrencyPercentage
    {
        get => GetArgument<TerraformValue<double>>("max_concurrency_percentage");
        set => SetArgument("max_concurrency_percentage", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformList<string>? Regions
    {
        get => GetArgument<TerraformList<string>>("regions");
        set => SetArgument("regions", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsServicecatalogProvisionedProduct.
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogProvisionedProductTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_servicecatalog_provisioned_product Terraform resource.
/// Manages a aws_servicecatalog_provisioned_product resource.
/// </summary>
public partial class AwsServicecatalogProvisionedProduct(string name) : TerraformResource("aws_servicecatalog_provisioned_product", name)
{
    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public TerraformValue<string>? AcceptLanguage
    {
        get => GetArgument<TerraformValue<string>>("accept_language");
        set => SetArgument("accept_language", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ignore_errors attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreErrors
    {
        get => GetArgument<TerraformValue<bool>>("ignore_errors");
        set => SetArgument("ignore_errors", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    public TerraformList<string>? NotificationArns
    {
        get => GetArgument<TerraformList<string>>("notification_arns");
        set => SetArgument("notification_arns", value);
    }

    /// <summary>
    /// The path_id attribute.
    /// </summary>
    public TerraformValue<string>? PathId
    {
        get => GetArgument<TerraformValue<string>>("path_id");
        set => SetArgument("path_id", value);
    }

    /// <summary>
    /// The path_name attribute.
    /// </summary>
    public TerraformValue<string>? PathName
    {
        get => GetArgument<TerraformValue<string>>("path_name");
        set => SetArgument("path_name", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public TerraformValue<string>? ProductId
    {
        get => GetArgument<TerraformValue<string>>("product_id");
        set => SetArgument("product_id", value);
    }

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    public TerraformValue<string>? ProductName
    {
        get => GetArgument<TerraformValue<string>>("product_name");
        set => SetArgument("product_name", value);
    }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    public TerraformValue<string>? ProvisioningArtifactId
    {
        get => GetArgument<TerraformValue<string>>("provisioning_artifact_id");
        set => SetArgument("provisioning_artifact_id", value);
    }

    /// <summary>
    /// The provisioning_artifact_name attribute.
    /// </summary>
    public TerraformValue<string>? ProvisioningArtifactName
    {
        get => GetArgument<TerraformValue<string>>("provisioning_artifact_name");
        set => SetArgument("provisioning_artifact_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The retain_physical_resources attribute.
    /// </summary>
    public TerraformValue<bool>? RetainPhysicalResources
    {
        get => GetArgument<TerraformValue<bool>>("retain_physical_resources");
        set => SetArgument("retain_physical_resources", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The cloudwatch_dashboard_names attribute.
    /// </summary>
    public TerraformSet<string> CloudwatchDashboardNames
        => AsReference("cloudwatch_dashboard_names");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
        => AsReference("created_time");

    /// <summary>
    /// The last_provisioning_record_id attribute.
    /// </summary>
    public TerraformValue<string> LastProvisioningRecordId
        => AsReference("last_provisioning_record_id");

    /// <summary>
    /// The last_record_id attribute.
    /// </summary>
    public TerraformValue<string> LastRecordId
        => AsReference("last_record_id");

    /// <summary>
    /// The last_successful_provisioning_record_id attribute.
    /// </summary>
    public TerraformValue<string> LastSuccessfulProvisioningRecordId
        => AsReference("last_successful_provisioning_record_id");

    /// <summary>
    /// The launch_role_arn attribute.
    /// </summary>
    public TerraformValue<string> LaunchRoleArn
        => AsReference("launch_role_arn");

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Outputs
        => AsReference("outputs");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformValue<string> StatusMessage
        => AsReference("status_message");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// ProvisioningParameters block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsServicecatalogProvisionedProductProvisioningParametersBlock>? ProvisioningParameters
    {
        get => GetArgument<TerraformList<AwsServicecatalogProvisionedProductProvisioningParametersBlock>>("provisioning_parameters");
        set => SetArgument("provisioning_parameters", value);
    }

    /// <summary>
    /// StackSetProvisioningPreferences block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StackSetProvisioningPreferences block(s) allowed")]
    public TerraformList<AwsServicecatalogProvisionedProductStackSetProvisioningPreferencesBlock>? StackSetProvisioningPreferences
    {
        get => GetArgument<TerraformList<AwsServicecatalogProvisionedProductStackSetProvisioningPreferencesBlock>>("stack_set_provisioning_preferences");
        set => SetArgument("stack_set_provisioning_preferences", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsServicecatalogProvisionedProductTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsServicecatalogProvisionedProductTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
