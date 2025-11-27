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
        get => new TerraformReference<string>(this, "aggregation");
        set => SetArgument("aggregation", value);
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
    /// The members attribute.
    /// </summary>
    public TerraformList<string>? Members
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "members").ResolveNodes(ctx));
        set => SetArgument("members", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => new TerraformReference<string>(this, "pattern");
        set => SetArgument("pattern", value);
    }

    /// <summary>
    /// The protection_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectionGroupId is required")]
    public required TerraformValue<string> ProtectionGroupId
    {
        get => new TerraformReference<string>(this, "protection_group_id");
        set => SetArgument("protection_group_id", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string>? ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
        set => SetArgument("resource_type", value);
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
    /// The protection_group_arn attribute.
    /// </summary>
    public TerraformValue<string> ProtectionGroupArn
    {
        get => new TerraformReference<string>(this, "protection_group_arn");
    }

}
