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
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
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
    public TerraformList<string> EndsWith
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ends_with").ResolveNodes(ctx));
        set => SetArgument("ends_with", value);
    }

    /// <summary>
    /// The equals attribute.
    /// </summary>
    public TerraformList<string> EqualsAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "equals").ResolveNodes(ctx));
        set => SetArgument("equals", value);
    }

    /// <summary>
    /// The field attribute.
    /// </summary>
    public TerraformValue<string> Field
    {
        get => new TerraformReference<string>(this, "field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// The not_ends_with attribute.
    /// </summary>
    public TerraformList<string> NotEndsWith
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "not_ends_with").ResolveNodes(ctx));
        set => SetArgument("not_ends_with", value);
    }

    /// <summary>
    /// The not_equals attribute.
    /// </summary>
    public TerraformList<string> NotEquals
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "not_equals").ResolveNodes(ctx));
        set => SetArgument("not_equals", value);
    }

    /// <summary>
    /// The not_starts_with attribute.
    /// </summary>
    public TerraformList<string> NotStartsWith
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "not_starts_with").ResolveNodes(ctx));
        set => SetArgument("not_starts_with", value);
    }

    /// <summary>
    /// The starts_with attribute.
    /// </summary>
    public TerraformList<string> StartsWith
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "starts_with").ResolveNodes(ctx));
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "billing_mode");
        set => SetArgument("billing_mode", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The multi_region_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MultiRegionEnabled
    {
        get => new TerraformReference<bool>(this, "multi_region_enabled");
        set => SetArgument("multi_region_enabled", value);
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
    /// The organization_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OrganizationEnabled
    {
        get => new TerraformReference<bool>(this, "organization_enabled");
        set => SetArgument("organization_enabled", value);
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
    /// The retention_period attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPeriod
    {
        get => new TerraformReference<double>(this, "retention_period");
        set => SetArgument("retention_period", value);
    }

    /// <summary>
    /// The suspend attribute.
    /// </summary>
    public TerraformValue<string>? Suspend
    {
        get => new TerraformReference<string>(this, "suspend");
        set => SetArgument("suspend", value);
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
    /// The termination_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TerminationProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "termination_protection_enabled");
        set => SetArgument("termination_protection_enabled", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

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
