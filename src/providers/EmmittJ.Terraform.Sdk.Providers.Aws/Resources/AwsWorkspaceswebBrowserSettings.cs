using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_workspacesweb_browser_settings Terraform resource.
/// Manages a aws_workspacesweb_browser_settings resource.
/// </summary>
public partial class AwsWorkspaceswebBrowserSettings(string name) : TerraformResource("aws_workspacesweb_browser_settings", name)
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
    /// The browser_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrowserPolicy is required")]
    public required TerraformValue<string> BrowserPolicy
    {
        get => new TerraformReference<string>(this, "browser_policy");
        set => SetArgument("browser_policy", value);
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
    /// The browser_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> BrowserSettingsArn
    {
        get => new TerraformReference<string>(this, "browser_settings_arn");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

}
