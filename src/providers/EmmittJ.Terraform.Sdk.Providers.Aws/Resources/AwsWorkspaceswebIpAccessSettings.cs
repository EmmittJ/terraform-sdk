using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ip_rule in AwsWorkspaceswebIpAccessSettings.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebIpAccessSettingsIpRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_rule";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The ip_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRange is required")]
    public required TerraformValue<string> IpRange
    {
        get => new TerraformReference<string>(this, "ip_range");
        set => SetArgument("ip_range", value);
    }

}


/// <summary>
/// Represents a aws_workspacesweb_ip_access_settings Terraform resource.
/// Manages a aws_workspacesweb_ip_access_settings resource.
/// </summary>
public partial class AwsWorkspaceswebIpAccessSettings(string name) : TerraformResource("aws_workspacesweb_ip_access_settings", name)
{
    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalEncryptionContext
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_encryption_context").ResolveNodes(ctx));
        set => SetArgument("additional_encryption_context", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformValue<string>? CustomerManagedKey
    {
        get => new TerraformReference<string>(this, "customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformList<string> AssociatedPortalArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "associated_portal_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_access_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> IpAccessSettingsArn
    {
        get => new TerraformReference<string>(this, "ip_access_settings_arn");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// IpRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebIpAccessSettingsIpRuleBlock>? IpRule
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebIpAccessSettingsIpRuleBlock>>("ip_rule");
        set => SetArgument("ip_rule", value);
    }

}
