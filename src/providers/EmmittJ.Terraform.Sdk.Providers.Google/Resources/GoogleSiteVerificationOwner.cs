using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleSiteVerificationOwner.
/// Nesting mode: single
/// </summary>
public class GoogleSiteVerificationOwnerTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_site_verification_owner Terraform resource.
/// Manages a google_site_verification_owner resource.
/// </summary>
public partial class GoogleSiteVerificationOwner(string name) : TerraformResource("google_site_verification_owner", name)
{
    /// <summary>
    /// The email address of the owner.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
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
    /// The id of the Web Resource to add this owner to, in the form &amp;quot;webResource/&amp;lt;web-resource-id&amp;gt;&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebResourceId is required")]
    public required TerraformValue<string> WebResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("web_resource_id");
        set => SetArgument("web_resource_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSiteVerificationOwnerTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSiteVerificationOwnerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
