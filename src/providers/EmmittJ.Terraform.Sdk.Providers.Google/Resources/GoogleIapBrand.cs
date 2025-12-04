using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleIapBrand.
/// Nesting mode: single
/// </summary>
public class GoogleIapBrandTimeoutsBlock : TerraformBlock
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
/// Represents a google_iap_brand Terraform resource.
/// Manages a google_iap_brand resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class GoogleIapBrand(string name) : TerraformResource("google_iap_brand", name)
{
    /// <summary>
    /// Application name displayed on OAuth consent screen.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationTitle is required")]
    public required TerraformValue<string> ApplicationTitle
    {
        get => GetArgument<TerraformValue<string>>("application_title");
        set => SetArgument("application_title", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Support email displayed on the OAuth consent screen. Can be either a
    /// user or group email. When a user email is specified, the caller must
    /// be the user with the associated email address. When a group email is
    /// specified, the caller can be either a user or a service account which
    /// is an owner of the specified group in Cloud Identity.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportEmail is required")]
    public required TerraformValue<string> SupportEmail
    {
        get => GetArgument<TerraformValue<string>>("support_email");
        set => SetArgument("support_email", value);
    }

    /// <summary>
    /// Output only. Identifier of the brand, in the format &#39;projects/{project_number}/brands/{brand_id}&#39;
    /// NOTE: The name can also be expressed as &#39;projects/{project_id}/brands/{brand_id}&#39;, e.g. when importing.
    /// NOTE: The brand identification corresponds to the project number as only one
    /// brand can be created per project.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Whether the brand is only intended for usage inside the GSuite organization only.
    /// </summary>
    public TerraformValue<bool> OrgInternalOnly
        => AsReference("org_internal_only");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIapBrandTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIapBrandTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
