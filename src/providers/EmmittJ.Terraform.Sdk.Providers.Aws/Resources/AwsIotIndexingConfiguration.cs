using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for thing_group_indexing_configuration in AwsIotIndexingConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "thing_group_indexing_configuration";

    /// <summary>
    /// The thing_group_indexing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingGroupIndexingMode is required")]
    public required TerraformValue<string> ThingGroupIndexingMode
    {
        get => new TerraformReference<string>(this, "thing_group_indexing_mode");
        set => SetArgument("thing_group_indexing_mode", value);
    }

    /// <summary>
    /// CustomField block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlockCustomFieldBlock>? CustomField
    {
        get => GetArgument<TerraformSet<AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlockCustomFieldBlock>>("custom_field");
        set => SetArgument("custom_field", value);
    }

    /// <summary>
    /// ManagedField block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlockManagedFieldBlock>? ManagedField
    {
        get => GetArgument<TerraformSet<AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlockManagedFieldBlock>>("managed_field");
        set => SetArgument("managed_field", value);
    }

}

/// <summary>
/// Block type for custom_field in AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlockCustomFieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_field";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for managed_field in AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlockManagedFieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_field";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for thing_indexing_configuration in AwsIotIndexingConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsIotIndexingConfigurationThingIndexingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "thing_indexing_configuration";

    /// <summary>
    /// The device_defender_indexing_mode attribute.
    /// </summary>
    public TerraformValue<string>? DeviceDefenderIndexingMode
    {
        get => new TerraformReference<string>(this, "device_defender_indexing_mode");
        set => SetArgument("device_defender_indexing_mode", value);
    }

    /// <summary>
    /// The named_shadow_indexing_mode attribute.
    /// </summary>
    public TerraformValue<string>? NamedShadowIndexingMode
    {
        get => new TerraformReference<string>(this, "named_shadow_indexing_mode");
        set => SetArgument("named_shadow_indexing_mode", value);
    }

    /// <summary>
    /// The thing_connectivity_indexing_mode attribute.
    /// </summary>
    public TerraformValue<string>? ThingConnectivityIndexingMode
    {
        get => new TerraformReference<string>(this, "thing_connectivity_indexing_mode");
        set => SetArgument("thing_connectivity_indexing_mode", value);
    }

    /// <summary>
    /// The thing_indexing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingIndexingMode is required")]
    public required TerraformValue<string> ThingIndexingMode
    {
        get => new TerraformReference<string>(this, "thing_indexing_mode");
        set => SetArgument("thing_indexing_mode", value);
    }

    /// <summary>
    /// CustomField block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotIndexingConfigurationThingIndexingConfigurationBlockCustomFieldBlock>? CustomField
    {
        get => GetArgument<TerraformSet<AwsIotIndexingConfigurationThingIndexingConfigurationBlockCustomFieldBlock>>("custom_field");
        set => SetArgument("custom_field", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AwsIotIndexingConfigurationThingIndexingConfigurationBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsIotIndexingConfigurationThingIndexingConfigurationBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// ManagedField block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotIndexingConfigurationThingIndexingConfigurationBlockManagedFieldBlock>? ManagedField
    {
        get => GetArgument<TerraformSet<AwsIotIndexingConfigurationThingIndexingConfigurationBlockManagedFieldBlock>>("managed_field");
        set => SetArgument("managed_field", value);
    }

}

/// <summary>
/// Block type for custom_field in AwsIotIndexingConfigurationThingIndexingConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsIotIndexingConfigurationThingIndexingConfigurationBlockCustomFieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_field";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for filter in AwsIotIndexingConfigurationThingIndexingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotIndexingConfigurationThingIndexingConfigurationBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The named_shadow_names attribute.
    /// </summary>
    public TerraformSet<string>? NamedShadowNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "named_shadow_names").ResolveNodes(ctx));
        set => SetArgument("named_shadow_names", value);
    }

}

/// <summary>
/// Block type for managed_field in AwsIotIndexingConfigurationThingIndexingConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsIotIndexingConfigurationThingIndexingConfigurationBlockManagedFieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_field";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_iot_indexing_configuration Terraform resource.
/// Manages a aws_iot_indexing_configuration resource.
/// </summary>
public partial class AwsIotIndexingConfiguration(string name) : TerraformResource("aws_iot_indexing_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// ThingGroupIndexingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThingGroupIndexingConfiguration block(s) allowed")]
    public TerraformList<AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlock>? ThingGroupIndexingConfiguration
    {
        get => GetArgument<TerraformList<AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlock>>("thing_group_indexing_configuration");
        set => SetArgument("thing_group_indexing_configuration", value);
    }

    /// <summary>
    /// ThingIndexingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThingIndexingConfiguration block(s) allowed")]
    public TerraformList<AwsIotIndexingConfigurationThingIndexingConfigurationBlock>? ThingIndexingConfiguration
    {
        get => GetArgument<TerraformList<AwsIotIndexingConfigurationThingIndexingConfigurationBlock>>("thing_indexing_configuration");
        set => SetArgument("thing_indexing_configuration", value);
    }

}
