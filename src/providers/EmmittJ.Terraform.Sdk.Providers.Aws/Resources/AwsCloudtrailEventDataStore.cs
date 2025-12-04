using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_event_selector in AwsCloudtrailEventDataStore.
/// Nesting mode: list
/// </summary>
public class AwsCloudtrailEventDataStoreAdvancedEventSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_event_selector";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// FieldSelector block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudtrailEventDataStoreAdvancedEventSelectorBlockFieldSelectorBlock>? FieldSelector
    {
        get => GetArgument<TerraformSet<AwsCloudtrailEventDataStoreAdvancedEventSelectorBlockFieldSelectorBlock>>("field_selector");
        set => SetArgument("field_selector", value);
    }

}

/// <summary>
/// Block type for field_selector in AwsCloudtrailEventDataStoreAdvancedEventSelectorBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudtrailEventDataStoreAdvancedEventSelectorBlockFieldSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field_selector";

    /// <summary>
    /// The ends_with attribute.
    /// </summary>
    public TerraformList<string>? EndsWith
    {
        get => GetArgument<TerraformList<string>>("ends_with");
        set => SetArgument("ends_with", value);
    }

    /// <summary>
    /// The equals attribute.
    /// </summary>
    public TerraformList<string>? EqualsAttribute
    {
        get => GetArgument<TerraformList<string>>("equals");
        set => SetArgument("equals", value);
    }

    /// <summary>
    /// The field attribute.
    /// </summary>
    public TerraformValue<string>? Field
    {
        get => GetArgument<TerraformValue<string>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// The not_ends_with attribute.
    /// </summary>
    public TerraformList<string>? NotEndsWith
    {
        get => GetArgument<TerraformList<string>>("not_ends_with");
        set => SetArgument("not_ends_with", value);
    }

    /// <summary>
    /// The not_equals attribute.
    /// </summary>
    public TerraformList<string>? NotEquals
    {
        get => GetArgument<TerraformList<string>>("not_equals");
        set => SetArgument("not_equals", value);
    }

    /// <summary>
    /// The not_starts_with attribute.
    /// </summary>
    public TerraformList<string>? NotStartsWith
    {
        get => GetArgument<TerraformList<string>>("not_starts_with");
        set => SetArgument("not_starts_with", value);
    }

    /// <summary>
    /// The starts_with attribute.
    /// </summary>
    public TerraformList<string>? StartsWith
    {
        get => GetArgument<TerraformList<string>>("starts_with");
        set => SetArgument("starts_with", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsCloudtrailEventDataStore.
/// Nesting mode: single
/// </summary>
public class AwsCloudtrailEventDataStoreTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_cloudtrail_event_data_store Terraform resource.
/// Manages a aws_cloudtrail_event_data_store resource.
/// </summary>
public partial class AwsCloudtrailEventDataStore(string name) : TerraformResource("aws_cloudtrail_event_data_store", name)
{
    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    public TerraformValue<string>? BillingMode
    {
        get => GetArgument<TerraformValue<string>>("billing_mode");
        set => SetArgument("billing_mode", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The multi_region_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MultiRegionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("multi_region_enabled");
        set => SetArgument("multi_region_enabled", value);
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
    /// The organization_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OrganizationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("organization_enabled");
        set => SetArgument("organization_enabled", value);
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
    /// The retention_period attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("retention_period");
        set => SetArgument("retention_period", value);
    }

    /// <summary>
    /// The suspend attribute.
    /// </summary>
    public TerraformValue<string>? Suspend
    {
        get => GetArgument<TerraformValue<string>>("suspend");
        set => SetArgument("suspend", value);
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
    /// The termination_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TerminationProtectionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("termination_protection_enabled");
        set => SetArgument("termination_protection_enabled", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// AdvancedEventSelector block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudtrailEventDataStoreAdvancedEventSelectorBlock>? AdvancedEventSelector
    {
        get => GetArgument<TerraformList<AwsCloudtrailEventDataStoreAdvancedEventSelectorBlock>>("advanced_event_selector");
        set => SetArgument("advanced_event_selector", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudtrailEventDataStoreTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudtrailEventDataStoreTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
