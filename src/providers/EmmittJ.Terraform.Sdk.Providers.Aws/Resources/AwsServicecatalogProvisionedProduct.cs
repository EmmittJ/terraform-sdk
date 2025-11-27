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
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The use_previous_value attribute.
    /// </summary>
    public TerraformValue<bool>? UsePreviousValue
    {
        get => new TerraformReference<bool>(this, "use_previous_value");
        set => SetArgument("use_previous_value", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "accounts").ResolveNodes(ctx));
        set => SetArgument("accounts", value);
    }

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    public TerraformValue<double>? FailureToleranceCount
    {
        get => new TerraformReference<double>(this, "failure_tolerance_count");
        set => SetArgument("failure_tolerance_count", value);
    }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    public TerraformValue<double>? FailureTolerancePercentage
    {
        get => new TerraformReference<double>(this, "failure_tolerance_percentage");
        set => SetArgument("failure_tolerance_percentage", value);
    }

    /// <summary>
    /// The max_concurrency_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrencyCount
    {
        get => new TerraformReference<double>(this, "max_concurrency_count");
        set => SetArgument("max_concurrency_count", value);
    }

    /// <summary>
    /// The max_concurrency_percentage attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrencyPercentage
    {
        get => new TerraformReference<double>(this, "max_concurrency_percentage");
        set => SetArgument("max_concurrency_percentage", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformList<string>? Regions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "regions").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "accept_language");
        set => SetArgument("accept_language", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ignore_errors attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreErrors
    {
        get => new TerraformReference<bool>(this, "ignore_errors");
        set => SetArgument("ignore_errors", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    public TerraformList<string>? NotificationArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "notification_arns").ResolveNodes(ctx));
        set => SetArgument("notification_arns", value);
    }

    /// <summary>
    /// The path_id attribute.
    /// </summary>
    public TerraformValue<string> PathId
    {
        get => new TerraformReference<string>(this, "path_id");
        set => SetArgument("path_id", value);
    }

    /// <summary>
    /// The path_name attribute.
    /// </summary>
    public TerraformValue<string>? PathName
    {
        get => new TerraformReference<string>(this, "path_name");
        set => SetArgument("path_name", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public TerraformValue<string> ProductId
    {
        get => new TerraformReference<string>(this, "product_id");
        set => SetArgument("product_id", value);
    }

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    public TerraformValue<string>? ProductName
    {
        get => new TerraformReference<string>(this, "product_name");
        set => SetArgument("product_name", value);
    }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    public TerraformValue<string> ProvisioningArtifactId
    {
        get => new TerraformReference<string>(this, "provisioning_artifact_id");
        set => SetArgument("provisioning_artifact_id", value);
    }

    /// <summary>
    /// The provisioning_artifact_name attribute.
    /// </summary>
    public TerraformValue<string>? ProvisioningArtifactName
    {
        get => new TerraformReference<string>(this, "provisioning_artifact_name");
        set => SetArgument("provisioning_artifact_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The retain_physical_resources attribute.
    /// </summary>
    public TerraformValue<bool>? RetainPhysicalResources
    {
        get => new TerraformReference<bool>(this, "retain_physical_resources");
        set => SetArgument("retain_physical_resources", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cloudwatch_dashboard_names attribute.
    /// </summary>
    public TerraformSet<string> CloudwatchDashboardNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cloudwatch_dashboard_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
    {
        get => new TerraformReference<string>(this, "created_time");
    }

    /// <summary>
    /// The last_provisioning_record_id attribute.
    /// </summary>
    public TerraformValue<string> LastProvisioningRecordId
    {
        get => new TerraformReference<string>(this, "last_provisioning_record_id");
    }

    /// <summary>
    /// The last_record_id attribute.
    /// </summary>
    public TerraformValue<string> LastRecordId
    {
        get => new TerraformReference<string>(this, "last_record_id");
    }

    /// <summary>
    /// The last_successful_provisioning_record_id attribute.
    /// </summary>
    public TerraformValue<string> LastSuccessfulProvisioningRecordId
    {
        get => new TerraformReference<string>(this, "last_successful_provisioning_record_id");
    }

    /// <summary>
    /// The launch_role_arn attribute.
    /// </summary>
    public TerraformValue<string> LaunchRoleArn
    {
        get => new TerraformReference<string>(this, "launch_role_arn");
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Outputs
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "outputs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformValue<string> StatusMessage
    {
        get => new TerraformReference<string>(this, "status_message");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

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
