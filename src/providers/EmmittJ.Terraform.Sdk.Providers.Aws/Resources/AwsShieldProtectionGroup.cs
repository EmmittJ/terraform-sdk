using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_shield_protection_group Terraform resource.
/// Manages a aws_shield_protection_group resource.
/// </summary>
public partial class AwsShieldProtectionGroup(string name) : TerraformResource("aws_shield_protection_group", name)
{
    /// <summary>
    /// The aggregation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    public required TerraformValue<string> Aggregation
    {
        get => GetRequiredArgument<TerraformValue<string>>("aggregation");
        set => SetArgument("aggregation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The members attribute.
    /// </summary>
    public TerraformList<string>? Members
    {
        get => GetArgument<TerraformList<string>>("members");
        set => SetArgument("members", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetRequiredArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

    /// <summary>
    /// The protection_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectionGroupId is required")]
    public required TerraformValue<string> ProtectionGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("protection_group_id");
        set => SetArgument("protection_group_id", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string>? ResourceTypeAttribute
    {
        get => GetArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The protection_group_arn attribute.
    /// </summary>
    public TerraformValue<string> ProtectionGroupArn
        => AsReference("protection_group_arn");

}
